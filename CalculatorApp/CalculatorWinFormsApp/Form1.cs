using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Penambahan");
            comboBox1.Items.Add("Pengurangan");
            comboBox1.Items.Add("Perkalian");
            comboBox1.Items.Add("Pembagian");
            comboBox1.SelectedIndex = 0;
        }
        private int Penambahan ( int a, int b)
        {
            return a + b;
        }

        private int Pengurangan ( int a, int b)
        {
            return a - b; 
        }

        private int Perkalian (int a, int b )
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(textBox3.Text);
            var b = Convert.ToInt32(textBox4.Text);

            ListHasil.Items.Clear();
            ListHasil.Items.Add(string.Format("Hasil Penambahan  : {0} + {1} = {2}", a, b, Penambahan(a, b)));
            ListHasil.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            ListHasil.Items.Add(string.Format("Hasil Perkalian   : {0} * {1} = {2}", a, b, Perkalian(a, b)));
            ListHasil.Items.Add(string.Format("Hasil Pembagian   : {0} / {1} = {2}", a, b, Pembagian(a, b)));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
