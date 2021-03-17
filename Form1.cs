using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace MiniProjeto
{    
    public partial class Form1 : Form
    {
        string path;        
        List<Hero> heroCollection;

        public Form1()
        {           
            InitializeComponent();    
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_savefile_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveOk(object sender, CancelEventArgs e)
        {
            //this.savePath = saveFileDialog1.FileName;
        }

        private void Btn_loadfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();             
        }

        private void LoadOk(object sender, CancelEventArgs e)
        {                      
            this.path = openFileDialog1.FileName;

            string jsonHeroes;
            using (StreamReader reader = new StreamReader(path))
            {
                jsonHeroes = reader.ReadToEnd();
            }

            this.heroCollection = JsonConvert.DeserializeObject<List<Hero>>(jsonHeroes);

            lb_heroes.DataSource = this.heroCollection;
            
            //string secretidenc = Encrypt(heroCollection[2].SecretId);
            //string secretiddec = Decrypt(secretidenc);
        }

        private void DeleteHero(object sender, EventArgs e)
        {
            for (int i = lb_heroes.SelectedIndices.Count - 1; i >= 0; i--)
            {                
                this.heroCollection.RemoveAt(lb_heroes.SelectedIndices[i]);                              
            }
            
            UpdateCollection();           
        }        

        private void Btn_additem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this, heroCollection);
            frm.Show();
        }

        private void Btn_edititem_Click(object sender, EventArgs e)
        {                           
            Form2 frm = new Form2(this, heroCollection, lb_heroes.SelectedIndex);

            frm.Show();               
        }

        //Custom methods
        public void UpdateCollection()
        {
            lb_heroes.DataSource = null;
            lb_heroes.DataSource = this.heroCollection;
        }

        public string Encrypt(string textToEncrypt)
        {                
            string ToReturn = "";
            string publickey = "3L0G1C4!";
            string secretkey = "C0MP4NY!";
            byte[] secretkeyByte = { };
            secretkeyByte = Encoding.UTF8.GetBytes(secretkey);
            byte[] publickeybyte = { };
            publickeybyte = Encoding.UTF8.GetBytes(publickey);
            byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                MemoryStream mstream = new MemoryStream();
                CryptoStream cstream = new CryptoStream(mstream, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                cstream.Write(inputbyteArray, 0, inputbyteArray.Length);
                cstream.FlushFinalBlock();
                ToReturn = Convert.ToBase64String(mstream.ToArray());
            }
            return ToReturn;           
        }

        public string Decrypt(string textToDecrypt)
        {                     
            string ToReturn = "";
            string publickey = "3L0G1C4!";
            string privatekey = "C0MP4NY!";
            byte[] privatekeyByte = { };
            privatekeyByte = Encoding.UTF8.GetBytes(privatekey);
            byte[] publickeybyte = { };
            publickeybyte = Encoding.UTF8.GetBytes(publickey);
            byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
            inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                MemoryStream mstream = new MemoryStream();
                CryptoStream cstream = new CryptoStream(mstream, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                cstream.Write(inputbyteArray, 0, inputbyteArray.Length);
                cstream.FlushFinalBlock();
                Encoding encoding = Encoding.UTF8;
                ToReturn = encoding.GetString(mstream.ToArray());
            }
            return ToReturn;      
        }
    }     
}
