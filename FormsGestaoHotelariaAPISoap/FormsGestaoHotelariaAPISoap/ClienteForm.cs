using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsGestaoHotelariaAPISoap
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void btnCriarReserva_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string quarto = txtQuarto.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(quarto))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ServiceCliente.GestaoHotelaria service = new ServiceCliente.GestaoHotelaria();

                string resultado = service.CriarReserva(email, quarto);

                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao criar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            string reservaIdInput = txtReservaID.Text.Trim();
            string justificacao = txtJustifi.Text.Trim();
            string tipoPedido = txtTipoPedido.Text.Trim();
            string email = txtEmail1.Text.Trim();

            if (string.IsNullOrWhiteSpace(reservaIdInput) ||
                string.IsNullOrWhiteSpace(justificacao) ||
                string.IsNullOrWhiteSpace(tipoPedido) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(reservaIdInput, out int ReservaID))
            {
                MessageBox.Show("O campo ReservaID deve conter apenas números inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ServiceCliente.GestaoHotelaria service = new ServiceCliente.GestaoHotelaria();
                string resultado = service.AlterarOuCancelarReserva(ReservaID, justificacao, tipoPedido, email);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestorForm gestorForm = new GestorForm();
            gestorForm.Show();
        }
    }
}
