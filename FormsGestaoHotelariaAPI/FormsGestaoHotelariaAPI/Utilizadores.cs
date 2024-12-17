using FormsGestaoHotelariaAPI.Shared;

namespace FormsGestaoHotelariaAPI
{
    public partial class Utilizadores : Form
    {
        public Utilizadores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private async void btnGetUtilizadores_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.GetALL();
            txtResponse.Text = RestHelper.FormatJson(response);
        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnPost_Click(object sender, EventArgs e)
        {

            int utilizadorID = 0;

            var response = await RestHelper.Post(
                utilizadorID,
                txtNome.Text,
                txtEmail.Text,
                txtPerfil.Text,
                txtPassword.Text
            );

            txtResponse.Text = RestHelper.FormatJson(response);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Get(txtID.Text);
            txtResponse.Text = RestHelper.FormatJson(response);

        }

        private async void btnPut_Click(object sender, EventArgs e)
        {

            int.TryParse(txtID.Text, out int utilizadorID);
            {

                var response = await RestHelper.PUT(
                    utilizadorID,
                    txtNome.Text,
                    txtEmail.Text,
                    txtPerfil.Text,
                    txtPassword.Text
                );

                MessageBox.Show("Sucesso");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

                var response = await RestHelper.Delete(
                    txtID.Text
                );

                MessageBox.Show("Sucesso");
 
        }
    }

}

