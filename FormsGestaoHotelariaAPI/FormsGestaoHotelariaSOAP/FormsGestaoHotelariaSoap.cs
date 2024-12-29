using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGestaoHotelariaSOAP
{
    public partial class FormsGestaoHotelariaSoap : Form
    {
        public FormsGestaoHotelariaSoap()
        {
            InitializeComponent();
        }

        private void btnCriarReserva_Click(object sender, EventArgs e)
        {
            // Obter os valores do formulário
            string email = txtEmail.Text.Trim();
            string quarto = txtQuarto.Text.Trim();

            // Validação básica
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(quarto))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Criar instância do serviço
                ClienteService.GestaoHotelaria service = new ClienteService.GestaoHotelaria();

                // Chamar o método CriarReserva
                string resultado = service.CriarReserva(email, quarto);

                // Exibir a resposta
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Tratar erros
                MessageBox.Show($"Erro ao criar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
