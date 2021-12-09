using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        int a;

        SqlConnection bag = new SqlConnection();
        SqlDataAdapter dad = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        void bosalt()
        {
            textBox2.Text = "";
            textBox1.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '%';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" && textBox1.Text == "")
                {
                    MessageBox.Show("Şifre Giriniz !", "Bilgilendirme Penceresi");
                }

                else
                {
                    a = Convert.ToInt32(textBox1.Text);

                    OpenFileDialog asd = new OpenFileDialog();
                    if
                    (asd.ShowDialog() == DialogResult.OK)
                    {

                        textBox2.Text = asd.FileName;

                    };


                }
            }

            catch{

                MessageBox.Show("Şifre Giriniz !", "Bilgilendirme Penceresi");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox2.Text == "")
                {
                    MessageBox.Show("Dosya Yolu Ekleyiniz !", "Bilgilendirme Penceresi");
                }

                else
                {

                    Byte[] dosya = File.ReadAllBytes(textBox2.Text);
                    for (int i = 0; i < dosya.Length; i++)
                    {

                        dosya[i] = (Byte)((int)dosya[i] + a);

                        if (dosya[i] > 255)
                        {
                            dosya[i] = 0;
                        }
                    }



                    File.WriteAllBytes(textBox2.Text, dosya);
                    bosalt();
                    
                }
            }
            catch
            {
                MessageBox.Show("Dosyanın Boyutu 2GB den Büyük!", "Bilgilendirme Penceresi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox2.Text == "")
                {
                    MessageBox.Show("Dosya Yolu Ekleyiniz !", "Bilgilendirme Penceresi");
                }

                else
                {

                    Byte[] dosya = File.ReadAllBytes(textBox2.Text);
                    for (int i = 0; i < dosya.Length; i++)
                    {
                        if ((Byte)((int)dosya[i] - 1) < 0)
                        {
                            dosya[i] = 255;
                        }
                        else
                            dosya[i] = (Byte)((int)dosya[i] - a);


                    }
                    File.WriteAllBytes(textBox2.Text, dosya);
                    bosalt();
                }
            }
            catch
            {
                MessageBox.Show("Dosyanın Boyutu 2GB den Büyük!", "Bilgilendirme Penceresi");
            }
            }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
