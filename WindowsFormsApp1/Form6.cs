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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        abstract class deneme
        {
            public string ad, soyad, snc;
            abstract public void yazdirma();
        }

        class yazdir: deneme
        {
            public override void yazdirma()
            {
                snc = "1) " + ad + " " + soyad;
            }
        }

        class okuma: deneme
        {
            public override void yazdirma()
            {
                snc = "2) " + ad + " " + soyad;
            }
        }
        //Mr-Halil

        private void button1_Click(object sender, EventArgs e)
        {
            yazdir y = new yazdir();
            y.ad = textBox1.Text;
            y.soyad = textBox2.Text;

            y.yazdirma();
            label3.Text = y.snc;

            okuma o = new okuma();
            o.ad = textBox1.Text;
            o.soyad = textBox2.Text;

            o.yazdirma();
            label4.Text = o.snc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }
    }
}
