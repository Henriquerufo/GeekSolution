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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinanceiro));
            this.dgvFinanceiro = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcaoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dinheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEmAberto = new System.Windows.Forms.RadioButton();
            this.rbRecebido = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFinanceiro
            // 
            this.dgvFinanceiro.AllowUserToAddRows = false;
            this.dgvFinanceiro.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFinanceiro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinanceiro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinanceiro.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nomeCliente,
            this.Vendedor,
            this.dataVenda,
            this.valorVenda,
            this.opcaoPagamento,
            this.Dinheiro,
            this.Cartao,
            this.Cheque,
            this.ChequeDias,
            this.statusPagamento,
            this.statusVenda});
            this.dgvFinanceiro.Location = new System.Drawing.Point(12, 63);
            this.dgvFinanceiro.Name = "dgvFinanceiro";
            this.dgvFinanceiro.ReadOnly = true;
            this.dgvFinanceiro.RowHeadersVisible = false;
            this.dgvFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinanceiro.Size = new System.Drawing.Size(1030, 455);
            this.dgvFinanceiro.TabIndex = 3;
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
            // Vendedor
            // 
            this.Vendedor.DataPropertyName = "Vendedor";
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
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
            // Dinheiro
            // 
            this.Dinheiro.DataPropertyName = "Dinheiro";
            this.Dinheiro.HeaderText = "Dinheiro";
            this.Dinheiro.Name = "Dinheiro";
            this.Dinheiro.ReadOnly = true;
            // 
            // Cartao
            // 
            this.Cartao.DataPropertyName = "Cartao";
            this.Cartao.HeaderText = "Cartão";
            this.Cartao.Name = "Cartao";
            this.Cartao.ReadOnly = true;
            // 
            // Cheque
            // 
            this.Cheque.DataPropertyName = "Cheque";
            this.Cheque.HeaderText = "Cheque";
            this.Cheque.Name = "Cheque";
            this.Cheque.ReadOnly = true;
            // 
            // ChequeDias
            // 
            this.ChequeDias.DataPropertyName = "ChequeDias";
            this.ChequeDias.HeaderText = "Cheque Pré Datado";
            this.ChequeDias.Name = "ChequeDias";
            this.ChequeDias.ReadOnly = true;
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
            this.lblPesquisar.Location = new System.Drawing.Point(174, 9);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 53;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(177, 26);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(327, 29);
            this.txtProcurar.TabIndex = 1;
            // 
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(9, 521);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 54;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(942, 524);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 33);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CODIGO",
            "NOME CLIENTE"});
            this.cbxFiltro.Location = new System.Drawing.Point(12, 23);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(159, 31);
            this.cbxFiltro.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(942, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Filtro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmAberto);
            this.groupBox1.Controls.Add(this.rbRecebido);
            this.groupBox1.Location = new System.Drawing.Point(510, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 44);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status Pagamento";
            // 
            // rbEmAberto
            // 
            this.rbEmAberto.AutoSize = true;
            this.rbEmAberto.Location = new System.Drawing.Point(93, 21);
            this.rbEmAberto.Name = "rbEmAberto";
            this.rbEmAberto.Size = new System.Drawing.Size(74, 17);
            this.rbEmAberto.TabIndex = 1;
            this.rbEmAberto.Text = "Em Aberto";
            this.rbEmAberto.UseVisualStyleBackColor = true;
            // 
            // rbRecebido
            // 
            this.rbRecebido.AutoSize = true;
            this.rbRecebido.Checked = true;
            this.rbRecebido.Location = new System.Drawing.Point(6, 21);
            this.rbRecebido.Name = "rbRecebido";
            this.rbRecebido.Size = new System.Drawing.Size(71, 17);
            this.rbRecebido.TabIndex = 0;
            this.rbRecebido.TabStop = true;
            this.rbRecebido.Text = "Recebido";
            this.rbRecebido.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpAte);
            this.groupBox2.Controls.Add(this.dtpDe);
            this.groupBox2.Location = new System.Drawing.Point(689, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 44);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Até:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "De:";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(156, 18);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(82, 20);
            this.dtpAte.TabIndex = 1;
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(36, 18);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(82, 20);
            this.dtpDe.TabIndex = 0;
            // 
            // FrmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblExibidosTotal);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.dgvFinanceiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Sistemas: Consultar Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFinanceiro;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEmAberto;
        private System.Windows.Forms.RadioButton rbRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcaoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusVenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
    }
}