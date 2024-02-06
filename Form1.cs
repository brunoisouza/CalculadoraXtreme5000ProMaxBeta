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


        //---números---
        private void btn0_Click(object sender, EventArgs e)
        {
            escreveNumero("0");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            escreveNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            escreveNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            escreveNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            escreveNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            escreveNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            escreveNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            escreveNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            escreveNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            escreveNumero("9");
        }

        //---operadores---
        private void btnMais_Click(object sender, EventArgs e)
        {
            operador = "+";
            primeiroValor = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primeiroValor = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            operador = "x";
            primeiroValor = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            primeiroValor = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        //---outros botões---
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            string auxiliar = txtResultado.Text;

            if (auxiliar != "")
            {
                auxiliar = auxiliar.Remove(auxiliar.Length - 1);
                txtResultado.Text = auxiliar;

                if (auxiliar == "")
                {
                    txtResultado.Text = "0";
                }
            }
            else
            {
                txtResultado.Text = "0";
            }

        }

        //---calcular resultado---
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
            else if (operador == "/")
            {
                if (segundoValor == 0)
                {
                    txtResultado.Text = "Não é possível dividir por zero";
                }
                else
                {
                    txtResultado.Text = (primeiroValor / segundoValor).ToString();
                }                
            }
        }

        // início das funções

        // escrever numero na tela
        private void escreveNumero(string numero)
        {
            if (txtResultado.Text != "0")
                txtResultado.Text += numero;
            else
            {
                txtResultado.Text = numero;
            }
        }

        //capturar tecla digitada e clicar no seu botão referente
        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tecla 0
            if (e.KeyChar == (char)Keys.D0)
            {
                btnZero.PerformClick();
                e.Handled = true;
            }
            //tecla 1
            if (e.KeyChar == (char)Keys.D1)
            {
                btnUm.PerformClick();
                e.Handled = true;
            }
            //tecla 2
            if (e.KeyChar == (char)Keys.D2)
            {
                btnDois.PerformClick();
                e.Handled = true;
            }
            //tecla 3
            if (e.KeyChar == (char)Keys.D3)
            {
                btnTres.PerformClick();
                e.Handled = true;
            }
            //tecla 4
            if (e.KeyChar == (char)Keys.D4)
            {
                btnQuatro.PerformClick();
                e.Handled = true;
            }
            //tecla 5
            if (e.KeyChar == (char)Keys.D5)
            {
                btnCinco.PerformClick();
                e.Handled = true;
            }
            //tecla 6
            if (e.KeyChar == (char)Keys.D6)
            {
                btnSeis.PerformClick();
                e.Handled = true;
            }
            //tecla 7
            if (e.KeyChar == (char)Keys.D7)
            {
                btnSete.PerformClick();
                e.Handled = true;
            }
            //tecla 8
            if (e.KeyChar == (char)Keys.D8)
            {
                btnOito.PerformClick();
                e.Handled = true;
            }
            //tecla 9
            if (e.KeyChar == (char)Keys.D9)
            {
                btnNove.PerformClick();
                e.Handled = true;
            }

            //tecla Mais
            if (e.KeyChar == (char)Keys.Oemplus)
            {
                btnMais.PerformClick();
                e.Handled = true;
            }

            //tecla BackSpace
            if (e.KeyChar == (char)Keys.Back)
            {
                btnBackSpace.PerformClick();
                e.Handled = true;
            }

            //tecla Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIgual.PerformClick();
                e.Handled = true;
            }

            //tecla Vírgula
            if (e.KeyChar == (char)Keys.Oemcomma)
            {
                btnVirgula.PerformClick();
                e.Handled = true;
            }

            //tecla Menos
            if (e.KeyChar == (char)Keys.OemMinus)
            {
                btnMenos.PerformClick();
                e.Handled = true;
            }

            //tecla Divisão
            if (e.KeyChar == (char)Keys.Divide)
            {
                btnDivisao.PerformClick();
                e.Handled = true;
            }
            


        }
    }
    
}
