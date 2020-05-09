namespace View
{
    partial class FrmFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinanceiro));
            this.dgvFinanceiro = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcaoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFinanceiro
            // 
            this.dgvFinanceiro.AllowUserToAddRows = false;
            this.dgvFinanceiro.AllowUserToDeleteRows = false;
            this.dgvFinanceiro.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nomeCliente,
            this.dataVenda,
            this.valorVenda,
            this.opcaoPagamento,
            this.statusPagamento,
            this.statusVenda});
            this.dgvFinanceiro.Location = new System.Drawing.Point(137, 65);
            this.dgvFinanceiro.Name = "dgvFinanceiro";
            this.dgvFinanceiro.ReadOnly = true;
            this.dgvFinanceiro.RowHeadersVisible = false;
            this.dgvFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinanceiro.Size = new System.Drawing.Size(592, 401);
            this.dgvFinanceiro.TabIndex = 1;
            this.dgvFinanceiro.DoubleClick += new System.EventHandler(this.dgvFinanceiro_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nomeCliente
            // 
            this.nomeCliente.DataPropertyName = "NomeCliente";
            this.nomeCliente.HeaderText = "Nome Cliente";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            // 
            // dataVenda
            // 
            this.dataVenda.DataPropertyName = "dataVenda";
            this.dataVenda.HeaderText = "Data Venda";
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.ReadOnly = true;
            // 
            // valorVenda
            // 
            this.valorVenda.DataPropertyName = "valorVenda";
            this.valorVenda.HeaderText = "Valor Venda";
            this.valorVenda.Name = "valorVenda";
            this.valorVenda.ReadOnly = true;
            // 
            // opcaoPagamento
            // 
            this.opcaoPagamento.DataPropertyName = "opcaoPagamento";
            this.opcaoPagamento.HeaderText = "Opção Pagamento";
            this.opcaoPagamento.Name = "opcaoPagamento";
            this.opcaoPagamento.ReadOnly = true;
            // 
            // statusPagamento
            // 
            this.statusPagamento.DataPropertyName = "statusPagamento";
            this.statusPagamento.HeaderText = "Status Pagamento";
            this.statusPagamento.Name = "statusPagamento";
            this.statusPagamento.ReadOnly = true;
            // 
            // statusVenda
            // 
            this.statusVenda.DataPropertyName = "statusVenda";
            this.statusVenda.HeaderText = "Status Venda";
            this.statusVenda.Name = "statusVenda";
            this.statusVenda.ReadOnly = true;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(134, 12);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 53;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(137, 25);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(591, 34);
            this.txtProcurar.TabIndex = 50;
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged);
            // 
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(134, 469);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 54;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 1);
            this.panel2.TabIndex = 57;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(12, 416);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(119, 50);
            this.btnFechar.TabIndex = 56;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 1);
            this.panel1.TabIndex = 61;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Enabled = false;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(12, 234);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(119, 50);
            this.btnConsultar.TabIndex = 60;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 353);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(119, 50);
            this.btnCadastrar.TabIndex = 59;
            this.btnCadastrar.Text = "Excluir";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 297);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 50);
            this.btnSalvar.TabIndex = 58;
            this.btnSalvar.Text = "Editar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.calculators;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblExibidosTotal);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.dgvFinanceiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFinanceiro;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcaoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusVenda;
    }
}