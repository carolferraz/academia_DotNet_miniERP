namespace MiniERP.Forms
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            labelCadastrar = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            textBoxPreco = new TextBox();
            labelPreco = new Label();
            textBoxEstoque = new TextBox();
            labelEstoque = new Label();
            labelFornecedor = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            comboBoxFK_Fornecedores = new ComboBox();
            btnCadastrarProduto = new Button();
            labelProdutosCadastrados = new Label();
            dataGridViewProdutos = new DataGridView();
            buttonConsultar = new Button();
            textBoxBuscar = new TextBox();
            buttonApagar = new Button();
            labelBuscarProduto = new Label();
            buttonReload = new Button();
            buttonUpdate = new Button();
            buttonSaveUpdate = new Button();
            comboBoxFornecedorUpdate = new ComboBox();
            labelFornecedorUpdate = new Label();
            textBoxEstoqueUpdate = new TextBox();
            labelEstoqueUpdate = new Label();
            textBoxPrecoUpdate = new TextBox();
            labelPrecoUpdate = new Label();
            textBoxNomeUpdate = new TextBox();
            labelNomeUpdate = new Label();
            labelUpdateProduto = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // labelCadastrar
            // 
            labelCadastrar.AutoSize = true;
            labelCadastrar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCadastrar.Location = new Point(12, 9);
            labelCadastrar.Name = "labelCadastrar";
            labelCadastrar.Size = new Size(96, 18);
            labelCadastrar.TabIndex = 0;
            labelCadastrar.Text = "Cadastrar";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(14, 54);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(97, 54);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(160, 23);
            textBoxNome.TabIndex = 2;
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(97, 79);
            textBoxPreco.Margin = new Padding(3, 2, 3, 2);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(160, 23);
            textBoxPreco.TabIndex = 4;
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Location = new Point(14, 79);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(40, 15);
            labelPreco.TabIndex = 3;
            labelPreco.Text = "Preço:";
            // 
            // textBoxEstoque
            // 
            textBoxEstoque.Location = new Point(97, 103);
            textBoxEstoque.Margin = new Padding(3, 2, 3, 2);
            textBoxEstoque.Name = "textBoxEstoque";
            textBoxEstoque.Size = new Size(160, 23);
            textBoxEstoque.TabIndex = 6;
            // 
            // labelEstoque
            // 
            labelEstoque.AutoSize = true;
            labelEstoque.Location = new Point(14, 103);
            labelEstoque.Name = "labelEstoque";
            labelEstoque.Size = new Size(52, 15);
            labelEstoque.TabIndex = 5;
            labelEstoque.Text = "Estoque:";
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.Location = new Point(14, 129);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(67, 15);
            labelFornecedor.TabIndex = 7;
            labelFornecedor.Text = "Fornecedor";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // comboBoxFK_Fornecedores
            // 
            comboBoxFK_Fornecedores.FormattingEnabled = true;
            comboBoxFK_Fornecedores.Location = new Point(97, 129);
            comboBoxFK_Fornecedores.Margin = new Padding(3, 2, 3, 2);
            comboBoxFK_Fornecedores.Name = "comboBoxFK_Fornecedores";
            comboBoxFK_Fornecedores.Size = new Size(160, 23);
            comboBoxFK_Fornecedores.TabIndex = 8;
            comboBoxFK_Fornecedores.SelectedIndexChanged += comboBoxFK_Fornecedores_SelectedIndexChanged;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.BackColor = Color.FromArgb(103, 115, 142);
            btnCadastrarProduto.FlatStyle = FlatStyle.Flat;
            btnCadastrarProduto.ForeColor = Color.White;
            btnCadastrarProduto.Location = new Point(14, 171);
            btnCadastrarProduto.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(242, 32);
            btnCadastrarProduto.TabIndex = 9;
            btnCadastrarProduto.Text = "Cadastrar";
            btnCadastrarProduto.UseVisualStyleBackColor = false;
            btnCadastrarProduto.Click += btnCadastrarProduto_Click;
            // 
            // labelProdutosCadastrados
            // 
            labelProdutosCadastrados.AutoSize = true;
            labelProdutosCadastrados.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelProdutosCadastrados.Location = new Point(313, 9);
            labelProdutosCadastrados.Name = "labelProdutosCadastrados";
            labelProdutosCadastrados.Size = new Size(204, 18);
            labelProdutosCadastrados.TabIndex = 10;
            labelProdutosCadastrados.Text = "Produtos Cadastrados";
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(313, 136);
            dataGridViewProdutos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowHeadersWidth = 51;
            dataGridViewProdutos.RowTemplate.Height = 29;
            dataGridViewProdutos.Size = new Size(385, 193);
            dataGridViewProdutos.TabIndex = 11;
            // 
            // buttonConsultar
            // 
            buttonConsultar.BackColor = Color.FromArgb(103, 115, 142);
            buttonConsultar.FlatStyle = FlatStyle.Flat;
            buttonConsultar.ForeColor = Color.White;
            buttonConsultar.Location = new Point(313, 97);
            buttonConsultar.Margin = new Padding(3, 2, 3, 2);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(172, 32);
            buttonConsultar.TabIndex = 12;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = false;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(313, 69);
            textBoxBuscar.Margin = new Padding(3, 2, 3, 2);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(386, 23);
            textBoxBuscar.TabIndex = 13;
            // 
            // buttonApagar
            // 
            buttonApagar.BackColor = Color.FromArgb(143, 0, 21);
            buttonApagar.FlatStyle = FlatStyle.Flat;
            buttonApagar.ForeColor = Color.White;
            buttonApagar.Location = new Point(526, 333);
            buttonApagar.Margin = new Padding(3, 2, 3, 2);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(172, 32);
            buttonApagar.TabIndex = 14;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = false;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // labelBuscarProduto
            // 
            labelBuscarProduto.AutoSize = true;
            labelBuscarProduto.Location = new Point(313, 52);
            labelBuscarProduto.Name = "labelBuscarProduto";
            labelBuscarProduto.Size = new Size(112, 15);
            labelBuscarProduto.TabIndex = 15;
            labelBuscarProduto.Text = "Buscar produto (id):";
            // 
            // buttonReload
            // 
            buttonReload.BackColor = Color.FromArgb(73, 56, 93);
            buttonReload.BackgroundImage = (Image)resources.GetObject("buttonReload.BackgroundImage");
            buttonReload.BackgroundImageLayout = ImageLayout.Center;
            buttonReload.FlatStyle = FlatStyle.Flat;
            buttonReload.ForeColor = Color.White;
            buttonReload.Location = new Point(489, 97);
            buttonReload.Margin = new Padding(3, 2, 3, 2);
            buttonReload.Name = "buttonReload";
            buttonReload.Padding = new Padding(20);
            buttonReload.Size = new Size(34, 32);
            buttonReload.TabIndex = 16;
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(91, 38, 63);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(526, 97);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(172, 32);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Editar";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonSaveUpdate
            // 
            buttonSaveUpdate.BackColor = Color.FromArgb(103, 115, 142);
            buttonSaveUpdate.FlatStyle = FlatStyle.Flat;
            buttonSaveUpdate.ForeColor = Color.White;
            buttonSaveUpdate.Location = new Point(744, 171);
            buttonSaveUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonSaveUpdate.Name = "buttonSaveUpdate";
            buttonSaveUpdate.Size = new Size(242, 32);
            buttonSaveUpdate.TabIndex = 27;
            buttonSaveUpdate.Text = "Atualizar";
            buttonSaveUpdate.UseVisualStyleBackColor = false;
            buttonSaveUpdate.Click += buttonSaveUpdate_Click;
            // 
            // comboBoxFornecedorUpdate
            // 
            comboBoxFornecedorUpdate.FormattingEnabled = true;
            comboBoxFornecedorUpdate.Location = new Point(827, 132);
            comboBoxFornecedorUpdate.Margin = new Padding(3, 2, 3, 2);
            comboBoxFornecedorUpdate.Name = "comboBoxFornecedorUpdate";
            comboBoxFornecedorUpdate.Size = new Size(160, 23);
            comboBoxFornecedorUpdate.TabIndex = 26;
            comboBoxFornecedorUpdate.SelectedIndexChanged += comboBoxFornecedorUpdate_SelectedIndexChanged;
            // 
            // labelFornecedorUpdate
            // 
            labelFornecedorUpdate.AutoSize = true;
            labelFornecedorUpdate.Location = new Point(744, 132);
            labelFornecedorUpdate.Name = "labelFornecedorUpdate";
            labelFornecedorUpdate.Size = new Size(67, 15);
            labelFornecedorUpdate.TabIndex = 25;
            labelFornecedorUpdate.Text = "Fornecedor";
            // 
            // textBoxEstoqueUpdate
            // 
            textBoxEstoqueUpdate.Location = new Point(827, 106);
            textBoxEstoqueUpdate.Margin = new Padding(3, 2, 3, 2);
            textBoxEstoqueUpdate.Name = "textBoxEstoqueUpdate";
            textBoxEstoqueUpdate.Size = new Size(160, 23);
            textBoxEstoqueUpdate.TabIndex = 24;
            // 
            // labelEstoqueUpdate
            // 
            labelEstoqueUpdate.AutoSize = true;
            labelEstoqueUpdate.Location = new Point(744, 106);
            labelEstoqueUpdate.Name = "labelEstoqueUpdate";
            labelEstoqueUpdate.Size = new Size(52, 15);
            labelEstoqueUpdate.TabIndex = 23;
            labelEstoqueUpdate.Text = "Estoque:";
            // 
            // textBoxPrecoUpdate
            // 
            textBoxPrecoUpdate.Location = new Point(827, 82);
            textBoxPrecoUpdate.Margin = new Padding(3, 2, 3, 2);
            textBoxPrecoUpdate.Name = "textBoxPrecoUpdate";
            textBoxPrecoUpdate.Size = new Size(160, 23);
            textBoxPrecoUpdate.TabIndex = 22;
            // 
            // labelPrecoUpdate
            // 
            labelPrecoUpdate.AutoSize = true;
            labelPrecoUpdate.Location = new Point(744, 82);
            labelPrecoUpdate.Name = "labelPrecoUpdate";
            labelPrecoUpdate.Size = new Size(40, 15);
            labelPrecoUpdate.TabIndex = 21;
            labelPrecoUpdate.Text = "Preço:";
            // 
            // textBoxNomeUpdate
            // 
            textBoxNomeUpdate.Location = new Point(827, 57);
            textBoxNomeUpdate.Margin = new Padding(3, 2, 3, 2);
            textBoxNomeUpdate.Name = "textBoxNomeUpdate";
            textBoxNomeUpdate.Size = new Size(160, 23);
            textBoxNomeUpdate.TabIndex = 20;
            // 
            // labelNomeUpdate
            // 
            labelNomeUpdate.AutoSize = true;
            labelNomeUpdate.Location = new Point(744, 57);
            labelNomeUpdate.Name = "labelNomeUpdate";
            labelNomeUpdate.Size = new Size(43, 15);
            labelNomeUpdate.TabIndex = 19;
            labelNomeUpdate.Text = "Nome:";
            // 
            // labelUpdateProduto
            // 
            labelUpdateProduto.AutoSize = true;
            labelUpdateProduto.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUpdateProduto.Location = new Point(742, 9);
            labelUpdateProduto.Name = "labelUpdateProduto";
            labelUpdateProduto.Size = new Size(135, 18);
            labelUpdateProduto.TabIndex = 18;
            labelUpdateProduto.Text = "Editar produto";
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 371);
            Controls.Add(buttonSaveUpdate);
            Controls.Add(comboBoxFornecedorUpdate);
            Controls.Add(labelFornecedorUpdate);
            Controls.Add(textBoxEstoqueUpdate);
            Controls.Add(labelEstoqueUpdate);
            Controls.Add(textBoxPrecoUpdate);
            Controls.Add(labelPrecoUpdate);
            Controls.Add(textBoxNomeUpdate);
            Controls.Add(labelNomeUpdate);
            Controls.Add(labelUpdateProduto);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonReload);
            Controls.Add(labelBuscarProduto);
            Controls.Add(buttonApagar);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonConsultar);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(labelProdutosCadastrados);
            Controls.Add(btnCadastrarProduto);
            Controls.Add(comboBoxFK_Fornecedores);
            Controls.Add(labelFornecedor);
            Controls.Add(textBoxEstoque);
            Controls.Add(labelEstoque);
            Controls.Add(textBoxPreco);
            Controls.Add(labelPreco);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(labelCadastrar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProdutos";
            Text = "FormProdutos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCadastrar;
        private Label labelNome;
        private TextBox textBoxNome;
        private TextBox textBoxPreco;
        private Label labelPreco;
        private TextBox textBoxEstoque;
        private Label labelEstoque;
        private Label labelFornecedor;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBoxFK_Fornecedores;
        private Button btnCadastrarProduto;
        private Label labelProdutosCadastrados;
        private DataGridView dataGridViewProdutos;
        private Button buttonConsultar;
        private TextBox textBoxBuscar;
        private Button buttonApagar;
        private Label labelBuscarProduto;
        private Button buttonReload;
        private Button buttonUpdate;
        private Button buttonSaveUpdate;
        private ComboBox comboBoxFornecedorUpdate;
        private Label labelFornecedorUpdate;
        private TextBox textBoxEstoqueUpdate;
        private Label labelEstoqueUpdate;
        private TextBox textBoxPrecoUpdate;
        private Label labelPrecoUpdate;
        private TextBox textBoxNomeUpdate;
        private Label labelNomeUpdate;
        private Label labelUpdateProduto;
    }
}