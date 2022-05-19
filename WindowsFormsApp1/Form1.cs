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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class yazdir
        {
            public static string adim,soyadim;

            public static string yazd()
            {
                return adim + " " +soyadim;
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            yazdir.adim = textBox1.Text;
            yazdir.soyadim = textBox2.Text;

            label3.Text = yazdir.yazd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }
    }
}
