namespace View
{
    partial class FrmEntradaProduto
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
            this.txtCodigoBarras = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCodigoEncontrado = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCodigoNaoEncontrado = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.pnlCodigoEncontrado.SuspendLayout();
            this.pnlCodigoNaoEncontrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.txtCodigoBarras.Location = new System.Drawing.Point(12, 406);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(481, 29);
            this.txtCodigoBarras.TabIndex = 0;
            this.txtCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.SuaLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 375);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Valor Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nome do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Quantidade";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(9, 390);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoBarras.TabIndex = 92;
            this.lblCodigoBarras.Text = "Código de Barras";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.txtQuantidade.Location = new System.Drawing.Point(499, 406);
            this.txtQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(140, 29);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitario.Location = new System.Drawing.Point(353, 454);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(140, 29);
            this.txtValorUnitario.TabIndex = 90;
            this.txtValorUnitario.TabStop = false;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 454);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(335, 29);
            this.txtNomeProduto.TabIndex = 89;
            this.txtNomeProduto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 57);
            this.label4.TabIndex = 98;
            this.label4.Text = "Código";
            // 
            // pnlCodigoEncontrado
            // 
            this.pnlCodigoEncontrado.BackColor = System.Drawing.Color.Green;
            this.pnlCodigoEncontrado.Controls.Add(this.label5);
            this.pnlCodigoEncontrado.Controls.Add(this.label4);
            this.pnlCodigoEncontrado.Location = new System.Drawing.Point(393, 12);
            this.pnlCodigoEncontrado.Name = "pnlCodigoEncontrado";
            this.pnlCodigoEncontrado.Size = new System.Drawing.Size(247, 176);
            this.pnlCodigoEncontrado.TabIndex = 101;
            this.pnlCodigoEncontrado.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 57);
            this.label5.TabIndex = 99;
            this.label5.Text = "Encontrado";
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.Enabled = false;
            this.txtQuantidadeEstoque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(499, 454);
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(140, 29);
            this.txtQuantidadeEstoque.TabIndex = 102;
            this.txtQuantidadeEstoque.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Quantidade no Estoque";
            // 
            // pnlCodigoNaoEncontrado
            // 
            this.pnlCodigoNaoEncontrado.BackColor = System.Drawing.Color.DarkRed;
            this.pnlCodigoNaoEncontrado.Controls.Add(this.label7);
            this.pnlCodigoNaoEncontrado.Controls.Add(this.label8);
            this.pnlCodigoNaoEncontrado.Location = new System.Drawing.Point(393, 211);
            this.pnlCodigoNaoEncontrado.Name = "pnlCodigoNaoEncontrado";
            this.pnlCodigoNaoEncontrado.Size = new System.Drawing.Size(247, 176);
            this.pnlCodigoNaoEncontrado.TabIndex = 104;
            this.pnlCodigoNaoEncontrado.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 57);
            this.label7.TabIndex = 99;
            this.label7.Text = "Encontrado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 57);
            this.label8.TabIndex = 98;
            this.label8.Text = "Código não";
            // 
            // FrmEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 498);
            this.Controls.Add(this.pnlCodigoNaoEncontrado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantidadeEstoque);
            this.Controls.Add(this.pnlCodigoEncontrado);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtNomeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEntradaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntradaProduto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEntradaProduto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.pnlCodigoEncontrado.ResumeLayout(false);
            this.pnlCodigoEncontrado.PerformLayout();
            this.pnlCodigoNaoEncontrado.ResumeLayout(false);
            this.pnlCodigoNaoEncontrado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCodigoBarras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCodigoEncontrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCodigoNaoEncontrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}