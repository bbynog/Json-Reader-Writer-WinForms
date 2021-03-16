using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniProjeto
{
    public partial class Form2 : Form
    {       
        readonly List<Hero> heroCollection;
        private readonly Form1 mainForm = null;
        readonly Hero hero;
        List<string> powers;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form callingForm, List<Hero> _heroCollection, Hero _hero = null)
        {
            mainForm = callingForm as Form1;
            heroCollection = _heroCollection;
            hero = _hero;
            

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (hero != null)
            {
                tb_name.Text = hero.Name;
                tb_age.Text = Convert.ToString(hero.Age);
                tb_secretID.Text = hero.SecretId;                
                lb_powerlist.DataSource = hero.Powers;
                powers = hero.Powers;
                tb_newpower.Text = lb_powerlist.SelectedItem.ToString();
            }
        }

        private void Btn_save2_Click(object sender, EventArgs e)
        {           
            Hero newHero = new Hero
            {
                Name = tb_name.Text,
                Age = Int32.Parse(tb_age.Text),
                SecretId = tb_secretID.Text,
                Powers = lb_powerlist.Items.Cast<string>().ToList()
            };           
            
            heroCollection.Add(newHero);
            mainForm.UpdateCollection();
            this.Close();            
        }

        private void Btn_addSP_Click(object sender, EventArgs e)
        {
            powers = lb_powerlist.Items.Cast<string>().ToList();
            powers.Add(tb_newpower.Text);
            lb_powerlist.DataSource = powers;
            tb_newpower.Clear();            
        }

        private void Btn_deleteSP_Click(object sender, EventArgs e)
        {
            powers.RemoveAt(lb_powerlist.SelectedIndex);
            UpdatePowersList();
            tb_newpower.Clear();
        }

        public void UpdatePowersList()
        {
            lb_powerlist.DataSource = null;
            lb_powerlist.DataSource = powers;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            heroCollection.Add(hero);
            mainForm.UpdateCollection();
            this.Close();
        }

        private void Btn_editSP_Click(object sender, EventArgs e)
        {          
            powers[lb_powerlist.SelectedIndex] = tb_newpower.Text;

            UpdatePowersList();
        }

        private void lb_powerlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_powerlist.SelectedItem != null)
            {
                tb_newpower.Text = lb_powerlist.SelectedItem.ToString();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to close this window?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    heroCollection.Add(hero);
                    mainForm.UpdateCollection();                    
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
