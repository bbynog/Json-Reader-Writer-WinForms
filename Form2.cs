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
        private readonly Form1 mainForm;        
        readonly int? heroIndex;
        List<string> powers;
                
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form callingForm, List<Hero> _heroCollection, int? _heroIndex = -1)
        {
            mainForm = callingForm as Form1;
            heroCollection = _heroCollection;
            heroIndex = _heroIndex;
            

            InitializeComponent();
        }        

        private void Form2_Load(object sender, EventArgs e)
        {
            if (heroIndex != -1)
            {
                int hIndex = heroIndex ?? default;
                tb_name.Text = heroCollection[hIndex].Name;
                tb_age.Text = Convert.ToString(heroCollection[hIndex].Age);
                tb_secretID.Text = heroCollection[hIndex].SecretId;                
                lb_powerlist.DataSource = heroCollection[hIndex].Powers;
                powers = heroCollection[hIndex].Powers;
                tb_newpower.Text = lb_powerlist.SelectedItem.ToString();
            }
        }

        private void Btn_save2_Click(object sender, EventArgs e)
        {       
            if (heroIndex != -1)
            {
                int hIndex = heroIndex ?? default;
                heroCollection[hIndex].Name = tb_name.Text;
                heroCollection[hIndex].Age = Int32.Parse(tb_age.Text);
                heroCollection[hIndex].SecretId = tb_secretID.Text;
                heroCollection[hIndex].Powers = lb_powerlist.Items.Cast<string>().ToList();
            }
            else
            {
                Hero newHero = new Hero
                {
                    Name = tb_name.Text,
                    Age = Int32.Parse(tb_age.Text),
                    SecretId = tb_secretID.Text,
                    Powers = lb_powerlist.Items.Cast<string>().ToList()
                };

                heroCollection.Add(newHero);                
            }

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
            lb_powerlist.SetSelected(0, true);
            powers.RemoveAt(lb_powerlist.SelectedIndex);
            UpdatePowersList();
            tb_newpower.Clear();
        }        

        private void Btn_back_Click(object sender, EventArgs e)
        {            
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

        //Custom Methods
        public void UpdatePowersList()
        {
            lb_powerlist.DataSource = null;
            lb_powerlist.DataSource = powers;
        }
    }
}
