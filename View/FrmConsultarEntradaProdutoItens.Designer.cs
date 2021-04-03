namespace View
{
    partial class FrmConsultarEntradaProdutoItens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataRecebido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dgvEntradaProdutoItens = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoquista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazoGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaProdutoItens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(773, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 33);
            this.panel1.TabIndex = 138;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(667, 511);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 33);
            this.btnImprimir.TabIndex = 108;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Data de Entrada";
            // 
            // txtDataRecebido
            // 
            this.txtDataRecebido.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRecebido.Location = new System.Drawing.Point(740, 26);
            this.txtDataRecebido.Name = "txtDataRecebido";
            this.txtDataRecebido.ReadOnly = true;
            this.txtDataRecebido.Size = new System.Drawing.Size(140, 29);
            this.txtDataRecebido.TabIndex = 118;
            this.txtDataRecebido.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Nome da Empresa";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(125, 26);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.ReadOnly = true;
            this.txtNomeEmpresa.Size = new System.Drawing.Size(609, 29);
            this.txtNomeEmpresa.TabIndex = 116;
            this.txtNomeEmpresa.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "Código Pedido";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(14, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(105, 29);
            this.txtCodigo.TabIndex = 114;
            this.txtCodigo.TabStop = false;
            // 
            // dgvEntradaProdutoItens
            // 
            this.dgvEntradaProdutoItens.AllowUserToAddRows = false;
            this.dgvEntradaProdutoItens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEntradaProdutoItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntradaProdutoItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntradaProdutoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradaProdutoItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.codigoPedido,
            this.NomeEmpresa,
            this.Estoquista,
            this.DataRecebido,
            this.codigoBarras,
            this.nomeProduto,
            this.categoria,
            this.fabricante,
            this.valorProduto,
            this.plataforma,
            this.prazoGarantia});
            this.dgvEntradaProdutoItens.Location = new System.Drawing.Point(14, 61);
            this.dgvEntradaProdutoItens.Name = "dgvEntradaProdutoItens";
            this.dgvEntradaProdutoItens.ReadOnly = true;
            this.dgvEntradaProdutoItens.RowHeadersVisible = false;
            this.dgvEntradaProdutoItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradaProdutoItens.Size = new System.Drawing.Size(866, 445);
            this.dgvEntradaProdutoItens.TabIndex = 107;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // codigoPedido
            // 
            this.codigoPedido.DataPropertyName = "CodigoEntradaProduto";
            this.codigoPedido.HeaderText = "Codigo Pedido";
            this.codigoPedido.Name = "codigoPedido";
            this.codigoPedido.ReadOnly = true;
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.DataPropertyName = "NomeEmpresa";
            this.NomeEmpresa.HeaderText = "Nome da Empresa";
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.ReadOnly = true;
            // 
            // Estoquista
            // 
            this.Estoquista.DataPropertyName = "Estoquista";
            this.Estoquista.HeaderText = "Estoquista";
            this.Estoquista.Name = "Estoquista";
            this.Estoquista.ReadOnly = true;
            // 
            // DataRecebido
            // 
            this.DataRecebido.DataPropertyName = "DataRecebido";
            this.DataRecebido.HeaderText = "Data de Recebimento";
            this.DataRecebido.Name = "DataRecebido";
            this.DataRecebido.ReadOnly = true;
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
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(11, 509);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 113;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(780, 512);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 33);
            this.btnFechar.TabIndex = 111;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarEntradaProdutoItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataRecebido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgvEntradaProdutoItens);
            this.Controls.Add(this.lblExibidosTotal);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultarEntradaProdutoItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarEntradaProdutoItens";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaProdutoItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataRecebido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dgvEntradaProdutoItens;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoquista;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazoGarantia;
    }
}