using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
{
    public partial class Form1 : Form
    {
        string user_name = "Ferhat";
        int password = 1234;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name == textBox1.Text && password == Convert.ToInt16(textBox2.Text))
            {
                MessageBox.Show("Basariyla Giris Yaptiniz","Sign In Panel", MessageBoxButtons.OK);

                Form1 form1 = new Form1();
                this.Hide();

                Form2 form = new Form2();
                form.Show();
            }
            else if(user_name != textBox2.Text || password == Convert.ToInt16(textBox2.Text))
            {
                counter++;
                MessageBox.Show("Kullanici Adi ve Sifre Yanlis", "Sign In Panel");
            }

        }
    }
}
