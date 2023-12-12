namespace MiniERP.Forms
{
    partial class FormPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedido));
            btnAdicionarProduto = new Button();
            labelSelecionarProduto = new Label();
            textBoxQuantidade = new TextBox();
            labelPedido = new Label();
            label1 = new Label();
            textBoxSelecionarProduto = new TextBox();
            dataGridViewProdutos = new DataGridView();
            dataGridViewPedido = new DataGridView();
            labelItensPedido = new Label();
            buttonReload = new Button();
            buttonEmitirNF = new Button();
            buttonLimparPedido = new Button();
            buttonApagarItem = new Button();
            labelSelecionarCliente = new Label();
            comboBoxClientes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedido).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.BackColor = Color.FromArgb(103, 115, 142);
            btnAdicionarProduto.FlatStyle = FlatStyle.Flat;
            btnAdicionarProduto.ForeColor = Color.White;
            btnAdicionarProduto.Location = new Point(301, 212);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(102, 43);
            btnAdicionarProduto.TabIndex = 14;
            btnAdicionarProduto.Text = "Adicionar";
            btnAdicionarProduto.UseVisualStyleBackColor = false;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // labelSelecionarProduto
            // 
            labelSelecionarProduto.AutoSize = true;
            labelSelecionarProduto.Location = new Point(301, 97);
            labelSelecionarProduto.Name = "labelSelecionarProduto";
            labelSelecionarProduto.Size = new Size(161, 20);
            labelSelecionarProduto.TabIndex = 12;
            labelSelecionarProduto.Text = "Selecione produto (id):";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(500, 138);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(82, 27);
            textBoxQuantidade.TabIndex = 11;
            // 
            // labelPedido
            // 
            labelPedido.AutoSize = true;
            labelPedido.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPedido.Location = new Point(14, 12);
            labelPedido.Name = "labelPedido";
            labelPedido.Size = new Size(89, 25);
            labelPedido.TabIndex = 10;
            labelPedido.Text = "Pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 141);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 15;
            label1.Text = "Quantidade:";
            // 
            // textBoxSelecionarProduto
            // 
            textBoxSelecionarProduto.Location = new Point(500, 94);
            textBoxSelecionarProduto.Name = "textBoxSelecionarProduto";
            textBoxSelecionarProduto.Size = new Size(82, 27);
            textBoxSelecionarProduto.TabIndex = 16;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(14, 59);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowHeadersWidth = 51;
            dataGridViewProdutos.RowTemplate.Height = 29;
            dataGridViewProdutos.Size = new Size(281, 330);
            dataGridViewProdutos.TabIndex = 17;
            // 
            // dataGridViewPedido
            // 
            dataGridViewPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedido.Location = new Point(621, 56);
            dataGridViewPedido.Name = "dataGridViewPedido";
            dataGridViewPedido.RowHeadersWidth = 51;
            dataGridViewPedido.RowTemplate.Height = 29;
            dataGridViewPedido.Size = new Size(509, 333);
            dataGridViewPedido.TabIndex = 18;
            // 
            // labelItensPedido
            // 
            labelItensPedido.AutoSize = true;
            labelItensPedido.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelItensPedido.Location = new Point(621, 12);
            labelItensPedido.Name = "labelItensPedido";
            labelItensPedido.Size = new Size(190, 25);
            labelItensPedido.TabIndex = 20;
            labelItensPedido.Text = "Itens do Pedido";
            // 
            // buttonReload
            // 
            buttonReload.BackColor = Color.FromArgb(73, 56, 93);
            buttonReload.BackgroundImage = (Image)resources.GetObject("buttonReload.BackgroundImage");
            buttonReload.BackgroundImageLayout = ImageLayout.Center;
            buttonReload.FlatStyle = FlatStyle.Flat;
            buttonReload.ForeColor = Color.White;
            buttonReload.Location = new Point(423, 212);
            buttonReload.Name = "buttonReload";
            buttonReload.Padding = new Padding(23, 27, 23, 27);
            buttonReload.Size = new Size(39, 43);
            buttonReload.TabIndex = 38;
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonEmitirNF
            // 
            buttonEmitirNF.BackColor = Color.FromArgb(91, 38, 63);
            buttonEmitirNF.FlatStyle = FlatStyle.Flat;
            buttonEmitirNF.ForeColor = Color.White;
            buttonEmitirNF.Location = new Point(901, 395);
            buttonEmitirNF.Name = "buttonEmitirNF";
            buttonEmitirNF.Size = new Size(197, 43);
            buttonEmitirNF.TabIndex = 41;
            buttonEmitirNF.Text = "Emitir Nota Fiscal";
            buttonEmitirNF.UseVisualStyleBackColor = false;
            buttonEmitirNF.Click += buttonEmitirNF_Click;
            // 
            // buttonLimparPedido
            // 
            buttonLimparPedido.BackColor = Color.FromArgb(109, 19, 33);
            buttonLimparPedido.FlatStyle = FlatStyle.Flat;
            buttonLimparPedido.ForeColor = Color.White;
            buttonLimparPedido.Location = new Point(657, 395);
            buttonLimparPedido.Name = "buttonLimparPedido";
            buttonLimparPedido.Size = new Size(197, 43);
            buttonLimparPedido.TabIndex = 40;
            buttonLimparPedido.Text = "Limpar pedido";
            buttonLimparPedido.UseVisualStyleBackColor = false;
            buttonLimparPedido.Click += buttonLimparPedido_Click;
            // 
            // buttonApagarItem
            // 
            buttonApagarItem.BackColor = Color.FromArgb(143, 0, 21);
            buttonApagarItem.FlatStyle = FlatStyle.Flat;
            buttonApagarItem.ForeColor = Color.White;
            buttonApagarItem.Location = new Point(480, 212);
            buttonApagarItem.Name = "buttonApagarItem";
            buttonApagarItem.Size = new Size(102, 43);
            buttonApagarItem.TabIndex = 45;
            buttonApagarItem.Text = "Apagar item";
            buttonApagarItem.UseVisualStyleBackColor = false;
            buttonApagarItem.Click += buttonApagarItem_Click;
            // 
            // labelSelecionarCliente
            // 
            labelSelecionarCliente.AutoSize = true;
            labelSelecionarCliente.Location = new Point(301, 59);
            labelSelecionarCliente.Name = "labelSelecionarCliente";
            labelSelecionarCliente.Size = new Size(124, 20);
            labelSelecionarCliente.TabIndex = 46;
            labelSelecionarCliente.Text = "Selecione cliente:";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(431, 56);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(151, 28);
            comboBoxClientes.TabIndex = 47;
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 450);
            Controls.Add(comboBoxClientes);
            Controls.Add(labelSelecionarCliente);
            Controls.Add(buttonApagarItem);
            Controls.Add(buttonEmitirNF);
            Controls.Add(buttonLimparPedido);
            Controls.Add(buttonReload);
            Controls.Add(labelItensPedido);
            Controls.Add(dataGridViewPedido);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(textBoxSelecionarProduto);
            Controls.Add(label1);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(labelSelecionarProduto);
            Controls.Add(textBoxQuantidade);
            Controls.Add(labelPedido);
            Name = "FormPedido";
            Text = "FormNF";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionarProduto;
        private Label labelSelecionarProduto;
        private TextBox textBoxQuantidade;
        private Label labelPedido;
        private Label label1;
        private TextBox textBoxSelecionarProduto;
        private DataGridView dataGridViewProdutos;
        private DataGridView dataGridViewPedido;
        private Label labelItensPedido;
        private Label label2;
        private Button buttonReload;
        private Button buttonEmitirNF;
        private Button buttonLimparPedido;
        private Button buttonApagarItem;
        private Label labelSelecionarCliente;
        private ComboBox comboBoxClientes;
    }
}