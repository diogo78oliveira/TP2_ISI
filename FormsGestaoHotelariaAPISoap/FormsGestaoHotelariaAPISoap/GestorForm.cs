using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGestaoHotelariaAPISoap
{
    public partial class GestorForm : Form
    {
        public GestorForm()
        {
            InitializeComponent();
        }

        private void btnAprovarouRejeitarPedido_Click(object sender, EventArgs e)
        {
            string pedidoIdInput = txtPedido.Text.Trim();
            string isApprovedInput = txtisApproved.Text.Trim();

            if (string.IsNullOrWhiteSpace(pedidoIdInput) || string.IsNullOrWhiteSpace(isApprovedInput))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(pedidoIdInput, out int PedidoID))
            {
                MessageBox.Show("O campo PedidoID deve conter apenas números inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!bool.TryParse(isApprovedInput, out bool isApproved))
            {
                MessageBox.Show("O campo 'isApproved' deve ser 'true' ou 'false'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ServiceGestor.GestaoHotelariaGestor service = new ServiceGestor.GestaoHotelariaGestor();
                string resultado = service.AprovarOuRejeitarPedido(PedidoID, isApproved);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar pedido: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAprovarReserva_Click(object sender, EventArgs e)
        {
            {
                string reservaIdInput = txtReserva.Text.Trim();

                if (string.IsNullOrWhiteSpace(reservaIdInput))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(reservaIdInput, out int ReservaID))
                {
                    MessageBox.Show("O campo PedidoID deve conter apenas números inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    ServiceGestor.GestaoHotelariaGestor service = new ServiceGestor.GestaoHotelariaGestor();
                    string resultado = service.AprovarReserva(ReservaID);
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao processar pedido: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConcluirReserva_Click(object sender, EventArgs e)
        {
            {
                string reservaIdInput = txtReserva1.Text.Trim();

                if (string.IsNullOrWhiteSpace(reservaIdInput))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(reservaIdInput, out int ReservaID))
                {
                    MessageBox.Show("O campo PedidoID deve conter apenas números inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    ServiceGestor.GestaoHotelariaGestor service = new ServiceGestor.GestaoHotelariaGestor();
                    string resultado = service.ConcluirReserva(ReservaID);
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao processar pedido: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
    

  
 
