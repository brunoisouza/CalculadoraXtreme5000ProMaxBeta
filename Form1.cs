using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculadoraXtreme5000ProMaxBeta
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        decimal primeiroValor;
        decimal segundoValor;
        string operador;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            operador = "+";
            primeiroValor = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            operador = "x";
            primeiroValor = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primeiroValor = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundoValor = decimal.Parse(txtResultado.Text);

            if (operador == "+")
            {                
                txtResultado.Text = (primeiroValor + segundoValor).ToString();
            }
            else if (operador == "-")
            {
                txtResultado.Text = (primeiroValor - segundoValor).ToString();
            }
            else if (operador == "x")
            {
                txtResultado.Text = (primeiroValor * segundoValor).ToString();
            }
            else
            {
                txtResultado.Text = (primeiroValor / segundoValor).ToString();
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            primeiroValor = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            string auxiliar = txtResultado.Text;

            auxiliar = auxiliar.Remove(auxiliar.Length - 1);
            txtResultado.Text = auxiliar;
        }
    }
}
