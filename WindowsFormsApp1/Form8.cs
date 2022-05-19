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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }
        //Mr-Halil
        enum liste
        {
            a=1,b,c,d,e,f,g
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Int32.Parse(textBox1.Text);
            string ad = textBox2.Text;

            string deger = Enum.GetName(typeof(liste),s);

            label3.Text = deger + ") " + ad;
        }
    }
}
