namespace View
{
    partial class FrmTicket
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.rbEmAberto = new System.Windows.Forms.RadioButton();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(691, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 44);
            this.groupBox2.TabIndex = 98;
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
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Checked = true;
            this.rbFinalizado.Location = new System.Drawing.Point(6, 21);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(72, 17);
            this.rbFinalizado.TabIndex = 0;
            this.rbFinalizado.TabStop = true;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmAberto);
            this.groupBox1.Controls.Add(this.rbFinalizado);
            this.groupBox1.Location = new System.Drawing.Point(512, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 44);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status Pagamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Filtro";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(944, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 91;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CODIGO",
            "VENDEDOR"});
            this.cbxFiltro.Location = new System.Drawing.Point(14, 24);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(159, 31);
            this.cbxFiltro.TabIndex = 89;
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
            // 
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(11, 522);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 95;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(176, 10);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 94;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(179, 27);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(327, 29);
            this.txtProcurar.TabIndex = 90;
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.BackgroundColor = System.Drawing.Color.White;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(14, 64);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowHeadersVisible = false;
            this.dgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicket.Size = new System.Drawing.Size(1030, 455);
            this.dgvTicket.TabIndex = 92;
            // 
            // FrmTicket
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
            this.Controls.Add(this.dgvTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTicket";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.RadioButton rbEmAberto;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.DataGridView dgvTicket;
    }
}