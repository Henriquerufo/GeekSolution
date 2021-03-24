namespace View
{
    partial class FrmCadastrarTema
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderecoImagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColorR = new System.Windows.Forms.TextBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.btnSelecionarFundo = new System.Windows.Forms.Button();
            this.pnlCadastrarTema = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColorB = new System.Windows.Forms.TextBox();
            this.txtColorG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ptnPrevia = new System.Windows.Forms.PictureBox();
            this.pnlCadastrarTema.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(6, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 29);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // txtEnderecoImagem
            // 
            this.txtEnderecoImagem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoImagem.Location = new System.Drawing.Point(6, 73);
            this.txtEnderecoImagem.Name = "txtEnderecoImagem";
            this.txtEnderecoImagem.Size = new System.Drawing.Size(238, 29);
            this.txtEnderecoImagem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Endereço da Imagem";
            // 
            // txtColorR
            // 
            this.txtColorR.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorR.Location = new System.Drawing.Point(6, 121);
            this.txtColorR.Name = "txtColorR";
            this.txtColorR.Size = new System.Drawing.Size(76, 29);
            this.txtColorR.TabIndex = 3;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarImagem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarImagem.Location = new System.Drawing.Point(250, 73);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(32, 29);
            this.btnSelecionarImagem.TabIndex = 2;
            this.btnSelecionarImagem.Text = "...";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // btnSelecionarFundo
            // 
            this.btnSelecionarFundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarFundo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarFundo.Location = new System.Drawing.Point(250, 121);
            this.btnSelecionarFundo.Name = "btnSelecionarFundo";
            this.btnSelecionarFundo.Size = new System.Drawing.Size(32, 29);
            this.btnSelecionarFundo.TabIndex = 6;
            this.btnSelecionarFundo.Text = "...";
            this.btnSelecionarFundo.UseVisualStyleBackColor = true;
            this.btnSelecionarFundo.Click += new System.EventHandler(this.btnSelecionarFundo_Click);
            // 
            // pnlCadastrarTema
            // 
            this.pnlCadastrarTema.Controls.Add(this.label7);
            this.pnlCadastrarTema.Controls.Add(this.label5);
            this.pnlCadastrarTema.Controls.Add(this.txtColorB);
            this.pnlCadastrarTema.Controls.Add(this.txtColorG);
            this.pnlCadastrarTema.Controls.Add(this.label1);
            this.pnlCadastrarTema.Controls.Add(this.btnSelecionarFundo);
            this.pnlCadastrarTema.Controls.Add(this.txtNome);
            this.pnlCadastrarTema.Controls.Add(this.btnSelecionarImagem);
            this.pnlCadastrarTema.Controls.Add(this.label2);
            this.pnlCadastrarTema.Controls.Add(this.txtEnderecoImagem);
            this.pnlCadastrarTema.Controls.Add(this.txtColorR);
            this.pnlCadastrarTema.Controls.Add(this.label3);
            this.pnlCadastrarTema.Location = new System.Drawing.Point(3, 70);
            this.pnlCadastrarTema.Name = "pnlCadastrarTema";
            this.pnlCadastrarTema.Size = new System.Drawing.Size(286, 156);
            this.pnlCadastrarTema.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(165, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Color: B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(85, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Color: G";
            // 
            // txtColorB
            // 
            this.txtColorB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorB.Location = new System.Drawing.Point(168, 121);
            this.txtColorB.Name = "txtColorB";
            this.txtColorB.Size = new System.Drawing.Size(76, 29);
            this.txtColorB.TabIndex = 5;
            // 
            // txtColorG
            // 
            this.txtColorG.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorG.Location = new System.Drawing.Point(88, 121);
            this.txtColorG.Name = "txtColorG";
            this.txtColorG.Size = new System.Drawing.Size(74, 29);
            this.txtColorG.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Color: R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Tema";
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(12, 9);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(143, 33);
            this.lblCadastrar.TabIndex = 61;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(185, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(79, 232);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 33);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 31);
            this.panel2.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SELECIONE UMA IMAGEM COM QUALIDADE ALTA";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ptnPrevia
            // 
            this.ptnPrevia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ptnPrevia.BackgroundImage = global::View.Properties.Resources.SuaLogo;
            this.ptnPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptnPrevia.Location = new System.Drawing.Point(295, 12);
            this.ptnPrevia.Name = "ptnPrevia";
            this.ptnPrevia.Size = new System.Drawing.Size(253, 253);
            this.ptnPrevia.TabIndex = 65;
            this.ptnPrevia.TabStop = false;
            // 
            // FrmCadastrarTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 309);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptnPrevia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.pnlCadastrarTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarTema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarTema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastrarTema_FormClosing);
            this.pnlCadastrarTema.ResumeLayout(false);
            this.pnlCadastrarTema.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColorR;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.Button btnSelecionarFundo;
        private System.Windows.Forms.Panel pnlCadastrarTema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox ptnPrevia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColorB;
        private System.Windows.Forms.TextBox txtColorG;
        private System.Windows.Forms.Label label3;
    }
}