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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void yaz1()
        {
            string a = textBox1.Text;
            string b = textBox2.Text;

            label3.Text = "1) " + a + " " + b;
        }

        public void yaz2(string a, string b)
        {
            label4.Text = "2) " + a + " " + b;
        }
        //Mr-Halil
        public string yaz3()
        {
            string a = textBox1.Text;
            string b = textBox2.Text;

            return "3) " + a + " " + b;
        }

        public string yaz4(string a, string b)
        {

            return "4) " + a + " " + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yaz1();
            yaz2(textBox1.Text, textBox2.Text);

            label5.Text = yaz3();
            label6.Text = yaz4(textBox1.Text, textBox2.Text);
        }

        //Mr-Halil
    }
}
