namespace FormsGestaoHotelariaAPI
{
    partial class Utilizadores
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnGetUtilizadores = new Button();
            btnDelete = new Button();
            btnGet = new Button();
            btnPut = new Button();
            btnPost = new Button();
            txtPerfil = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            txtResponse = new RichTextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblTitle = new Label();
            panelRequest = new Panel();
            panelResponse = new Panel();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(320, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "API Utilizadores";

            // 
            // panelRequest
            // 
            panelRequest.BackColor = Color.FromArgb(45, 45, 48);
            panelRequest.Controls.Add(txtPerfil);
            panelRequest.Controls.Add(txtNome);
            panelRequest.Controls.Add(txtID);
            panelRequest.Controls.Add(txtEmail);
            panelRequest.Controls.Add(txtPassword);
            panelRequest.Controls.Add(btnPost);
            panelRequest.Controls.Add(btnPut);
            panelRequest.Controls.Add(btnGet);
            panelRequest.Controls.Add(btnDelete);
            panelRequest.Location = new Point(12, 50);
            panelRequest.Name = "panelRequest";
            panelRequest.Size = new Size(760, 250);
            panelRequest.TabIndex = 1;

            // 
            // txtID
            // 
            txtID.Location = new Point(10, 10);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 29);
            txtID.TabIndex = 8;
            txtID.Text = "ID";
            txtID.Font = new Font("Segoe UI", 10F);

            // 
            // txtNome
            // 
            txtNome.Location = new Point(170, 10);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 29);
            txtNome.TabIndex = 7;
            txtNome.Text = "Nome";
            txtNome.Font = new Font("Segoe UI", 10F);

            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(10, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 29);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "Email";
            txtEmail.Font = new Font("Segoe UI", 10F);

            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(170, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 29);
            txtPassword.TabIndex = 12;
            txtPassword.Text = "Password";
            txtPassword.Font = new Font("Segoe UI", 10F);

            // 
            // txtPerfil
            // 
            txtPerfil.Location = new Point(330, 50);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(150, 29);
            txtPerfil.TabIndex = 6;
            txtPerfil.Text = "Tipo";
            txtPerfil.Font = new Font("Segoe UI", 10F);

            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPost.BackColor = Color.MediumSeaGreen;
            btnPost.ForeColor = Color.White;
            btnPost.Location = new Point(10, 150);
            btnPost.Size = new Size(120, 60);
            btnPost.Text = "Criar";
            btnPost.Click += btnPost_Click;

            // 
            // btnPut
            // 
            btnPut.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPut.BackColor = Color.Gold;
            btnPut.ForeColor = Color.White;
            btnPut.Location = new Point(140, 150);
            btnPut.Size = new Size(120, 60);
            btnPut.Text = "Atualizar";
            btnPut.Click += btnPut_Click;

            // 
            // btnGet
            // 
            btnGet.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnGet.BackColor = Color.CornflowerBlue;
            btnGet.ForeColor = Color.White;
            btnGet.Location = new Point(270, 150);
            btnGet.Size = new Size(120, 60);
            btnGet.Text = "CARREGAR";
            btnGet.Click += btnGet_Click;

            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(400, 150);
            btnDelete.Size = new Size(120, 60);
            btnDelete.Text = "Apagar";
            btnDelete.Click += btnDelete_Click;

            // 
            // panelResponse
            // 
            panelResponse.BackColor = Color.FromArgb(45, 45, 48);
            panelResponse.Controls.Add(txtResponse);
            panelResponse.Location = new Point(12, 310);
            panelResponse.Name = "panelResponse";
            panelResponse.Size = new Size(760, 200);
            panelResponse.TabIndex = 2;

            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(10, 10);
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(740, 180);
            txtResponse.TabIndex = 9;
            txtResponse.Text = "";
            txtResponse.BackColor = Color.FromArgb(30, 30, 30);
            txtResponse.ForeColor = Color.White;
            txtResponse.Font = new Font("Segoe UI", 12F);
            txtResponse.ReadOnly = true;

            // 
            // Utilizadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 521);
            Controls.Add(panelRequest);
            Controls.Add(panelResponse);
            Controls.Add(lblTitle);
            Name = "Utilizadores";
            Text = "Gestão de Utilizadores";
            BackColor = Color.FromArgb(30, 30, 30);
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnGetUtilizadores;
        private Button btnDelete;
        private Button btnGet;
        private Button btnPut;
        private Button btnPost;
        private TextBox txtPerfil;
        private TextBox txtNome;
        private TextBox txtID;
        private RichTextBox txtResponse;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblTitle;
        private Panel panelRequest;
        private Panel panelResponse;
    }
}
