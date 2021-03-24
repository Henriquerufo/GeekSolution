namespace View
{
    partial class FrmGerenciadorTema
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTemaAtivo = new System.Windows.Forms.DataGridView();
            this.DgvTema = new System.Windows.Forms.DataGridView();
            this.btnDesativarTema = new System.Windows.Forms.Button();
            this.btnAtivarTema = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemaAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTema)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTemaAtivo
            // 
            this.dgvTemaAtivo.AllowUserToAddRows = false;
            this.dgvTemaAtivo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTemaAtivo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemaAtivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTemaAtivo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTemaAtivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemaAtivo.Location = new System.Drawing.Point(12, 75);
            this.dgvTemaAtivo.MultiSelect = false;
            this.dgvTemaAtivo.Name = "dgvTemaAtivo";
            this.dgvTemaAtivo.ReadOnly = true;
            this.dgvTemaAtivo.RowHeadersVisible = false;
            this.dgvTemaAtivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemaAtivo.Size = new System.Drawing.Size(331, 329);
            this.dgvTemaAtivo.TabIndex = 3;
            this.dgvTemaAtivo.DoubleClick += new System.EventHandler(this.dgvTemaAtivo_DoubleClick);
            // 
            // DgvTema
            // 
            this.DgvTema.AllowUserToAddRows = false;
            this.DgvTema.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvTema.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTema.BackgroundColor = System.Drawing.Color.White;
            this.DgvTema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTema.Location = new System.Drawing.Point(458, 75);
            this.DgvTema.MultiSelect = false;
            this.DgvTema.Name = "DgvTema";
            this.DgvTema.ReadOnly = true;
            this.DgvTema.RowHeadersVisible = false;
            this.DgvTema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTema.Size = new System.Drawing.Size(331, 355);
            this.DgvTema.TabIndex = 6;
            this.DgvTema.DoubleClick += new System.EventHandler(this.DgvTema_DoubleClick);
            // 
            // btnDesativarTema
            // 
            this.btnDesativarTema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesativarTema.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativarTema.Location = new System.Drawing.Point(349, 232);
            this.btnDesativarTema.Name = "btnDesativarTema";
            this.btnDesativarTema.Size = new System.Drawing.Size(103, 33);
            this.btnDesativarTema.TabIndex = 4;
            this.btnDesativarTema.Text = "====>";
            this.btnDesativarTema.UseVisualStyleBackColor = true;
            this.btnDesativarTema.Click += new System.EventHandler(this.btnDesativarTema_Click);
            // 
            // btnAtivarTema
            // 
            this.btnAtivarTema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivarTema.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivarTema.Location = new System.Drawing.Point(349, 271);
            this.btnAtivarTema.Name = "btnAtivarTema";
            this.btnAtivarTema.Size = new System.Drawing.Size(103, 33);
            this.btnAtivarTema.TabIndex = 5;
            this.btnAtivarTema.Text = "<====";
            this.btnAtivarTema.UseVisualStyleBackColor = true;
            this.btnAtivarTema.Click += new System.EventHandler(this.btnAtivarTema_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(367, 441);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 33);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(579, 441);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 33);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(473, 441);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 33);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(692, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(174, 9);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 76;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Filtro";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CODIGO",
            "NOME"});
            this.cbxFiltro.Location = new System.Drawing.Point(12, 25);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(159, 31);
            this.cbxFiltro.TabIndex = 0;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(177, 25);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(509, 29);
            this.txtPesquisar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(685, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 33);
            this.panel1.TabIndex = 80;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(692, 441);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 33);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 64);
            this.panel2.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "O TEMA NOVO SÓ SERÁ ATIVADO APÓS REINICIAR O SISTEMA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "!!!! ATENÇÃO !!!!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "PARA CONSULTAR UM TEMA, CLIQUE DUAS VEZES NO MESMO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SOMENTE UM TEMA ATIVO É ACEITO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tema ativado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Lista de temas";
            // 
            // FrmGerenciadorTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAtivarTema);
            this.Controls.Add(this.btnDesativarTema);
            this.Controls.Add(this.DgvTema);
            this.Controls.Add(this.dgvTemaAtivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGerenciadorTema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGerenciadorTema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemaAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTema)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemaAtivo;
        private System.Windows.Forms.DataGridView DgvTema;
        private System.Windows.Forms.Button btnDesativarTema;
        private System.Windows.Forms.Button btnAtivarTema;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}