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
    }     
}
