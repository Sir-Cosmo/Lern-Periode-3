using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP3_Taschenrechner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        MyUserSettings mus;
        private void Blue_Click(object sender, EventArgs e)
     {
                mus = new MyUserSettings();
                mus.BackgroundColor = Color.Blue;
                this.DataBindings.Add(new Binding("BackColor", mus, "BackgroundColor"));
     }

        private void Save_BTN(object sender, EventArgs e)
        {
            mus.Save();
        }

        private void Red_BTN(object sender, EventArgs e)
        {
            mus = new MyUserSettings();
            mus.BackgroundColor = Color.Red;
            this.DataBindings.Add(new Binding("BackColor", mus, "BackgroundColor"));
        }
    }
    }
   

