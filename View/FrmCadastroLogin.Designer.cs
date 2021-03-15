namespace View
{
    partial class FrmCadastroLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroLogin));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.rbSupervisor = new System.Windows.Forms.RadioButton();
            this.rbEstoquista = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.lblLoginsCadastrados = new System.Windows.Forms.Label();
            this.lblLoginsContratados = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtID.Location = new System.Drawing.Point(3, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(244, 29);
            this.txtID.TabIndex = 61;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtSenha.Location = new System.Drawing.Point(3, 64);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(244, 29);
            this.txtSenha.TabIndex = 62;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtConfirmarSenha.Location = new System.Drawing.Point(3, 112);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(244, 29);
            this.txtConfirmarSenha.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "ID";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblConfirmarSenha.Location = new System.Drawing.Point(0, 96);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmarSenha.TabIndex = 66;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(65, 320);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 33);
            this.btnCadastrar.TabIndex = 67;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(171, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 70;
            this.label6.Text = "Login";
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(12, 9);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(143, 33);
            this.lblCadastrar.TabIndex = 69;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.rbSupervisor);
            this.pnlLogin.Controls.Add(this.rbEstoquista);
            this.pnlLogin.Controls.Add(this.rbVendedor);
            this.pnlLogin.Controls.Add(this.rbAdministrador);
            this.pnlLogin.Controls.Add(this.txtConfirmarSenha);
            this.pnlLogin.Controls.Add(this.txtID);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.lblConfirmarSenha);
            this.pnlLogin.Location = new System.Drawing.Point(18, 85);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(253, 206);
            this.pnlLogin.TabIndex = 71;
            // 
            // rbSupervisor
            // 
            this.rbSupervisor.AutoSize = true;
            this.rbSupervisor.Location = new System.Drawing.Point(128, 173);
            this.rbSupervisor.Name = "rbSupervisor";
            this.rbSupervisor.Size = new System.Drawing.Size(75, 17);
            this.rbSupervisor.TabIndex = 70;
            this.rbSupervisor.Text = "Supervisor";
            this.rbSupervisor.UseVisualStyleBackColor = true;
            // 
            // rbEstoquista
            // 
            this.rbEstoquista.AutoSize = true;
            this.rbEstoquista.Location = new System.Drawing.Point(34, 173);
            this.rbEstoquista.Name = "rbEstoquista";
            this.rbEstoquista.Size = new System.Drawing.Size(74, 17);
            this.rbEstoquista.TabIndex = 69;
            this.rbEstoquista.Text = "Estoquista";
            this.rbEstoquista.UseVisualStyleBackColor = true;
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Checked = true;
            this.rbVendedor.Location = new System.Drawing.Point(128, 150);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rbVendedor.TabIndex = 68;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Location = new System.Drawing.Point(34, 150);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rbAdministrador.TabIndex = 67;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // lblLoginsCadastrados
            // 
            this.lblLoginsCadastrados.AutoSize = true;
            this.lblLoginsCadastrados.Location = new System.Drawing.Point(18, 294);
            this.lblLoginsCadastrados.Name = "lblLoginsCadastrados";
            this.lblLoginsCadastrados.Size = new System.Drawing.Size(72, 13);
            this.lblLoginsCadastrados.TabIndex = 72;
            this.lblLoginsCadastrados.Text = "Cadastrados: ";
            this.lblLoginsCadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoginsContratados
            // 
            this.lblLoginsContratados.AutoSize = true;
            this.lblLoginsContratados.Location = new System.Drawing.Point(178, 294);
            this.lblLoginsContratados.Name = "lblLoginsContratados";
            this.lblLoginsContratados.Size = new System.Drawing.Size(70, 13);
            this.lblLoginsContratados.TabIndex = 73;
            this.lblLoginsContratados.Text = "Contratados: ";
            this.lblLoginsContratados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 364);
            this.Controls.Add(this.lblLoginsContratados);
            this.Controls.Add(this.lblLoginsCadastrados);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastroLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Sistemas: Cadastrar Novo Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.RadioButton rbSupervisor;
        private System.Windows.Forms.RadioButton rbEstoquista;
        private System.Windows.Forms.Label lblLoginsCadastrados;
        private System.Windows.Forms.Label lblLoginsContratados;
    }
}