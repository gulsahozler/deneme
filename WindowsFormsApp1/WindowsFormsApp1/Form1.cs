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

        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanici;
            string sifre;

            Kullanici = textBox1.Text;
            sifre = textBox2.Text;


            if (Kullanici == "Sanal Kurs" && sifre == "123456")


                MessageBox.Show("Giriş Başarılı!...");


            else


                MessageBox.Show("Hatalı Giriş!...");
        }
    }
}
