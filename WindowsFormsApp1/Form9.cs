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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        class dede
        {
            public string ek="1) ",ad, soyad, snc;
        }
        //Mr-Halil
        class cocuk : dede
        {
            public void yazdir()
            {
                snc = ek + ad + " " + soyad;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dede d = new dede();

            cocuk c = new cocuk();

            c.ad = textBox1.Text;
            c.soyad = textBox2.Text;

            c.yazdir();
            label3.Text = c.snc.ToString();
        }
    }
}
