using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama1odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKarşılaştır_Click(object sender, EventArgs e)
        {
            byte sayı1, sayı2;
            sayı1 = Convert.ToByte(txtSayi1.Text);
            sayı2 = Convert.ToByte(txtSayi2.Text);
            if (sayı1 > sayı2)
            {
                MessageBox.Show("1.sayı 2.sayıdan büyüktür");

            }
            if (sayı1 == sayı2)
            {
                MessageBox.Show("sayılar birbirine eşitir");

            }
            if (sayı1 < sayı2)
            {
                MessageBox.Show("2.sayı 1.sayıdan buyuktur");
            }
        }
    }
}
