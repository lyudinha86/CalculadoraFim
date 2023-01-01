using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFim
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool substracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtOperacao.Text  += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtOperacao.Text  += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtOperacao.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtOperacao.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtOperacao.Text += "5";
        }

        private void btnSeish_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtOperacao.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtOperacao.Text += "7";

        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtOperacao.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtOperacao.Text += "9";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);
            txtOperacao.Text += "+";

            txtResultado.Text = "";

            adicao = true;
            substracao = false;
            multiplicacao = false;
            divisao = false;
        }

        private void btnIgualdade_Click(object sender, EventArgs e)
        {
            resultado = true;
            txtOperacao.Text += "=";
            if (adicao == true)
            {
             txtResultado.Text=Convert.ToString(Convert.ToDecimal(txtResultado.Text)+calculo);
                txtOperacao.Text += txtResultado.Text;
            }
            if (substracao == true)
            {
                txtResultado.Text = Convert.ToString(calculo-Convert.ToDecimal(txtResultado.Text));
                txtOperacao.Text += txtResultado.Text;
            }
            if (multiplicacao == true)
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) * calculo);
                txtOperacao.Text += txtResultado.Text;
            }
            if (divisao == true)
            {
                txtResultado.Text = Convert.ToString(calculo / Convert.ToDecimal(txtResultado.Text));
                txtOperacao.Text += txtResultado.Text;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtOperacao.Text = "";
        }

        private void btnSutracao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);
            txtOperacao.Text += "-";

            txtResultado.Text = "";

            adicao = false;
            substracao = true;
            multiplicacao = false;
            divisao = false;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);
            txtOperacao.Text += "x";

            txtResultado.Text = "";

            adicao = false;
            substracao = false;
            multiplicacao = true;
            divisao = false;
        }

        private void btnDivizao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);
            txtOperacao.Text += "/";

            txtResultado.Text = "";

            adicao = false;
            substracao = false;
            multiplicacao = false;
            divisao = true;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtOperacao.Text += "0";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
            txtOperacao.Text += ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = txtResultado.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);
                txtResultado.Text = Apagar;
                txtOperacao.Text = Apagar;
            }
            catch(Exception)
            {

            }
        }
    }
}
