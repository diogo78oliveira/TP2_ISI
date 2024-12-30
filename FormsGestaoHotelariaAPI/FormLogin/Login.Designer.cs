namespace FormLogin
{
    partial class Login
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();

            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(159, 56);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 29);
            txtEmail.TabIndex = 0;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.BackColor = Color.FromArgb(245, 245, 245); // Fundo claro
            txtEmail.BorderStyle = BorderStyle.None;  // Remover borda padrão
            txtEmail.Padding = new Padding(5);
            txtEmail.Paint += TxtEmail_Paint; // Evento Paint para borda personalizada

            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(159, 103);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 29);
            txtPassword.TabIndex = 1;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.BackColor = Color.FromArgb(245, 245, 245);
            txtPassword.BorderStyle = BorderStyle.None; // Remover borda padrão
            txtPassword.Padding = new Padding(5);
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Paint += TxtPassword_Paint; // Evento Paint para borda personalizada

            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(187, 151);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.BackColor = Color.FromArgb(100, 150, 255); // Azul suave
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += btnLogin_Click;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 61);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Black;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 106);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;

            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 250); // Tamanho ajustado
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login Form";
            BackColor = Color.White; // Fundo branco
            ResumeLayout(false);
            PerformLayout();
        }

        #region Eventos de pintura

        // Evento para desenhar a borda no TextBox (Email)
        private void TxtEmail_Paint(object sender, PaintEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            using (Pen pen = new Pen(Color.FromArgb(100, 150, 255), 2)) // Cor da borda
            {
                e.Graphics.DrawRectangle(pen, 0, 0, txtBox.Width - 1, txtBox.Height - 1);
            }
        }

        // Evento para desenhar a borda no TextBox (Password)
        private void TxtPassword_Paint(object sender, PaintEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            using (Pen pen = new Pen(Color.FromArgb(100, 150, 255), 2)) // Cor da borda
            {
                e.Graphics.DrawRectangle(pen, 0, 0, txtBox.Width - 1, txtBox.Height - 1);
            }
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
    }
}
