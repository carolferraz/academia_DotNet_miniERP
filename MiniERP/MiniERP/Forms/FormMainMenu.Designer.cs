namespace MiniERP
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnEmitirPedido = new Button();
            btnClientes = new Button();
            btnFornecedores = new Button();
            panelLogo = new Panel();
            btnProdutos = new Button();
            labelNome = new Label();
            panelTitleBar = new Panel();
            panelDesktopPanel = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(91, 38, 63);
            panelMenu.Controls.Add(btnEmitirPedido);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnFornecedores);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(btnProdutos);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 581);
            panelMenu.TabIndex = 0;
            // 
            // btnEmitirPedido
            // 
            btnEmitirPedido.FlatAppearance.BorderSize = 0;
            btnEmitirPedido.FlatStyle = FlatStyle.Flat;
            btnEmitirPedido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmitirPedido.ForeColor = SystemColors.ButtonFace;
            btnEmitirPedido.Image = (Image)resources.GetObject("btnEmitirPedido.Image");
            btnEmitirPedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmitirPedido.Location = new Point(0, 391);
            btnEmitirPedido.Name = "btnEmitirPedido";
            btnEmitirPedido.Padding = new Padding(40, 0, 0, 0);
            btnEmitirPedido.Size = new Size(217, 91);
            btnEmitirPedido.TabIndex = 4;
            btnEmitirPedido.Text = "  Emitir Pedido";
            btnEmitirPedido.TextAlign = ContentAlignment.MiddleLeft;
            btnEmitirPedido.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmitirPedido.UseVisualStyleBackColor = true;
            btnEmitirPedido.Click += btnEmitirPedido_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = SystemColors.ButtonFace;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 294);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(40, 0, 0, 0);
            btnClientes.Size = new Size(217, 91);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "  Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnFornecedores
            // 
            btnFornecedores.FlatAppearance.BorderSize = 0;
            btnFornecedores.FlatStyle = FlatStyle.Flat;
            btnFornecedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFornecedores.ForeColor = SystemColors.ButtonFace;
            btnFornecedores.Image = (Image)resources.GetObject("btnFornecedores.Image");
            btnFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnFornecedores.Location = new Point(0, 197);
            btnFornecedores.Name = "btnFornecedores";
            btnFornecedores.Padding = new Padding(40, 0, 0, 0);
            btnFornecedores.Size = new Size(217, 91);
            btnFornecedores.TabIndex = 2;
            btnFornecedores.Text = "  Fornecedores";
            btnFornecedores.TextAlign = ContentAlignment.MiddleLeft;
            btnFornecedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFornecedores.UseVisualStyleBackColor = true;
            btnFornecedores.Click += btnFornecedores_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(61, 0, 9);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 94);
            panelLogo.TabIndex = 1;
            // 
            // btnProdutos
            // 
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnProdutos.ForeColor = SystemColors.ButtonFace;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(1, 100);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Padding = new Padding(40, 0, 0, 0);
            btnProdutos.Size = new Size(217, 91);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "  Produtos";
            btnProdutos.TextAlign = ContentAlignment.MiddleLeft;
            btnProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Verdana", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = Color.White;
            labelNome.Location = new Point(463, 33);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(240, 29);
            labelNome.TabIndex = 2;
            labelNome.Text = "Gestão Papelaria";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(109, 19, 33);
            panelTitleBar.Controls.Add(labelNome);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1136, 94);
            panelTitleBar.TabIndex = 1;
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(220, 94);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1136, 487);
            panelDesktopPanel.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 581);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMainMenu";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnProdutos;
        private Button btnEmitirPedido;
        private Button btnClientes;
        private Button btnFornecedores;
        private Panel panelTitleBar;
        private Label labelNome;
        private Panel panelDesktopPanel;
    }
}