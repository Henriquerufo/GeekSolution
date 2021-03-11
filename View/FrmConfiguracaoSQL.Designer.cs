namespace View
{
    partial class FrmConfiguracaoSQL
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracaoSQL));
            this.txtServidorBD = new System.Windows.Forms.TextBox();
            this.txtSenhaBD = new System.Windows.Forms.TextBox();
            this.txtIDBD = new System.Windows.Forms.TextBox();
            this.txtNomeBD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeBDCentral = new System.Windows.Forms.TextBox();
            this.txtIDBDCentral = new System.Windows.Forms.TextBox();
            this.txtSenhaBDCentral = new System.Windows.Forms.TextBox();
            this.txtServidorBDCentral = new System.Windows.Forms.TextBox();
            this.gbConexaoSQL = new System.Windows.Forms.GroupBox();
            this.gbConexaoSQLCentral = new System.Windows.Forms.GroupBox();
            this.txtSenhaTecSistemas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDTecSistemas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbConexaoSQL.SuspendLayout();
            this.gbConexaoSQLCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServidorBD
            // 
            this.txtServidorBD.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtServidorBD.Location = new System.Drawing.Point(6, 32);
            this.txtServidorBD.Name = "txtServidorBD";
            this.txtServidorBD.Size = new System.Drawing.Size(178, 29);
            this.txtServidorBD.TabIndex = 0;
            // 
            // txtSenhaBD
            // 
            this.txtSenhaBD.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtSenhaBD.Location = new System.Drawing.Point(6, 176);
            this.txtSenhaBD.Name = "txtSenhaBD";
            this.txtSenhaBD.Size = new System.Drawing.Size(178, 29);
            this.txtSenhaBD.TabIndex = 1;
            // 
            // txtIDBD
            // 
            this.txtIDBD.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtIDBD.Location = new System.Drawing.Point(6, 128);
            this.txtIDBD.Name = "txtIDBD";
            this.txtIDBD.Size = new System.Drawing.Size(178, 29);
            this.txtIDBD.TabIndex = 2;
            // 
            // txtNomeBD
            // 
            this.txtNomeBD.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtNomeBD.Location = new System.Drawing.Point(6, 80);
            this.txtNomeBD.Name = "txtNomeBD";
            this.txtNomeBD.Size = new System.Drawing.Size(178, 29);
            this.txtNomeBD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servidor BD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID BD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome BD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha BD";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(372, 300);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 33);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Editar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(478, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Configurações";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Banco de dados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Senha BD Central";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Nome BD Central";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(6, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "ID BD Central";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Servidor BD Central";
            // 
            // txtNomeBDCentral
            // 
            this.txtNomeBDCentral.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtNomeBDCentral.Location = new System.Drawing.Point(6, 80);
            this.txtNomeBDCentral.Name = "txtNomeBDCentral";
            this.txtNomeBDCentral.Size = new System.Drawing.Size(179, 29);
            this.txtNomeBDCentral.TabIndex = 75;
            // 
            // txtIDBDCentral
            // 
            this.txtIDBDCentral.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtIDBDCentral.Location = new System.Drawing.Point(6, 128);
            this.txtIDBDCentral.Name = "txtIDBDCentral";
            this.txtIDBDCentral.Size = new System.Drawing.Size(179, 29);
            this.txtIDBDCentral.TabIndex = 74;
            // 
            // txtSenhaBDCentral
            // 
            this.txtSenhaBDCentral.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtSenhaBDCentral.Location = new System.Drawing.Point(6, 176);
            this.txtSenhaBDCentral.Name = "txtSenhaBDCentral";
            this.txtSenhaBDCentral.Size = new System.Drawing.Size(179, 29);
            this.txtSenhaBDCentral.TabIndex = 73;
            // 
            // txtServidorBDCentral
            // 
            this.txtServidorBDCentral.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtServidorBDCentral.Location = new System.Drawing.Point(6, 32);
            this.txtServidorBDCentral.Name = "txtServidorBDCentral";
            this.txtServidorBDCentral.Size = new System.Drawing.Size(179, 29);
            this.txtServidorBDCentral.TabIndex = 72;
            // 
            // gbConexaoSQL
            // 
            this.gbConexaoSQL.Controls.Add(this.txtSenhaBD);
            this.gbConexaoSQL.Controls.Add(this.txtServidorBD);
            this.gbConexaoSQL.Controls.Add(this.txtIDBD);
            this.gbConexaoSQL.Controls.Add(this.txtNomeBD);
            this.gbConexaoSQL.Controls.Add(this.label1);
            this.gbConexaoSQL.Controls.Add(this.label2);
            this.gbConexaoSQL.Controls.Add(this.label3);
            this.gbConexaoSQL.Controls.Add(this.label4);
            this.gbConexaoSQL.Enabled = false;
            this.gbConexaoSQL.Location = new System.Drawing.Point(12, 79);
            this.gbConexaoSQL.Name = "gbConexaoSQL";
            this.gbConexaoSQL.Size = new System.Drawing.Size(190, 215);
            this.gbConexaoSQL.TabIndex = 80;
            this.gbConexaoSQL.TabStop = false;
            this.gbConexaoSQL.Text = "Conexão SQL";
            // 
            // gbConexaoSQLCentral
            // 
            this.gbConexaoSQLCentral.Controls.Add(this.txtSenhaTecSistemas);
            this.gbConexaoSQLCentral.Controls.Add(this.label12);
            this.gbConexaoSQLCentral.Controls.Add(this.txtIDTecSistemas);
            this.gbConexaoSQLCentral.Controls.Add(this.label11);
            this.gbConexaoSQLCentral.Controls.Add(this.txtSenhaBDCentral);
            this.gbConexaoSQLCentral.Controls.Add(this.txtServidorBDCentral);
            this.gbConexaoSQLCentral.Controls.Add(this.label7);
            this.gbConexaoSQLCentral.Controls.Add(this.txtIDBDCentral);
            this.gbConexaoSQLCentral.Controls.Add(this.label8);
            this.gbConexaoSQLCentral.Controls.Add(this.txtNomeBDCentral);
            this.gbConexaoSQLCentral.Controls.Add(this.label9);
            this.gbConexaoSQLCentral.Controls.Add(this.label10);
            this.gbConexaoSQLCentral.Enabled = false;
            this.gbConexaoSQLCentral.Location = new System.Drawing.Point(208, 79);
            this.gbConexaoSQLCentral.Name = "gbConexaoSQLCentral";
            this.gbConexaoSQLCentral.Size = new System.Drawing.Size(375, 215);
            this.gbConexaoSQLCentral.TabIndex = 81;
            this.gbConexaoSQLCentral.TabStop = false;
            this.gbConexaoSQLCentral.Text = "Conexão SQL Central";
            // 
            // txtSenhaTecSistemas
            // 
            this.txtSenhaTecSistemas.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtSenhaTecSistemas.Location = new System.Drawing.Point(191, 80);
            this.txtSenhaTecSistemas.Name = "txtSenhaTecSistemas";
            this.txtSenhaTecSistemas.Size = new System.Drawing.Size(179, 29);
            this.txtSenhaTecSistemas.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(191, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "SenhaTecSistemas";
            // 
            // txtIDTecSistemas
            // 
            this.txtIDTecSistemas.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtIDTecSistemas.Location = new System.Drawing.Point(191, 32);
            this.txtIDTecSistemas.Name = "txtIDTecSistemas";
            this.txtIDTecSistemas.Size = new System.Drawing.Size(179, 29);
            this.txtIDTecSistemas.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(191, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "ID TecSistemas";
            // 
            // FrmConfiguracaoSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 344);
            this.Controls.Add(this.gbConexaoSQLCentral);
            this.Controls.Add(this.gbConexaoSQL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfiguracaoSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações BD";
            this.gbConexaoSQL.ResumeLayout(false);
            this.gbConexaoSQL.PerformLayout();
            this.gbConexaoSQLCentral.ResumeLayout(false);
            this.gbConexaoSQLCentral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServidorBD;
        private System.Windows.Forms.TextBox txtSenhaBD;
        private System.Windows.Forms.TextBox txtIDBD;
        private System.Windows.Forms.TextBox txtNomeBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeBDCentral;
        private System.Windows.Forms.TextBox txtIDBDCentral;
        private System.Windows.Forms.TextBox txtSenhaBDCentral;
        private System.Windows.Forms.TextBox txtServidorBDCentral;
        private System.Windows.Forms.GroupBox gbConexaoSQL;
        private System.Windows.Forms.GroupBox gbConexaoSQLCentral;
        private System.Windows.Forms.TextBox txtSenhaTecSistemas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDTecSistemas;
        private System.Windows.Forms.Label label11;
    }
}

