using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Calculadora : Form
    {
        double num1;
        string operador;
        double[] resultado = new double[1];
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string nump = Convert.ToString(num1);
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
            operador = "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = "7";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = "8";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = "9";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = "4";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = "5";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = "6";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = "3";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = "2";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = "1";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Convert.ToString(resultado[0]);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double num2;
            double numfin;
            string nump = Convert.ToString(num1);
            int c1 = nump.Count(f => f == '.');
            
            num2 = Convert.ToDouble(Pantalla.Text);
            string nump2 = Convert.ToString(num2);
            int c2 = nump2.Count(h => h == '.');
            if (operador == "+")
            {
                numfin = (num1 + num2);
                if (c1>1 || c2>1)
                {
                    Pantalla.Text = "Syntax ERROR";
                }
                else
                {
                    Pantalla.Text = Convert.ToString(numfin);
                    num1 = numfin;
                    resultado[0] = numfin;
                }
            }
            if (operador == "-")
            {
                numfin = (num1 - num2);
                if (c1 > 1 || c2 > 1)
                {
                    Pantalla.Text = "Syntax ERROR";
                }
                else
                {
                    Pantalla.Text = Convert.ToString(numfin);
                    num1 = numfin;
                    resultado[0] = numfin;
                }
            }
            if (operador == "*")
            {
                numfin = (num1 * num2);
                if (c1 > 1 || c2 > 1)
                {
                    Pantalla.Text = "Syntax ERROR";
                }
                else
                {
                    Pantalla.Text = Convert.ToString(numfin);
                    num1 = numfin;
                    resultado[0] = numfin;
                }
            }
            if (operador == "/")
            {
                if (num2 == 0)
                {
                    Pantalla.Text = "Math EROOR";

                }
                else
                {
                    numfin = (num1 / num2);
                    Pantalla.Text = Convert.ToString(numfin);
                    num1 = numfin;
                    resultado[0] = numfin;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length > 0)
            { Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1, 1); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nump = Convert.ToString(num1);
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
            operador = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string nump = Convert.ToString(num1);
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
            operador = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string nump = Convert.ToString(num1);
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
            operador = "-";
        }
    }
}
