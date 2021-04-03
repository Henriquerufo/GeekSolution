namespace View
{
    partial class FrmCaixaOpcaoPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOpcaoPagamento = new System.Windows.Forms.DataGridView();
            this.opcaoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcaoPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOpcaoPagamento
            // 
            this.dgvOpcaoPagamento.AllowUserToAddRows = false;
            this.dgvOpcaoPagamento.AllowUserToDeleteRows = false;
            this.dgvOpcaoPagamento.AllowUserToResizeColumns = false;
            this.dgvOpcaoPagamento.AllowUserToResizeRows = false;
            this.dgvOpcaoPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpcaoPagamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvOpcaoPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOpcaoPagamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOpcaoPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOpcaoPagamento.ColumnHeadersVisible = false;
            this.dgvOpcaoPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opcaoPagamento});
            this.dgvOpcaoPagamento.Location = new System.Drawing.Point(0, 0);
            this.dgvOpcaoPagamento.MultiSelect = false;
            this.dgvOpcaoPagamento.Name = "dgvOpcaoPagamento";
            this.dgvOpcaoPagamento.ReadOnly = true;
            this.dgvOpcaoPagamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOpcaoPagamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOpcaoPagamento.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOpcaoPagamento.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOpcaoPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpcaoPagamento.ShowCellToolTips = false;
            this.dgvOpcaoPagamento.Size = new System.Drawing.Size(798, 367);
            this.dgvOpcaoPagamento.TabIndex = 0;
            this.dgvOpcaoPagamento.DoubleClick += new System.EventHandler(this.dgvOpcaoPagamento_DoubleClick);
            this.dgvOpcaoPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOpcaoPagamento_KeyDown);
            // 
            // opcaoPagamento
            // 
            this.opcaoPagamento.HeaderText = "SELECIONE A OPÇÃO DE PAGAMENTO";
            this.opcaoPagamento.Name = "opcaoPagamento";
            this.opcaoPagamento.ReadOnly = true;
            // 
            // FrmCaixaOpcaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 366);
            this.Controls.Add(this.dgvOpcaoPagamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaixaOpcaoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCaixaOpcaoPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcaoPagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOpcaoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcaoPagamento;
    }
}