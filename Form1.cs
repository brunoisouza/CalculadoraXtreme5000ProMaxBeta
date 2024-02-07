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
            //captura todos os eventos de teclas antes dos componentes filhos
            this.KeyPreview = true;
        }

        decimal primeiroValor;
        decimal segundoValor;
        string operador;
        bool limparTela = false;


        //---números---
        private void btnZero_Click(object sender, EventArgs e)
        {
            escreveNumero("0");
        }
        private void btnUm_Click(object sender, EventArgs e)
        {
            escreveNumero("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            escreveNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            escreveNumero("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            escreveNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            escreveNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            escreveNumero("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            escreveNumero("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            escreveNumero("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            escreveNumero("9");
        }

        //---operadores---
        private void btnMais_Click(object sender, EventArgs e)
        {
            operador = "+";
            primeiroValor = decimal.Parse(txtResultado.Text);
            limparTela = true;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primeiroValor = decimal.Parse(txtResultado.Text);
            limparTela = true;
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            operador = "x";
            primeiroValor = decimal.Parse(txtResultado.Text);
            limparTela = true;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            primeiroValor = decimal.Parse(txtResultado.Text);
            limparTela = true;
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
            if (txtResultado.Text != "0" && txtResultado.Text != "")
                segundoValor = decimal.Parse(txtResultado.Text);
            else
                segundoValor = 0;

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
            if (primeiroValor != 0)
                if (limparTela == true)
                {
                    txtResultado.Text = numero;
                    limparTela = false;
                }                    
                else
                {
                    txtResultado.Text += numero;
                }                 

            else
            {
                if (txtResultado.Text != "0")
                    txtResultado.Text += numero;
                else
                {
                    txtResultado.Text = numero;
                }
            }
        }

        
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        //capturar tecla digitada e clicar no seu botão referente
        private void frmCalculadora_KeyPress(object sender, KeyPressEventArgs e)

        {
             //tecla 0
            if (e.KeyChar == '0')
            {
                btnZero.PerformClick();
                e.Handled = true;
            }
            //tecla 1
            if (e.KeyChar == '1')
            {
                btnUm.PerformClick();
                e.Handled = true;
            }
            //tecla 2
            if (e.KeyChar == '2')
            {
                btnDois.PerformClick();
                e.Handled = true;
            }
            //tecla 3
            if (e.KeyChar == '3')
            {
                btnTres.PerformClick();
                e.Handled = true;
            }
            //tecla 4
            if (e.KeyChar == '4')
            {
                btnQuatro.PerformClick();
                e.Handled = true;
            }
            //tecla 5
            if (e.KeyChar == '5')
            {
                btnCinco.PerformClick();
                e.Handled = true;
            }
            //tecla 6
            if (e.KeyChar == '6')
            {
                btnSeis.PerformClick();
                e.Handled = true;
            }
            //tecla 7
            if (e.KeyChar == '7')
            {
                btnSete.PerformClick();
                e.Handled = true;
            }
            //tecla 8
            if (e.KeyChar == '8')
            {
                btnOito.PerformClick();
                e.Handled = true;
            }
            //tecla 9
            if (e.KeyChar == '9')
            {
                btnNove.PerformClick();
                e.Handled = true;
            }

            //tecla Mais
            if (e.KeyChar == '+')
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
            if (e.KeyChar == ',')
            {
                btnVirgula.PerformClick();
                e.Handled = true;
            }

            //tecla Menos
            if (e.KeyChar == '-')
            {
                btnMenos.PerformClick();
                e.Handled = true;
            }

            //tecla Divisão
            if (e.KeyChar == '/')
            {
                btnDivisao.PerformClick();
                e.Handled = true;
            }

        }
    }
    
}
