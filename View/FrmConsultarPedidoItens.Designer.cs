namespace View
{
    partial class FrmConsultarPedidoItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarPedidoItens));
            this.dgvPedidoItens = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazoGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.dgvPedidoItensCancelados = new System.Windows.Forms.DataGridView();
            this.Codigo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPedido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProduto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plataforma2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Garantia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblExibidosTotalCancelados = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpcaoPagamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChequeDias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStatusPagamento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStatusVenda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnImprimirCancelados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItensCancelados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidoItens
            // 
            this.dgvPedidoItens.AllowUserToAddRows = false;
            this.dgvPedidoItens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedidoItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidoItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.codigoPedido,
            this.nomeCliente,
            this.codigoBarras,
            this.nomeProduto,
            this.categoria,
            this.fabricante,
            this.valorProduto,
            this.plataforma,
            this.prazoGarantia});
            this.dgvPedidoItens.Location = new System.Drawing.Point(12, 130);
            this.dgvPedidoItens.Name = "dgvPedidoItens";
            this.dgvPedidoItens.ReadOnly = true;
            this.dgvPedidoItens.RowHeadersVisible = false;
            this.dgvPedidoItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoItens.Size = new System.Drawing.Size(866, 200);
            this.dgvPedidoItens.TabIndex = 0;
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "Codigo";
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // codigoPedido
            // 
            this.codigoPedido.DataPropertyName = "CodigoPedido";
            this.codigoPedido.HeaderText = "Codigo Pedido";
            this.codigoPedido.Name = "codigoPedido";
            this.codigoPedido.ReadOnly = true;
            // 
            // nomeCliente
            // 
            this.nomeCliente.DataPropertyName = "NomeCliente";
            this.nomeCliente.HeaderText = "Nome Cliente";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            // 
            // codigoBarras
            // 
            this.codigoBarras.DataPropertyName = "CodigoBarras";
            this.codigoBarras.HeaderText = "Codigo de Barras";
            this.codigoBarras.Name = "codigoBarras";
            this.codigoBarras.ReadOnly = true;
            // 
            // nomeProduto
            // 
            this.nomeProduto.DataPropertyName = "NomeProduto";
            this.nomeProduto.HeaderText = "Nome do Produto";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "Categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // fabricante
            // 
            this.fabricante.DataPropertyName = "Fabricante";
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.ReadOnly = true;
            // 
            // valorProduto
            // 
            this.valorProduto.DataPropertyName = "ValorProduto";
            this.valorProduto.HeaderText = "Valor do Produto";
            this.valorProduto.Name = "valorProduto";
            this.valorProduto.ReadOnly = true;
            // 
            // plataforma
            // 
            this.plataforma.DataPropertyName = "Plataforma";
            this.plataforma.HeaderText = "Plataforma";
            this.plataforma.Name = "plataforma";
            this.plataforma.ReadOnly = true;
            // 
            // prazoGarantia
            // 
            this.prazoGarantia.DataPropertyName = "Garantia";
            this.prazoGarantia.HeaderText = "Garantia";
            this.prazoGarantia.Name = "prazoGarantia";
            this.prazoGarantia.ReadOnly = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(778, 582);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 33);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(9, 333);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 67;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // dgvPedidoItensCancelados
            // 
            this.dgvPedidoItensCancelados.AllowUserToAddRows = false;
            this.dgvPedidoItensCancelados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedidoItensCancelados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidoItensCancelados.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidoItensCancelados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoItensCancelados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo2,
            this.CodigoPedido2,
            this.NomeCliente2,
            this.CodigoBarras2,
            this.NomeProduto2,
            this.Categoria2,
            this.Fabricante2,
            this.ValorProduto2,
            this.Plataforma2,
            this.Garantia2});
            this.dgvPedidoItensCancelados.Location = new System.Drawing.Point(12, 375);
            this.dgvPedidoItensCancelados.Name = "dgvPedidoItensCancelados";
            this.dgvPedidoItensCancelados.ReadOnly = true;
            this.dgvPedidoItensCancelados.RowHeadersVisible = false;
            this.dgvPedidoItensCancelados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoItensCancelados.Size = new System.Drawing.Size(866, 201);
            this.dgvPedidoItensCancelados.TabIndex = 2;
            // 
            // Codigo2
            // 
            this.Codigo2.DataPropertyName = "Codigo";
            this.Codigo2.HeaderText = "Codigo";
            this.Codigo2.Name = "Codigo2";
            this.Codigo2.ReadOnly = true;
            // 
            // CodigoPedido2
            // 
            this.CodigoPedido2.DataPropertyName = "CodigoPedido";
            this.CodigoPedido2.HeaderText = "Codigo Pedido";
            this.CodigoPedido2.Name = "CodigoPedido2";
            this.CodigoPedido2.ReadOnly = true;
            // 
            // NomeCliente2
            // 
            this.NomeCliente2.DataPropertyName = "NomeCliente";
            this.NomeCliente2.HeaderText = "Nome Cliente";
            this.NomeCliente2.Name = "NomeCliente2";
            this.NomeCliente2.ReadOnly = true;
            // 
            // CodigoBarras2
            // 
            this.CodigoBarras2.DataPropertyName = "CodigoBarras";
            this.CodigoBarras2.HeaderText = "Codigo de Barras";
            this.CodigoBarras2.Name = "CodigoBarras2";
            this.CodigoBarras2.ReadOnly = true;
            // 
            // NomeProduto2
            // 
            this.NomeProduto2.DataPropertyName = "NomeProduto";
            this.NomeProduto2.HeaderText = "Nome do Produto";
            this.NomeProduto2.Name = "NomeProduto2";
            this.NomeProduto2.ReadOnly = true;
            // 
            // Categoria2
            // 
            this.Categoria2.DataPropertyName = "Categoria";
            this.Categoria2.HeaderText = "Categoria";
            this.Categoria2.Name = "Categoria2";
            this.Categoria2.ReadOnly = true;
            // 
            // Fabricante2
            // 
            this.Fabricante2.DataPropertyName = "Fabricante";
            this.Fabricante2.HeaderText = "Fabricante";
            this.Fabricante2.Name = "Fabricante2";
            this.Fabricante2.ReadOnly = true;
            // 
            // ValorProduto2
            // 
            this.ValorProduto2.DataPropertyName = "ValorProduto";
            this.ValorProduto2.HeaderText = "Valor do Produto";
            this.ValorProduto2.Name = "ValorProduto2";
            this.ValorProduto2.ReadOnly = true;
            // 
            // Plataforma2
            // 
            this.Plataforma2.DataPropertyName = "Plataforma";
            this.Plataforma2.HeaderText = "Plataforma";
            this.Plataforma2.Name = "Plataforma2";
            this.Plataforma2.ReadOnly = true;
            // 
            // Garantia2
            // 
            this.Garantia2.DataPropertyName = "Garantia";
            this.Garantia2.HeaderText = "Garantia";
            this.Garantia2.Name = "Garantia2";
            this.Garantia2.ReadOnly = true;
            // 
            // lblExibidosTotalCancelados
            // 
            this.lblExibidosTotalCancelados.AutoSize = true;
            this.lblExibidosTotalCancelados.Location = new System.Drawing.Point(9, 579);
            this.lblExibidosTotalCancelados.Name = "lblExibidosTotalCancelados";
            this.lblExibidosTotalCancelados.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotalCancelados.TabIndex = 67;
            this.lblExibidosTotalCancelados.Text = "Exibidos total: 0";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(12, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(105, 29);
            this.txtCodigo.TabIndex = 70;
            this.txtCodigo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Código Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nome do Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(123, 25);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(321, 29);
            this.txtNomeCliente.TabIndex = 72;
            this.txtNomeCliente.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Data da Venda";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenda.Location = new System.Drawing.Point(450, 25);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.ReadOnly = true;
            this.txtDataVenda.Size = new System.Drawing.Size(140, 29);
            this.txtDataVenda.TabIndex = 74;
            this.txtDataVenda.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Valor Total da Venda";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(596, 25);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(140, 29);
            this.txtValorTotal.TabIndex = 86;
            this.txtValorTotal.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Opção de Pagamento";
            // 
            // txtOpcaoPagamento
            // 
            this.txtOpcaoPagamento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcaoPagamento.Location = new System.Drawing.Point(12, 73);
            this.txtOpcaoPagamento.Name = "txtOpcaoPagamento";
            this.txtOpcaoPagamento.ReadOnly = true;
            this.txtOpcaoPagamento.Size = new System.Drawing.Size(140, 29);
            this.txtOpcaoPagamento.TabIndex = 88;
            this.txtOpcaoPagamento.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Dinheiro";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.Location = new System.Drawing.Point(158, 73);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.ReadOnly = true;
            this.txtDinheiro.Size = new System.Drawing.Size(140, 29);
            this.txtDinheiro.TabIndex = 90;
            this.txtDinheiro.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Cartão";
            // 
            // txtCartao
            // 
            this.txtCartao.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartao.Location = new System.Drawing.Point(304, 73);
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.ReadOnly = true;
            this.txtCartao.Size = new System.Drawing.Size(140, 29);
            this.txtCartao.TabIndex = 92;
            this.txtCartao.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Cheque";
            // 
            // txtCheque
            // 
            this.txtCheque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque.Location = new System.Drawing.Point(450, 73);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.ReadOnly = true;
            this.txtCheque.Size = new System.Drawing.Size(140, 29);
            this.txtCheque.TabIndex = 94;
            this.txtCheque.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(593, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "Cheque Pré Datado";
            // 
            // txtChequeDias
            // 
            this.txtChequeDias.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeDias.Location = new System.Drawing.Point(596, 73);
            this.txtChequeDias.Name = "txtChequeDias";
            this.txtChequeDias.ReadOnly = true;
            this.txtChequeDias.Size = new System.Drawing.Size(140, 29);
            this.txtChequeDias.TabIndex = 96;
            this.txtChequeDias.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(739, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "Status de Pagamento";
            // 
            // txtStatusPagamento
            // 
            this.txtStatusPagamento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusPagamento.Location = new System.Drawing.Point(742, 25);
            this.txtStatusPagamento.Name = "txtStatusPagamento";
            this.txtStatusPagamento.ReadOnly = true;
            this.txtStatusPagamento.Size = new System.Drawing.Size(140, 29);
            this.txtStatusPagamento.TabIndex = 98;
            this.txtStatusPagamento.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(739, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 101;
            this.label11.Text = "Status da Venda";
            // 
            // txtStatusVenda
            // 
            this.txtStatusVenda.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusVenda.Location = new System.Drawing.Point(742, 73);
            this.txtStatusVenda.Name = "txtStatusVenda";
            this.txtStatusVenda.ReadOnly = true;
            this.txtStatusVenda.Size = new System.Drawing.Size(140, 29);
            this.txtStatusVenda.TabIndex = 100;
            this.txtStatusVenda.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "Itens Cancelados";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 103;
            this.label13.Text = "Itens Comprados";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(665, 336);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 33);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnImprimirCancelados
            // 
            this.btnImprimirCancelados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirCancelados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCancelados.Location = new System.Drawing.Point(665, 582);
            this.btnImprimirCancelados.Name = "btnImprimirCancelados";
            this.btnImprimirCancelados.Size = new System.Drawing.Size(100, 33);
            this.btnImprimirCancelados.TabIndex = 3;
            this.btnImprimirCancelados.Text = "Imprimir";
            this.btnImprimirCancelados.UseVisualStyleBackColor = true;
            this.btnImprimirCancelados.Click += new System.EventHandler(this.btnImprimirCancelados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(771, 582);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 33);
            this.panel1.TabIndex = 106;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FrmConsultarPedidoItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImprimirCancelados);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStatusVenda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStatusPagamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtChequeDias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCheque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCartao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOpcaoPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgvPedidoItensCancelados);
            this.Controls.Add(this.lblExibidosTotalCancelados);
            this.Controls.Add(this.lblExibidosTotal);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvPedidoItens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultarPedidoItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Sistemas: Consultar Pedido Por Itens";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItensCancelados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidoItens;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.DataGridView dgvPedidoItensCancelados;
        private System.Windows.Forms.Label lblExibidosTotalCancelados;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpcaoPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChequeDias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStatusPagamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStatusVenda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnImprimirCancelados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazoGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPedido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProduto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plataforma2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Garantia2;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}