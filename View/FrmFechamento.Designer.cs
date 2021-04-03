namespace View
{
    partial class FrmFechamento
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.dgvFechamento = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotalVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotalRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidosFinalizados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItensRecebidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dinheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conveniado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechamento)).BeginInit();
            this.SuspendLayout();
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
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(36, 18);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(82, 20);
            this.dtpDe.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpAte);
            this.groupBox2.Controls.Add(this.dtpDe);
            this.groupBox2.Location = new System.Drawing.Point(689, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 47);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(156, 18);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(82, 20);
            this.dtpAte.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(944, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 92;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(937, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 33);
            this.panel1.TabIndex = 98;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(944, 525);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 33);
            this.btnFechar.TabIndex = 93;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(174, 10);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 97;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Filtro";
            // 
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(10, 522);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 95;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CODIGO",
            "VENDEDOR"});
            this.cbxFiltro.Location = new System.Drawing.Point(13, 26);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(158, 31);
            this.cbxFiltro.TabIndex = 90;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(177, 26);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(506, 29);
            this.txtProcurar.TabIndex = 91;
            // 
            // dgvFechamento
            // 
            this.dgvFechamento.AllowUserToAddRows = false;
            this.dgvFechamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFechamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFechamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvFechamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Vendedor,
            this.Data,
            this.ValorTotalVendido,
            this.ValorTotalRecebido,
            this.PedidosFinalizados,
            this.ItensRecebidos,
            this.Dinheiro,
            this.Cartao,
            this.Conveniado,
            this.Ticket,
            this.Cheque,
            this.ValorSaida,
            this.ValorCaixa});
            this.dgvFechamento.Location = new System.Drawing.Point(13, 66);
            this.dgvFechamento.Name = "dgvFechamento";
            this.dgvFechamento.ReadOnly = true;
            this.dgvFechamento.RowHeadersVisible = false;
            this.dgvFechamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFechamento.Size = new System.Drawing.Size(1031, 453);
            this.dgvFechamento.TabIndex = 94;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 79;
            // 
            // Vendedor
            // 
            this.Vendedor.DataPropertyName = "Vendedor";
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            this.Vendedor.Width = 79;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 79;
            // 
            // ValorTotalVendido
            // 
            this.ValorTotalVendido.DataPropertyName = "ValorTotalVendido";
            this.ValorTotalVendido.HeaderText = "Valor Total Vendido";
            this.ValorTotalVendido.Name = "ValorTotalVendido";
            this.ValorTotalVendido.ReadOnly = true;
            this.ValorTotalVendido.Width = 79;
            // 
            // ValorTotalRecebido
            // 
            this.ValorTotalRecebido.DataPropertyName = "ValorTotalRecebido";
            this.ValorTotalRecebido.HeaderText = "Valor Total Recebido";
            this.ValorTotalRecebido.Name = "ValorTotalRecebido";
            this.ValorTotalRecebido.ReadOnly = true;
            this.ValorTotalRecebido.Width = 79;
            // 
            // PedidosFinalizados
            // 
            this.PedidosFinalizados.DataPropertyName = "PedidosFinalizados";
            this.PedidosFinalizados.HeaderText = "Pedidos Finalizados";
            this.PedidosFinalizados.Name = "PedidosFinalizados";
            this.PedidosFinalizados.ReadOnly = true;
            this.PedidosFinalizados.Width = 79;
            // 
            // ItensRecebidos
            // 
            this.ItensRecebidos.DataPropertyName = "ItensRecebidos";
            this.ItensRecebidos.HeaderText = "Itens Recebidos";
            this.ItensRecebidos.Name = "ItensRecebidos";
            this.ItensRecebidos.ReadOnly = true;
            this.ItensRecebidos.Width = 80;
            // 
            // Dinheiro
            // 
            this.Dinheiro.DataPropertyName = "Dinheiro";
            this.Dinheiro.HeaderText = "Dinheiro";
            this.Dinheiro.Name = "Dinheiro";
            this.Dinheiro.ReadOnly = true;
            this.Dinheiro.Width = 79;
            // 
            // Cartao
            // 
            this.Cartao.DataPropertyName = "Cartao";
            this.Cartao.HeaderText = "Cartão";
            this.Cartao.Name = "Cartao";
            this.Cartao.ReadOnly = true;
            this.Cartao.Width = 79;
            // 
            // Conveniado
            // 
            this.Conveniado.DataPropertyName = "Conveniado";
            this.Conveniado.HeaderText = "Conveniado";
            this.Conveniado.Name = "Conveniado";
            this.Conveniado.ReadOnly = true;
            this.Conveniado.Width = 79;
            // 
            // Ticket
            // 
            this.Ticket.DataPropertyName = "Ticket";
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            // 
            // Cheque
            // 
            this.Cheque.DataPropertyName = "Cheque";
            this.Cheque.HeaderText = "Cheque";
            this.Cheque.Name = "Cheque";
            this.Cheque.ReadOnly = true;
            this.Cheque.Width = 79;
            // 
            // ValorSaida
            // 
            this.ValorSaida.DataPropertyName = "ValorSaida";
            this.ValorSaida.HeaderText = "Valor Saída";
            this.ValorSaida.Name = "ValorSaida";
            this.ValorSaida.ReadOnly = true;
            this.ValorSaida.Width = 79;
            // 
            // ValorCaixa
            // 
            this.ValorCaixa.DataPropertyName = "ValorCaixa";
            this.ValorCaixa.HeaderText = "Valor Caixa";
            this.ValorCaixa.Name = "ValorCaixa";
            this.ValorCaixa.ReadOnly = true;
            this.ValorCaixa.Width = 79;
            // 
            // FrmFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExibidosTotal);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.dgvFechamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFechamento";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.DataGridView dgvFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotalVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotalRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidosFinalizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItensRecebidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conveniado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCaixa;
    }
}