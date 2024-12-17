namespace FormsGestaoHotelariaAPI
{
    partial class Utilizadores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            SuspendLayout();
            // 
            // btnGetUtilizadores
            // 
            btnGetUtilizadores.Font = new Font("Segoe UI", 12F);
            btnGetUtilizadores.Location = new Point(47, 20);
            btnGetUtilizadores.Name = "btnGetUtilizadores";
            btnGetUtilizadores.Size = new Size(120, 64);
            btnGetUtilizadores.TabIndex = 0;
            btnGetUtilizadores.Text = "Carregar Utilizadores";
            btnGetUtilizadores.UseVisualStyleBackColor = true;
            btnGetUtilizadores.Click += btnGetUtilizadores_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(701, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 64);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Apagar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGet
            // 
            btnGet.Font = new Font("Segoe UI", 12F);
            btnGet.Location = new Point(192, 55);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(100, 29);
            btnGet.TabIndex = 2;
            btnGet.Text = "CARREGAR POR ID";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnPut
            // 
            btnPut.Font = new Font("Segoe UI", 12F);
            btnPut.Location = new Point(608, 20);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(87, 64);
            btnPut.TabIndex = 3;
            btnPut.Text = "Atualizar";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 12F);
            btnPost.Location = new Point(520, 20);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(82, 64);
            btnPost.TabIndex = 4;
            btnPost.Text = "Criar";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtPerfil
            // 
            txtPerfil.Location = new Point(398, 78);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(100, 23);
            txtPerfil.TabIndex = 6;
            txtPerfil.Text = "Tipo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(398, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 7;
            txtNome.Text = "Nome";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(192, 20);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 29);
            txtID.TabIndex = 8;
            txtID.Text = "ID";
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(47, 148);
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(693, 255);
            txtResponse.TabIndex = 9;
            txtResponse.Text = "";
            txtResponse.TextChanged += txtResponse_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(398, 49);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(398, 107);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 12;
            txtPassword.Text = "Password";
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // Utilizadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtResponse);
            Controls.Add(txtID);
            Controls.Add(txtNome);
            Controls.Add(txtPerfil);
            Controls.Add(btnPost);
            Controls.Add(btnPut);
            Controls.Add(btnGet);
            Controls.Add(btnDelete);
            Controls.Add(btnGetUtilizadores);
            Name = "Utilizadores";
            Text = "Utilizadores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
    }
}
