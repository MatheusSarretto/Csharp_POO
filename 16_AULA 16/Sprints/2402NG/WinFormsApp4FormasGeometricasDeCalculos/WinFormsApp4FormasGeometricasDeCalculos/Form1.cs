namespace WinFormsApp4FormasGeometricasDeCalculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada e o label de resultado
            txtMedida.Text = "";
            lblResultado.Text = "";
            cmbForma.SelectedIndex = -1; // Reseta a sele��o do ComboBox
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha o aplicativo
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Limpa o label de resultado antes de calcular
            lblResultado.Text = "";

            // L� o tipo de forma geom�trica escolhida
            string forma = cmbForma.Text.ToLower();

            // Vari�veis para armazenar os dados de entrada
            double area = 0.0;
            double lado = 0.0;
            double raio = 0.0;



            // Verifica qual forma foi escolhida e calcula a �rea correspondente
            switch (forma)
            {
                case "c�rculo":
                    if (double.TryParse(txtMedida.Text, out raio))
                    {
                        area = Math.PI * Math.Pow(raio, 2);
                        lblResultado.Text = $"�rea do c�rculo: {area:F2}";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um valor v�lido para o raio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "tri�ngulo":
                    if (double.TryParse(txtMedida.Text, out lado))
                    {
                        area = (lado * lado) / 2.0;
                        lblResultado.Text = $"�rea do tri�ngulo: {area:F2}";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um valor v�lido para a base do tri�ngulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "quadrado":
                    if (double.TryParse(txtMedida.Text, out lado))
                    {
                        area = lado * lado;
                        lblResultado.Text = $"�rea do quadrado: {area:F2}";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um valor v�lido para o lado do quadrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Por favor, selecione uma forma geom�trica v�lida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
    }

