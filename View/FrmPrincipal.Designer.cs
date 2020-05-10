namespace View
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.conexãoSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.conexãoSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCaixaToolStripMenuItem,
            this.consultarProdutoToolStripMenuItem,
            this.devoluçãoProdutoToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // abrirCaixaToolStripMenuItem
            // 
            this.abrirCaixaToolStripMenuItem.Name = "abrirCaixaToolStripMenuItem";
            this.abrirCaixaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirCaixaToolStripMenuItem.Text = "Abrir Caixa";
            this.abrirCaixaToolStripMenuItem.Click += new System.EventHandler(this.abrirCaixaToolStripMenuItem_Click);
            // 
            // consultarProdutoToolStripMenuItem
            // 
            this.consultarProdutoToolStripMenuItem.Name = "consultarProdutoToolStripMenuItem";
            this.consultarProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarProdutoToolStripMenuItem.Text = "Consultar Produto";
            this.consultarProdutoToolStripMenuItem.Click += new System.EventHandler(this.consultarProdutoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem,
            this.consultarListaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarNovoToolStripMenuItem
            // 
            this.cadastrarNovoToolStripMenuItem.Name = "cadastrarNovoToolStripMenuItem";
            this.cadastrarNovoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cadastrarNovoToolStripMenuItem.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem_Click);
            // 
            // consultarListaToolStripMenuItem
            // 
            this.consultarListaToolStripMenuItem.Name = "consultarListaToolStripMenuItem";
            this.consultarListaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.consultarListaToolStripMenuItem.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem.Click += new System.EventHandler(this.consultarListaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem1,
            this.consultarListaToolStripMenuItem1});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarNovoToolStripMenuItem1
            // 
            this.cadastrarNovoToolStripMenuItem1.Name = "cadastrarNovoToolStripMenuItem1";
            this.cadastrarNovoToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.cadastrarNovoToolStripMenuItem1.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem1_Click);
            // 
            // consultarListaToolStripMenuItem1
            // 
            this.consultarListaToolStripMenuItem1.Name = "consultarListaToolStripMenuItem1";
            this.consultarListaToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.consultarListaToolStripMenuItem1.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem1.Click += new System.EventHandler(this.consultarListaToolStripMenuItem1_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPorPedidoToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // consultarPorPedidoToolStripMenuItem
            // 
            this.consultarPorPedidoToolStripMenuItem.Name = "consultarPorPedidoToolStripMenuItem";
            this.consultarPorPedidoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultarPorPedidoToolStripMenuItem.Text = "Consultar Lista";
            this.consultarPorPedidoToolStripMenuItem.Click += new System.EventHandler(this.consultarPorPedidoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem2,
            this.consultarListaToolStripMenuItem2});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // cadastrarNovoToolStripMenuItem2
            // 
            this.cadastrarNovoToolStripMenuItem2.Name = "cadastrarNovoToolStripMenuItem2";
            this.cadastrarNovoToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.cadastrarNovoToolStripMenuItem2.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem2_Click);
            // 
            // consultarListaToolStripMenuItem2
            // 
            this.consultarListaToolStripMenuItem2.Name = "consultarListaToolStripMenuItem2";
            this.consultarListaToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.consultarListaToolStripMenuItem2.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem2.Click += new System.EventHandler(this.consultarListaToolStripMenuItem2_Click);
            // 
            // conexãoSQLToolStripMenuItem
            // 
            this.conexãoSQLToolStripMenuItem.Name = "conexãoSQLToolStripMenuItem";
            this.conexãoSQLToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.conexãoSQLToolStripMenuItem.Text = "Conexão SQL";
            this.conexãoSQLToolStripMenuItem.Click += new System.EventHandler(this.conexãoSQLToolStripMenuItem_Click);
            // 
            // devoluçãoProdutoToolStripMenuItem
            // 
            this.devoluçãoProdutoToolStripMenuItem.Name = "devoluçãoProdutoToolStripMenuItem";
            this.devoluçãoProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devoluçãoProdutoToolStripMenuItem.Text = "Devolução Produto";
            this.devoluçãoProdutoToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoProdutoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources.pngwing_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geek Solution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conexãoSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPorPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoProdutoToolStripMenuItem;
    }
}