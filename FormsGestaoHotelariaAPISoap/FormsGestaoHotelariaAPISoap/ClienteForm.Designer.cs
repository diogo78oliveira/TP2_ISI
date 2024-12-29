namespace FormsGestaoHotelariaAPISoap
{
    partial class ClienteForm
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

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.btnCriarReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReservaID = new System.Windows.Forms.TextBox();
            this.txtTipoPedido = new System.Windows.Forms.TextBox();
            this.txtJustifi = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnAlterarForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarReserva
            // 
            this.btnCriarReserva.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCriarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCriarReserva.ForeColor = System.Drawing.Color.White;
            this.btnCriarReserva.Location = new System.Drawing.Point(80, 110);
            this.btnCriarReserva.Name = "btnCriarReserva";
            this.btnCriarReserva.Size = new System.Drawing.Size(141, 45);
            this.btnCriarReserva.TabIndex = 0;
            this.btnCriarReserva.Text = "Criar Reserva";
            this.btnCriarReserva.UseVisualStyleBackColor = false;
            this.btnCriarReserva.Click += new System.EventHandler(this.btnCriarReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quarto";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(80, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 29);
            this.txtEmail.TabIndex = 3;
            // 
            // txtQuarto
            // 
            this.txtQuarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuarto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuarto.Location = new System.Drawing.Point(80, 75);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(141, 29);
            this.txtQuarto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(317, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reserva ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(317, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo do Pedido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(317, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Justificação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(317, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-mail";
            // 
            // txtReservaID
            // 
            this.txtReservaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReservaID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtReservaID.Location = new System.Drawing.Point(447, 38);
            this.txtReservaID.Name = "txtReservaID";
            this.txtReservaID.Size = new System.Drawing.Size(141, 29);
            this.txtReservaID.TabIndex = 9;
            // 
            // txtTipoPedido
            // 
            this.txtTipoPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoPedido.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTipoPedido.Location = new System.Drawing.Point(447, 75);
            this.txtTipoPedido.Name = "txtTipoPedido";
            this.txtTipoPedido.Size = new System.Drawing.Size(141, 29);
            this.txtTipoPedido.TabIndex = 10;
            // 
            // txtJustifi
            // 
            this.txtJustifi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJustifi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtJustifi.Location = new System.Drawing.Point(447, 110);
            this.txtJustifi.Name = "txtJustifi";
            this.txtJustifi.Size = new System.Drawing.Size(141, 29);
            this.txtJustifi.TabIndex = 11;
            // 
            // txtEmail1
            // 
            this.txtEmail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail1.Location = new System.Drawing.Point(447, 145);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(141, 29);
            this.txtEmail1.TabIndex = 12;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelarReserva.ForeColor = System.Drawing.Color.White;
            this.btnCancelarReserva.Location = new System.Drawing.Point(433, 180);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(155, 45);
            this.btnCancelarReserva.TabIndex = 13;
            this.btnCancelarReserva.Text = "Cancelar / Alterar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = false;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnAlterarForm
            // 
            this.btnAlterarForm.BackColor = System.Drawing.Color.Khaki;
            this.btnAlterarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterarForm.ForeColor = System.Drawing.Color.White;
            this.btnAlterarForm.Location = new System.Drawing.Point(80, 174);
            this.btnAlterarForm.Name = "btnAlterarForm";
            this.btnAlterarForm.Size = new System.Drawing.Size(141, 45);
            this.btnAlterarForm.TabIndex = 14;
            this.btnAlterarForm.Text = "Gestor";
            this.btnAlterarForm.UseVisualStyleBackColor = false;
            this.btnAlterarForm.Click += new System.EventHandler(this.btnAlterarForm_Click);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 231);
            this.Controls.Add(this.btnAlterarForm);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnCriarReserva);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txtJustifi);
            this.Controls.Add(this.txtTipoPedido);
            this.Controls.Add(this.txtReservaID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuarto);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReservaID;
        private System.Windows.Forms.TextBox txtTipoPedido;
        private System.Windows.Forms.TextBox txtJustifi;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnAlterarForm;
    }
}
