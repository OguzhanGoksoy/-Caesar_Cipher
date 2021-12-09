using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {

        

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "gfdsal" && textBox2.Text == "gfdsal09")
            {

                Form1 form2sec = new Form1();
                    form2sec.Show();
                    this.Hide();
            }
            else 
                
	
                MessageBox.Show("Kullanıcı Adınız veya Kullanıcı Şifreniz Yanlış !", "Bilgilendirme Penceresi");
            textBox2.Text = "";
            textBox1.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = button1;
            }
           
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '%';

             

        }
    }
}
