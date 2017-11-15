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

namespace pas
{
    public partial class Key : Form
    {
        private string key;
        public Key(string key)
        {
            InitializeComponent();
            this.key = key;
            label2.Text = key;
        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            NewPass newpass = new NewPass(key);
            newpass.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Key_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}