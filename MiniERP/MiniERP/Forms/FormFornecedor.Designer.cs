namespace MiniERP.Forms
{
    partial class FormFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFornecedor));
            btnCadastrarFornecedor = new Button();
            textBoxNomeFornecedor = new TextBox();
            labelNomeFornecedor = new Label();
            labelCadastrarFornecedor = new Label();
            buttonApagarFornecedor = new Button();
            dataGridViewFornecedores = new DataGridView();
            labelFornecedoresCadastrados = new Label();
            buttonUpdateFornecedor = new Button();
            buttonReload = new Button();
            textBoxBuscarFornecedor = new TextBox();
            buttonConsultarFornecedor = new Button();
            labelBuscarFornecedor = new Label();
            btnSaveUpdateFornecedor = new Button();
            textBoxNameFornecedorUpdate = new TextBox();
            labelNomeUpdate = new Label();
            labelUpdateFornecedor = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedores).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrarFornecedor
            // 
            btnCadastrarFornecedor.BackColor = Color.FromArgb(103, 115, 142);
            btnCadastrarFornecedor.FlatStyle = FlatStyle.Flat;
            btnCadastrarFornecedor.ForeColor = Color.White;
            btnCadastrarFornecedor.Location = new Point(14, 129);
            btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            btnCadastrarFornecedor.Size = new Size(277, 43);
            btnCadastrarFornecedor.TabIndex = 13;
            btnCadastrarFornecedor.Text = "Cadastrar";
            btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            btnCadastrarFornecedor.Click += btnCadastrarFornecedor_Click;
            // 
            // textBoxNomeFornecedor
            // 
            textBoxNomeFornecedor.Location = new Point(110, 80);
            textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            textBoxNomeFornecedor.Size = new Size(182, 27);
            textBoxNomeFornecedor.TabIndex = 12;
            // 
            // labelNomeFornecedor
            // 
            labelNomeFornecedor.AutoSize = true;
            labelNomeFornecedor.Location = new Point(14, 80);
            labelNomeFornecedor.Name = "labelNomeFornecedor";
            labelNomeFornecedor.Size = new Size(53, 20);
            labelNomeFornecedor.TabIndex = 11;
            labelNomeFornecedor.Text = "Nome:";
            // 
            // labelCadastrarFornecedor
            // 
            labelCadastrarFornecedor.AutoSize = true;
            labelCadastrarFornecedor.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCadastrarFornecedor.Location = new Point(14, 12);
            labelCadastrarFornecedor.Name = "labelCadastrarFornecedor";
            labelCadastrarFornecedor.Size = new Size(254, 25);
            labelCadastrarFornecedor.TabIndex = 10;
            labelCadastrarFornecedor.Text = "Cadastrar Fornecedor";
            // 
            // buttonApagarFornecedor
            // 
            buttonApagarFornecedor.BackColor = Color.FromArgb(143, 0, 21);
            buttonApagarFornecedor.FlatStyle = FlatStyle.Flat;
            buttonApagarFornecedor.ForeColor = Color.White;
            buttonApagarFornecedor.Location = new Point(574, 447);
            buttonApagarFornecedor.Name = "buttonApagarFornecedor";
            buttonApagarFornecedor.Size = new Size(214, 43);
            buttonApagarFornecedor.TabIndex = 19;
            buttonApagarFornecedor.Text = "Apagar";
            buttonApagarFornecedor.UseVisualStyleBackColor = false;
            buttonApagarFornecedor.Click += buttonApagarFornecedor_Click;
            // 
            // dataGridViewFornecedores
            // 
            dataGridViewFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFornecedores.Location = new Point(347, 184);
            dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            dataGridViewFornecedores.RowHeadersWidth = 51;
            dataGridViewFornecedores.RowTemplate.Height = 29;
            dataGridViewFornecedores.Size = new Size(440, 257);
            dataGridViewFornecedores.TabIndex = 16;
            // 
            // labelFornecedoresCadastrados
            // 
            labelFornecedoresCadastrados.AutoSize = true;
            labelFornecedoresCadastrados.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFornecedoresCadastrados.Location = new Point(347, 12);
            labelFornecedoresCadastrados.Name = "labelFornecedoresCadastrados";
            labelFornecedoresCadastrados.Size = new Size(309, 25);
            labelFornecedoresCadastrados.TabIndex = 15;
            labelFornecedoresCadastrados.Text = "Fornecedores Cadastrados";
            // 
            // buttonUpdateFornecedor
            // 
            buttonUpdateFornecedor.BackColor = Color.FromArgb(91, 38, 63);
            buttonUpdateFornecedor.FlatStyle = FlatStyle.Flat;
            buttonUpdateFornecedor.ForeColor = Color.White;
            buttonUpdateFornecedor.Location = new Point(591, 129);
            buttonUpdateFornecedor.Name = "buttonUpdateFornecedor";
            buttonUpdateFornecedor.Size = new Size(197, 43);
            buttonUpdateFornecedor.TabIndex = 23;
            buttonUpdateFornecedor.Text = "Editar";
            buttonUpdateFornecedor.UseVisualStyleBackColor = false;
            buttonUpdateFornecedor.Click += buttonUpdateFornecedor_Click;
            // 
            // buttonReload
            // 
            buttonReload.BackColor = Color.FromArgb(73, 56, 93);
            buttonReload.BackgroundImage = (Image)resources.GetObject("buttonReload.BackgroundImage");
            buttonReload.BackgroundImageLayout = ImageLayout.Center;
            buttonReload.FlatStyle = FlatStyle.Flat;
            buttonReload.ForeColor = Color.White;
            buttonReload.Location = new Point(549, 129);
            buttonReload.Name = "buttonReload";
            buttonReload.Padding = new Padding(23, 27, 23, 27);
            buttonReload.Size = new Size(39, 43);
            buttonReload.TabIndex = 22;
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += buttonReload_Click;
            // 
            // textBoxBuscarFornecedor
            // 
            textBoxBuscarFornecedor.Location = new Point(347, 92);
            textBoxBuscarFornecedor.Name = "textBoxBuscarFornecedor";
            textBoxBuscarFornecedor.Size = new Size(441, 27);
            textBoxBuscarFornecedor.TabIndex = 21;
            // 
            // buttonConsultarFornecedor
            // 
            buttonConsultarFornecedor.BackColor = Color.FromArgb(103, 115, 142);
            buttonConsultarFornecedor.FlatStyle = FlatStyle.Flat;
            buttonConsultarFornecedor.ForeColor = Color.White;
            buttonConsultarFornecedor.Location = new Point(347, 129);
            buttonConsultarFornecedor.Name = "buttonConsultarFornecedor";
            buttonConsultarFornecedor.Size = new Size(197, 43);
            buttonConsultarFornecedor.TabIndex = 20;
            buttonConsultarFornecedor.Text = "Consultar";
            buttonConsultarFornecedor.UseVisualStyleBackColor = false;
            buttonConsultarFornecedor.Click += buttonConsultarFornecedor_Click;
            // 
            // labelBuscarFornecedor
            // 
            labelBuscarFornecedor.AutoSize = true;
            labelBuscarFornecedor.Location = new Point(347, 69);
            labelBuscarFornecedor.Name = "labelBuscarFornecedor";
            labelBuscarFornecedor.Size = new Size(159, 20);
            labelBuscarFornecedor.TabIndex = 24;
            labelBuscarFornecedor.Text = "Buscar fornecedor (id):";
            // 
            // btnSaveUpdateFornecedor
            // 
            btnSaveUpdateFornecedor.BackColor = Color.FromArgb(103, 115, 142);
            btnSaveUpdateFornecedor.FlatStyle = FlatStyle.Flat;
            btnSaveUpdateFornecedor.ForeColor = Color.White;
            btnSaveUpdateFornecedor.Location = new Point(843, 129);
            btnSaveUpdateFornecedor.Name = "btnSaveUpdateFornecedor";
            btnSaveUpdateFornecedor.Size = new Size(277, 43);
            btnSaveUpdateFornecedor.TabIndex = 27;
            btnSaveUpdateFornecedor.Text = "Atualizar";
            btnSaveUpdateFornecedor.UseVisualStyleBackColor = false;
            btnSaveUpdateFornecedor.Click += btnSaveUpdateFornecedor_Click;
            // 
            // textBoxNameFornecedorUpdate
            // 
            textBoxNameFornecedorUpdate.Location = new Point(939, 80);
            textBoxNameFornecedorUpdate.Name = "textBoxNameFornecedorUpdate";
            textBoxNameFornecedorUpdate.Size = new Size(182, 27);
            textBoxNameFornecedorUpdate.TabIndex = 26;
            // 
            // labelNomeUpdate
            // 
            labelNomeUpdate.AutoSize = true;
            labelNomeUpdate.Location = new Point(843, 80);
            labelNomeUpdate.Name = "labelNomeUpdate";
            labelNomeUpdate.Size = new Size(53, 20);
            labelNomeUpdate.TabIndex = 25;
            labelNomeUpdate.Text = "Nome:";
            // 
            // labelUpdateFornecedor
            // 
            labelUpdateFornecedor.AutoSize = true;
            labelUpdateFornecedor.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUpdateFornecedor.Location = new Point(843, 12);
            labelUpdateFornecedor.Name = "labelUpdateFornecedor";
            labelUpdateFornecedor.Size = new Size(213, 25);
            labelUpdateFornecedor.TabIndex = 28;
            labelUpdateFornecedor.Text = "Editar Fornecedor";
            // 
            // FormFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 525);
            Controls.Add(labelUpdateFornecedor);
            Controls.Add(btnSaveUpdateFornecedor);
            Controls.Add(textBoxNameFornecedorUpdate);
            Controls.Add(labelNomeUpdate);
            Controls.Add(labelBuscarFornecedor);
            Controls.Add(buttonUpdateFornecedor);
            Controls.Add(buttonReload);
            Controls.Add(textBoxBuscarFornecedor);
            Controls.Add(buttonConsultarFornecedor);
            Controls.Add(buttonApagarFornecedor);
            Controls.Add(dataGridViewFornecedores);
            Controls.Add(labelFornecedoresCadastrados);
            Controls.Add(btnCadastrarFornecedor);
            Controls.Add(textBoxNomeFornecedor);
            Controls.Add(labelNomeFornecedor);
            Controls.Add(labelCadastrarFornecedor);
            Name = "FormFornecedor";
            Text = "FormFornecedor";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarFornecedor;
        private TextBox textBoxNomeFornecedor;
        private Label labelNomeFornecedor;
        private Label labelCadastrarFornecedor;
        private Button buttonApagarFornecedor;
        private DataGridView dataGridViewFornecedores;
        private Label labelFornecedoresCadastrados;
        private Button buttonUpdateFornecedor;
        private Button buttonReload;
        private TextBox textBoxBuscarFornecedor;
        private Button buttonConsultarFornecedor;
        private Label labelBuscarFornecedor;
        private Button btnSaveUpdateFornecedor;
        private TextBox textBoxNameFornecedorUpdate;
        private Label labelNomeUpdate;
        private Label labelUpdateFornecedor;
    }
}