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
    public partial class NewPass : Form
    {
        private string key;
        private Encrypt encrypt = new Encrypt();
        public NewPass(string key)
        {
            this.key = key;
            InitializeComponent();


        }

        private void NewPass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldp = textBox1.Text;
            string newp = textBox2.Text;
                if ((!encrypt.CheckPass(oldp, key)) || (textBox2.Text != textBox3.Text))
                {
                    MessageBox.Show("Пароли не совпадают! Либо введен неправильный старый пароль");
                }

                else
                {
                Key key = new Key(encrypt.Write(newp));
                key.Show();
                Close();
                }
            }
        }
    }

