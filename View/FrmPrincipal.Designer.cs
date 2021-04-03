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
            this.devoluçãoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaDeValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechamentoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexãoSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.conexãoSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCaixaToolStripMenuItem,
            this.consultarProdutoToolStripMenuItem,
            this.devoluçãoProdutoToolStripMenuItem,
            this.gerarTicketToolStripMenuItem,
            this.saidaDeCaixaToolStripMenuItem,
            this.fechamentoToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // abrirCaixaToolStripMenuItem
            // 
            this.abrirCaixaToolStripMenuItem.Image = global::View.Properties.Resources.caixa_eletronico;
            this.abrirCaixaToolStripMenuItem.Name = "abrirCaixaToolStripMenuItem";
            this.abrirCaixaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.abrirCaixaToolStripMenuItem.Text = "Abrir Caixa";
            this.abrirCaixaToolStripMenuItem.Click += new System.EventHandler(this.abrirCaixaToolStripMenuItem_Click);
            // 
            // consultarProdutoToolStripMenuItem
            // 
            this.consultarProdutoToolStripMenuItem.Image = global::View.Properties.Resources.procurando;
            this.consultarProdutoToolStripMenuItem.Name = "consultarProdutoToolStripMenuItem";
            this.consultarProdutoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.consultarProdutoToolStripMenuItem.Text = "Consultar Produto";
            this.consultarProdutoToolStripMenuItem.Click += new System.EventHandler(this.consultarProdutoToolStripMenuItem_Click);
            // 
            // devoluçãoProdutoToolStripMenuItem
            // 
            this.devoluçãoProdutoToolStripMenuItem.Image = global::View.Properties.Resources.devolucao_de_produto;
            this.devoluçãoProdutoToolStripMenuItem.Name = "devoluçãoProdutoToolStripMenuItem";
            this.devoluçãoProdutoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.devoluçãoProdutoToolStripMenuItem.Text = "Devolução Produto";
            this.devoluçãoProdutoToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoProdutoToolStripMenuItem_Click);
            // 
            // gerarTicketToolStripMenuItem
            // 
            this.gerarTicketToolStripMenuItem.Image = global::View.Properties.Resources.ticket_machine__1_;
            this.gerarTicketToolStripMenuItem.Name = "gerarTicketToolStripMenuItem";
            this.gerarTicketToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.gerarTicketToolStripMenuItem.Text = "Gerar Ticket";
            this.gerarTicketToolStripMenuItem.Click += new System.EventHandler(this.gerarTicketToolStripMenuItem_Click);
            // 
            // saidaDeCaixaToolStripMenuItem
            // 
            this.saidaDeCaixaToolStripMenuItem.Image = global::View.Properties.Resources.money;
            this.saidaDeCaixaToolStripMenuItem.Name = "saidaDeCaixaToolStripMenuItem";
            this.saidaDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saidaDeCaixaToolStripMenuItem.Text = "Saida de Caixa";
            this.saidaDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.saidaDeCaixaToolStripMenuItem_Click);
            // 
            // fechamentoToolStripMenuItem
            // 
            this.fechamentoToolStripMenuItem.Image = global::View.Properties.Resources.caixa_registradora;
            this.fechamentoToolStripMenuItem.Name = "fechamentoToolStripMenuItem";
            this.fechamentoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.fechamentoToolStripMenuItem.Text = "Fechamento";
            this.fechamentoToolStripMenuItem.Click += new System.EventHandler(this.fechamentoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.empresasToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.clientesToolStripMenuItem.Text = "Clientes/Empresas";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem1,
            this.gerenciarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem1.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_33_59;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // cadastrarNovoToolStripMenuItem1
            // 
            this.cadastrarNovoToolStripMenuItem1.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_19_42;
            this.cadastrarNovoToolStripMenuItem1.Name = "cadastrarNovoToolStripMenuItem1";
            this.cadastrarNovoToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.cadastrarNovoToolStripMenuItem1.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem1_Click_1);
            // 
            // gerenciarClientesToolStripMenuItem
            // 
            this.gerenciarClientesToolStripMenuItem.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_17_48;
            this.gerenciarClientesToolStripMenuItem.Name = "gerenciarClientesToolStripMenuItem";
            this.gerenciarClientesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.gerenciarClientesToolStripMenuItem.Text = "Gerenciar Clientes";
            this.gerenciarClientesToolStripMenuItem.Click += new System.EventHandler(this.gerenciarClientesToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem,
            this.gerenciarEmpresasToolStripMenuItem});
            this.empresasToolStripMenuItem.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_35_39;
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // cadastrarNovoToolStripMenuItem
            // 
            this.cadastrarNovoToolStripMenuItem.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_19_42;
            this.cadastrarNovoToolStripMenuItem.Name = "cadastrarNovoToolStripMenuItem";
            this.cadastrarNovoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cadastrarNovoToolStripMenuItem.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem_Click);
            // 
            // gerenciarEmpresasToolStripMenuItem
            // 
            this.gerenciarEmpresasToolStripMenuItem.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_17_48;
            this.gerenciarEmpresasToolStripMenuItem.Name = "gerenciarEmpresasToolStripMenuItem";
            this.gerenciarEmpresasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gerenciarEmpresasToolStripMenuItem.Text = "Gerenciar Empresas";
            this.gerenciarEmpresasToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEmpresasToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarEstoqueToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // adicionarEstoqueToolStripMenuItem
            // 
            this.adicionarEstoqueToolStripMenuItem.Image = global::View.Properties.Resources._new;
            this.adicionarEstoqueToolStripMenuItem.Name = "adicionarEstoqueToolStripMenuItem";
            this.adicionarEstoqueToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.adicionarEstoqueToolStripMenuItem.Text = "Entrada de Produtos";
            this.adicionarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.adicionarEstoqueToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.produtosToolStripMenuItem2,
            this.saidaDeValoresToolStripMenuItem,
            this.fechamentoDeCaixaToolStripMenuItem,
            this.ticketToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saidaToolStripMenuItem});
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.produtosToolStripMenuItem1.Text = "Financeiro";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Image = global::View.Properties.Resources.log_in;
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.entradaToolStripMenuItem_Click);
            // 
            // saidaToolStripMenuItem
            // 
            this.saidaToolStripMenuItem.Image = global::View.Properties.Resources.log_out;
            this.saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            this.saidaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saidaToolStripMenuItem.Text = "Saida";
            this.saidaToolStripMenuItem.Click += new System.EventHandler(this.saidaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem2
            // 
            this.produtosToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem3,
            this.gerenciarProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            this.produtosToolStripMenuItem2.Size = new System.Drawing.Size(188, 22);
            this.produtosToolStripMenuItem2.Text = "Produtos";
            // 
            // cadastrarNovoToolStripMenuItem3
            // 
            this.cadastrarNovoToolStripMenuItem3.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_19_42;
            this.cadastrarNovoToolStripMenuItem3.Name = "cadastrarNovoToolStripMenuItem3";
            this.cadastrarNovoToolStripMenuItem3.Size = new System.Drawing.Size(175, 22);
            this.cadastrarNovoToolStripMenuItem3.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem3.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem3_Click);
            // 
            // gerenciarProdutosToolStripMenuItem
            // 
            this.gerenciarProdutosToolStripMenuItem.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_23_29;
            this.gerenciarProdutosToolStripMenuItem.Name = "gerenciarProdutosToolStripMenuItem";
            this.gerenciarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.gerenciarProdutosToolStripMenuItem.Text = "Gerenciar Produtos";
            this.gerenciarProdutosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarProdutosToolStripMenuItem_Click);
            // 
            // saidaDeValoresToolStripMenuItem
            // 
            this.saidaDeValoresToolStripMenuItem.Name = "saidaDeValoresToolStripMenuItem";
            this.saidaDeValoresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saidaDeValoresToolStripMenuItem.Text = "Saida de Valores";
            this.saidaDeValoresToolStripMenuItem.Click += new System.EventHandler(this.saidaDeValoresToolStripMenuItem_Click);
            // 
            // fechamentoDeCaixaToolStripMenuItem
            // 
            this.fechamentoDeCaixaToolStripMenuItem.Name = "fechamentoDeCaixaToolStripMenuItem";
            this.fechamentoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.fechamentoDeCaixaToolStripMenuItem.Text = "Fechamento de Caixa";
            this.fechamentoDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.fechamentoDeCaixaToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ticketToolStripMenuItem.Text = "Ticket";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem2,
            this.consultarListaToolStripMenuItem2,
            this.gerenciarTemaToolStripMenuItem});
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
            // gerenciarTemaToolStripMenuItem
            // 
            this.gerenciarTemaToolStripMenuItem.Name = "gerenciarTemaToolStripMenuItem";
            this.gerenciarTemaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gerenciarTemaToolStripMenuItem.Text = "Gerenciar Tema";
            this.gerenciarTemaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarTemaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // conexãoSQLToolStripMenuItem
            // 
            this.conexãoSQLToolStripMenuItem.Name = "conexãoSQLToolStripMenuItem";
            this.conexãoSQLToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.conexãoSQLToolStripMenuItem.Text = "Conexão SQL";
            this.conexãoSQLToolStripMenuItem.Click += new System.EventHandler(this.conexãoSQLToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::View.Properties.Resources.SuaLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1031, 514);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Sistemas";
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
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexãoSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaDeValoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechamentoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gerenciarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEmpresasToolStripMenuItem;
    }
}