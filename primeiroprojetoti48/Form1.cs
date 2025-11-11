using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class Form1 : Form
    {
        private object label1;
        private object txtnum1;
        private object txtnum2;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            btncalculadora.Text = "ola texto ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double soma1 = double.Parse(txt1.Text);
            double soma2 = double.Parse(txt2.Text);

            double resultado = soma1 / soma2;

            txt3.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double soma1 = double.Parse(txt1.Text);
            double soma2 = double.Parse(txt2.Text);

            double resultado = soma1 + soma2;

            txt3.Text = resultado.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double soma1 = double.Parse(txt1.Text);
            double soma2 = double.Parse(txt2.Text);

            double resultado = soma1 - soma2;

            txt3.Text = resultado.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double soma1 = double.Parse(txt1.Text);
            double soma2 = double.Parse(txt2.Text);

            double resultado = soma1 * soma2;

            txt3.Text = resultado.ToString();
        }
    }
}
