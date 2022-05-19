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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        class yazdir
        {
            private string snc1,snc2;
            public string ad
            {
                get
                {
                    return snc1;
                }
                set
                {
                   snc1 = value.ToUpper();
                }
            }

            public string soyad
            {
                get
                {
                    return snc2;
                }
                set
                {
                    snc2 = value.ToUpper();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yazdir y = new yazdir();
            y.ad = textBox1.Text;
            y.soyad = textBox2.Text;

            label3.Text = y.ad + " " + y.soyad;
        }
    }
}
