using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJCalcCientifica
{
    public partial class Form1 : Form
    {

        Double valor1 = 0.0; // variavel que vai armazenar o primeiro valor que o usuario digitar na calculadora.
        String op = ""; // vai armazenar o tipo de operação que vai ser feito, ex: se for soma op = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "4";
        }

       

        private void BtnUm_Click(object sender, EventArgs e)
        {
            // esse if está em todos os botões de numeros
            
            if (lblDisplay.Text == "0") // verificar se o valor que está na label (telinha que mostra o numero da calculadora) é 0 (valor padrão)
            {
                lblDisplay.Text = ""; // se for 0 ele vai primeiro limpar trocando de "0" para uma Strng vazia ""
            }
            lblDisplay.Text = lblDisplay.Text + "1"; // e depois adicionar o numero correspondente do botão na label(telinha);
            

        }


         private void BtnDois_Click(object sender, EventArgs e)
             {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "3";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "6";
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "7";
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "9";
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "0";
        }

        // botões de calcular, +,-,x,/

        private void BtnSub_Click(object sender, EventArgs e)
        {
            // esse é o padrão de todos os botões de calculo (soma,sub,mult,div), oq vai mudar é só o op ali em baixo.

            valor1 = Double.Parse(lblDisplay.Text); // salva o primeiro valor digitado pelo usuario na variavel global valor1.

            lblDisplay.Text = ""; // apaga o valor que o usuario digitou primeiro, ja que ele ja salvou na variavel global na linha cima;

            op = "-"; // o tipo de operação que vai ser usado, como é subtração -, do soma vai ser + e etc...
        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(lblDisplay.Text);

            lblDisplay.Text = "";

            op = "+";
        }

        

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(lblDisplay.Text);

            lblDisplay.Text = "";

            op = "x";
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(lblDisplay.Text);

            lblDisplay.Text = "";

            op = "/";
        }


        private void BtnSen_Click(object sender, EventArgs e)
        {
            // pega o primeiro valor digitado,
            // faz o calculo de seno e ja exibe o resultado na tela sem precisa apertar em =.

            valor1 = Double.Parse(lblDisplay.Text);
            double pi = Math.PI;
            double rad = (valor1 * pi) / 180;
            double resultado = Math.Sin(rad);
            lblDisplay.Text = resultado.ToString();
        }   

        private void BtnCos_Click(object sender, EventArgs e)
        {

            // pega o primeiro valor digitado,
            //faz o calculo de coseno e ja exibe o resultado na tela sem precisar apertar em =.

            valor1 = Double.Parse(lblDisplay.Text);
            double pi = Math.PI;
            double rad = (valor1 * pi) / 180;
            double resultado = Math.Cos(rad);
            lblDisplay.Text = resultado.ToString();
        }

        //botão para apagar só o ultimo valor digitado.
        private void BtnApaga_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblDisplay.Text)) // verifica se tem algum texto na label(telinha).
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1); // se tiver, ele pega o tamanho da String (quantos caracteres tem digitados e tira o ultimo (-1)
            }
        }

        private void BtnNegativo_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(lblDisplay.Text); 
            
            valor1 = -valor1; // troca o sinal do valor digitado, exemplo: se for 50 fica -50, se for -50 ( - com - é +) então fica 50;
            
            lblDisplay.Text = valor1.ToString(); //atualiza o valor da variavel global que aparece na telinha.
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains(",")) // verifica se ja tem virgula digitada.
            {
                lblDisplay.Text = lblDisplay.Text; // se sim, não faz nada.
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + ","; // se não, ele adiciona a virgula.

            }
        }


        // botão para resetar a calculadora e fazer calculos do começo.
        private void BtnLimpa_Click(object sender, EventArgs e)
        {

            valor1 = 0; // volta o valor da variavel global pro padrão.
            lblDisplay.Text = "0"; // volta o numero da telinha pro padrão.
            op = ""; // volta o operador pro padrão
        }


        // botão de resultado que faz todos os calculos.
       private void BtnResultado_Click(object sender, EventArgs e)
            //padrão pra todas as operações.
        {
            if (op == "+") // verifica o tipo de operação que você apertou. nesse caso soma (+)
            {
                Double valor2 = Double.Parse(lblDisplay.Text); // pega o segundo valor que o usuario digitou (depois da telinha apagada depois de você clickar em algum botão de operação)
               
                Double resultado = valor1 + valor2; // calcula os 2 valores e salva na variavel resultado.
                
                lblDisplay.Text = resultado.ToString(); // converte a variavel com o resultado pra String e coloca na telinha (label).
            }
            if (op == "-")
            {
                Double valor2 = Double.Parse(lblDisplay.Text);
                Double resultado = valor1 - valor2;
                lblDisplay.Text = resultado.ToString();
            }
            if (op == "x")
            {
                Double valor2 = Double.Parse(lblDisplay.Text);
                Double resultado = valor1 * valor2;
                lblDisplay.Text = resultado.ToString();
            }
            if (op == "/")
            {
                Double valor2 = Double.Parse(lblDisplay.Text);
                Double resultado = valor1 / valor2;
                lblDisplay.Text = resultado.ToString();
            }
        }
    }

}

