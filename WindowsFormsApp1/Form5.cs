using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public string yaz()
        {
            return textBox1.Text + " " + textBox2.Text;
        }
        public string yaz(string a)
        {
            return a;
        }
        public string yaz(string a, string b)
        {
            return a + " " + b;
        }

        class yazdir
        {
            public static string a, b;
            public string snc1,snc2,snc3;
            public yazdir()
            {
                snc1 = a + " " + b;
            }
            public yazdir(string ad)
            {
                snc2 = ad + " " + b;
            }
            public yazdir(string ad, string soyad)
            {
                snc3 = ad + " " + soyad;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = yaz();
            label4.Text = yaz(textBox1.Text);
            label5.Text = yaz(textBox1.Text, textBox2.Text);
            //-----------------------------------------------------//

            yazdir.a = textBox1.Text;
            yazdir.b = textBox2.Text;

            yazdir y = new yazdir();
            label6.Text = y.snc1;

            yazdir yz = new yazdir(textBox1.Text);
            label7.Text = yz.snc2;

            yazdir yza = new yazdir(textBox1.Text, textBox2.Text);
            label8.Text = yza.snc3;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Close();
        }
    }
}
