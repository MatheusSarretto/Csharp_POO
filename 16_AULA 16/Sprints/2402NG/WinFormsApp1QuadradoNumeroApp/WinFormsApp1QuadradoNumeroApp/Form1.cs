namespace WinFormsApp1QuadradoNumeroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verifica se o usu�rio digitou um n�mero v�lido
            if (int.TryParse(textBox1.Text, out int numero))
            {
                // Calcula o quadrado do n�mero
                int quadrado = numero * numero;

                // Exibe o resultado na label correspondente
                lblResultado.Text = $"O quadrado de {numero} �: {quadrado}";
            }
            else
            {
                // Caso o usu�rio n�o tenha digitado um n�mero v�lido
                MessageBox.Show("Por favor, digite um n�mero inteiro v�lido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

