namespace View
{
    partial class FrmDevolucaoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolucaoProduto));
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvProdutoCancelados = new System.Windows.Forms.DataGridView();
            this.lblExibidosTotalCancelados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoCancelados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(174, 9);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 55;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Filtro";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "PEDIDO",
            "ITEM"});
            this.cbxFiltro.Location = new System.Drawing.Point(12, 25);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(159, 31);
            this.cbxFiltro.TabIndex = 0;
            this.cbxFiltro.TextChanged += new System.EventHandler(this.cbxFiltro_TextChanged);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(177, 25);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(506, 29);
            this.txtProcurar.TabIndex = 1;
            // 
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(9, 241);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 51;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(12, 65);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(777, 173);
            this.dgvProduto.TabIndex = 3;
            this.dgvProduto.DoubleClick += new System.EventHandler(this.dgvProduto_DoubleClick);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(689, 441);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 33);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(576, 441);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 33);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Cancelar";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvProdutoCancelados
            // 
            this.dgvProdutoCancelados.AllowUserToAddRows = false;
            this.dgvProdutoCancelados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProdutoCancelados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutoCancelados.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutoCancelados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoCancelados.Location = new System.Drawing.Point(12, 262);
            this.dgvProdutoCancelados.Name = "dgvProdutoCancelados";
            this.dgvProdutoCancelados.ReadOnly = true;
            this.dgvProdutoCancelados.RowHeadersVisible = false;
            this.dgvProdutoCancelados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutoCancelados.Size = new System.Drawing.Size(777, 173);
            this.dgvProdutoCancelados.TabIndex = 4;
            this.dgvProdutoCancelados.DoubleClick += new System.EventHandler(this.dgvProdutoCancelados_DoubleClick);
            // 
            // lblExibidosTotalCancelados
            // 
            this.lblExibidosTotalCancelados.AutoSize = true;
            this.lblExibidosTotalCancelados.Location = new System.Drawing.Point(9, 438);
            this.lblExibidosTotalCancelados.Name = "lblExibidosTotalCancelados";
            this.lblExibidosTotalCancelados.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotalCancelados.TabIndex = 60;
            this.lblExibidosTotalCancelados.Text = "Exibidos total: 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(682, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 33);
            this.panel1.TabIndex = 72;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(689, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmDevolucaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 486);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblExibidosTotalCancelados);
            this.Controls.Add(this.dgvProdutoCancelados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.lblExibidosTotal);
            this.Controls.Add(this.dgvProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDevolucaoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Sistemas: Devolução Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoCancelados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvProdutoCancelados;
        private System.Windows.Forms.Label lblExibidosTotalCancelados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
    }
}