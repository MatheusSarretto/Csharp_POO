using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculadoraMediaWhileParar
{
    public partial class Form1 : Form
    {
        private List<double> numeros = new List<double>();
        private bool continuar = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            continuar = true;
            while (continuar)
            {
                
                Application.DoEvents();
            }
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'p' || e.KeyChar == 'P')
            {
                // Parar o loop
                continuar = false;

                // Calcular a m�dia e exibir
                if (numeros.Count == 0)
                {
                    MessageBox.Show("Nenhum n�mero foi inserido.");
                    return;
                }

                double soma = 0;
                foreach (var num in numeros)
                {
                    soma += num;
                }

                double media = soma / numeros.Count;
                labelMedia.Text = "M�dia: " + media.ToString("F2");
                MessageBox.Show("A m�dia dos n�meros inseridos �: " + media.ToString("F2"), "M�dia");

                // Desativar o TextBox ap�s calcular a m�dia
                textBoxNumero.Enabled = false;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                // Adicionar o n�mero � lista ao pressionar Enter
                try
                {
                    double numero = Convert.ToDouble(textBoxNumero.Text);
                    numeros.Add(numero);
                    textBoxNumero.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira um n�mero v�lido.");
                    textBoxNumero.Clear();
                }
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Ignorar outros caracteres
            }
        }

        private void resetarButton_Click(object sender, EventArgs e)
        {
            // Resetar a lista e o estado
            numeros.Clear();
            continuar = true;

            // Limpar o TextBox e habilit�-lo novamente
            textBoxNumero.Clear();
            textBoxNumero.Enabled = true;
            // Limpar o Label
            labelMedia.Text = "M�dia dos N�meros";
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            // Sair do programa
            Application.Exit();
        }
    }
}
