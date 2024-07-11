using System.Diagnostics;

namespace WinFormsApp1_SucessorAntecessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                // Verifica se o usu�rio digitou um n�mero v�lido
                if (int.TryParse(txtNumero.Text, out int numero))
                {
                    // Calcula o sucessor e exibe na label correspondente
                    lblSucessor.Text = $"Sucessor: {numero + 1}";

                    // Calcula o antecessor e exibe na label correspondente
                    lblAntecessor.Text = $"Antecessor: {numero - 1}";
                }
                else
                {
                    // Caso o usu�rio n�o tenha digitado um n�mero v�lido
                    MessageBox.Show("Por favor, digite um n�mero inteiro v�lido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

    }
    
    