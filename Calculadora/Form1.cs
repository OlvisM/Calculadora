using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string Operador;
        double Primero;
        double Segundo;
        public Form1()
        {
            InitializeComponent();
        }

        Sumar S = new Sumar();
        Restar R = new Restar();
        Multiplicar M = new Multiplicar();
        Dividir D = new Dividir();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Operador = "+";
            Primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Operador = "-";
            Primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Operador = "*";
            Primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Operador = "/";
            Primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Segundo = double.Parse(textBox1.Text);

            double Suma;
            double Mult;
            double Divv;
            double Ress;

            switch (Operador)
            {
                case "+":
                    Suma = S.Sumar1((Primero), (Segundo));
                    textBox1.Text = Suma.ToString();
                  break;

                    case "-":
                    Ress = R.Restar1((Primero), (Segundo));
                    textBox1.Text = Ress.ToString();
                    break;
                     case "*":
                    Mult = M.Multiplicar1((Primero), (Segundo));
                    textBox1.Text = Mult.ToString();
                    break;
                case "/":
                    Divv = D.Dividir1((Primero), (Segundo));
                    textBox1.Text = Divv.ToString();
                    break;
                
            }
        }
    }
}
