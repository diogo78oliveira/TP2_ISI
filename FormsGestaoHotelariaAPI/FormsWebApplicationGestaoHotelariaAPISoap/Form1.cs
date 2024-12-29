using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsWebApplicationGestaoHotelariaAPISoap.GestaoHotelariaClienteSvc;


namespace FormsWebApplicationGestaoHotelariaAPISoap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciar o serviço
                GestaoHotelariaClienteSvc client = new GestaoHotelariaClienteSvc();

                // Capturar valores do formulário
                string email = txtEmail.Text;
                string quarto = txtQuarto.Text;

                // Validação simples
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(quarto))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                // Chamar o método CriarReserva do serviço
                string resultado = client.CriarReserva(email, quarto);

                // Exibir resultado
                MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

