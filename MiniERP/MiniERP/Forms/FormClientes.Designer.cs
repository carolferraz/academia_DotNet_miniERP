namespace MiniERP.Forms
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            labelUpdateCliente = new Label();
            btnSaveUpdateCliente = new Button();
            textBoxNameClienteUpdate = new TextBox();
            labelNomeUpdate = new Label();
            labelBuscarCliente = new Label();
            buttonUpdateCliente = new Button();
            buttonReload = new Button();
            textBoxBuscarCliente = new TextBox();
            buttonConsultarCliente = new Button();
            dataGridViewClientes = new DataGridView();
            labelClientesCadastrados = new Label();
            btnCadastrarCliente = new Button();
            textBoxNomeCliente = new TextBox();
            labelNomeCliente = new Label();
            labelCadastrarCliente = new Label();
            buttonApagarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // labelUpdateCliente
            // 
            labelUpdateCliente.AutoSize = true;
            labelUpdateCliente.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUpdateCliente.Location = new Point(843, 13);
            labelUpdateCliente.Name = "labelUpdateCliente";
            labelUpdateCliente.Size = new Size(163, 25);
            labelUpdateCliente.TabIndex = 43;
            labelUpdateCliente.Text = "Editar Cliente";
            // 
            // btnSaveUpdateCliente
            // 
            btnSaveUpdateCliente.BackColor = Color.FromArgb(103, 115, 142);
            btnSaveUpdateCliente.FlatStyle = FlatStyle.Flat;
            btnSaveUpdateCliente.ForeColor = Color.White;
            btnSaveUpdateCliente.Location = new Point(843, 130);
            btnSaveUpdateCliente.Name = "btnSaveUpdateCliente";
            btnSaveUpdateCliente.Size = new Size(277, 43);
            btnSaveUpdateCliente.TabIndex = 42;
            btnSaveUpdateCliente.Text = "Atualizar";
            btnSaveUpdateCliente.UseVisualStyleBackColor = false;
            btnSaveUpdateCliente.Click += btnSaveUpdateCliente_Click;
            // 
            // textBoxNameClienteUpdate
            // 
            textBoxNameClienteUpdate.Location = new Point(939, 81);
            textBoxNameClienteUpdate.Name = "textBoxNameClienteUpdate";
            textBoxNameClienteUpdate.Size = new Size(182, 27);
            textBoxNameClienteUpdate.TabIndex = 41;
            // 
            // labelNomeUpdate
            // 
            labelNomeUpdate.AutoSize = true;
            labelNomeUpdate.Location = new Point(843, 81);
            labelNomeUpdate.Name = "labelNomeUpdate";
            labelNomeUpdate.Size = new Size(53, 20);
            labelNomeUpdate.TabIndex = 40;
            labelNomeUpdate.Text = "Nome:";
            // 
            // labelBuscarCliente
            // 
            labelBuscarCliente.AutoSize = true;
            labelBuscarCliente.Location = new Point(347, 70);
            labelBuscarCliente.Name = "labelBuscarCliente";
            labelBuscarCliente.Size = new Size(159, 20);
            labelBuscarCliente.TabIndex = 39;
            labelBuscarCliente.Text = "Buscar fornecedor (id):";
            // 
            // buttonUpdateCliente
            // 
            buttonUpdateCliente.BackColor = Color.FromArgb(91, 38, 63);
            buttonUpdateCliente.FlatStyle = FlatStyle.Flat;
            buttonUpdateCliente.ForeColor = Color.White;
            buttonUpdateCliente.Location = new Point(591, 130);
            buttonUpdateCliente.Name = "buttonUpdateCliente";
            buttonUpdateCliente.Size = new Size(197, 43);
            buttonUpdateCliente.TabIndex = 38;
            buttonUpdateCliente.Text = "Editar";
            buttonUpdateCliente.UseVisualStyleBackColor = false;
            buttonUpdateCliente.Click += buttonUpdateCliente_Click;
            // 
            // buttonReload
            // 
            buttonReload.BackColor = Color.FromArgb(73, 56, 93);
            buttonReload.BackgroundImage = (Image)resources.GetObject("buttonReload.BackgroundImage");
            buttonReload.BackgroundImageLayout = ImageLayout.Center;
            buttonReload.FlatStyle = FlatStyle.Flat;
            buttonReload.ForeColor = Color.White;
            buttonReload.Location = new Point(549, 130);
            buttonReload.Name = "buttonReload";
            buttonReload.Padding = new Padding(23, 27, 23, 27);
            buttonReload.Size = new Size(39, 43);
            buttonReload.TabIndex = 37;
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += buttonReload_Click;
            // 
            // textBoxBuscarCliente
            // 
            textBoxBuscarCliente.Location = new Point(347, 93);
            textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            textBoxBuscarCliente.Size = new Size(441, 27);
            textBoxBuscarCliente.TabIndex = 36;
            // 
            // buttonConsultarCliente
            // 
            buttonConsultarCliente.BackColor = Color.FromArgb(103, 115, 142);
            buttonConsultarCliente.FlatStyle = FlatStyle.Flat;
            buttonConsultarCliente.ForeColor = Color.White;
            buttonConsultarCliente.Location = new Point(347, 130);
            buttonConsultarCliente.Name = "buttonConsultarCliente";
            buttonConsultarCliente.Size = new Size(197, 43);
            buttonConsultarCliente.TabIndex = 35;
            buttonConsultarCliente.Text = "Consultar";
            buttonConsultarCliente.UseVisualStyleBackColor = false;
            buttonConsultarCliente.Click += buttonConsultarCliente_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(347, 185);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.RowTemplate.Height = 29;
            dataGridViewClientes.Size = new Size(440, 257);
            dataGridViewClientes.TabIndex = 34;
            // 
            // labelClientesCadastrados
            // 
            labelClientesCadastrados.AutoSize = true;
            labelClientesCadastrados.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientesCadastrados.Location = new Point(347, 13);
            labelClientesCadastrados.Name = "labelClientesCadastrados";
            labelClientesCadastrados.Size = new Size(246, 25);
            labelClientesCadastrados.TabIndex = 33;
            labelClientesCadastrados.Text = "Clientes Cadastrados";
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.BackColor = Color.FromArgb(103, 115, 142);
            btnCadastrarCliente.FlatStyle = FlatStyle.Flat;
            btnCadastrarCliente.ForeColor = Color.White;
            btnCadastrarCliente.Location = new Point(14, 130);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(277, 43);
            btnCadastrarCliente.TabIndex = 32;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = false;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(110, 81);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(182, 27);
            textBoxNomeCliente.TabIndex = 31;
            // 
            // labelNomeCliente
            // 
            labelNomeCliente.AutoSize = true;
            labelNomeCliente.Location = new Point(14, 81);
            labelNomeCliente.Name = "labelNomeCliente";
            labelNomeCliente.Size = new Size(53, 20);
            labelNomeCliente.TabIndex = 30;
            labelNomeCliente.Text = "Nome:";
            // 
            // labelCadastrarCliente
            // 
            labelCadastrarCliente.AutoSize = true;
            labelCadastrarCliente.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCadastrarCliente.Location = new Point(14, 13);
            labelCadastrarCliente.Name = "labelCadastrarCliente";
            labelCadastrarCliente.Size = new Size(204, 25);
            labelCadastrarCliente.TabIndex = 29;
            labelCadastrarCliente.Text = "Cadastrar Cliente";
            // 
            // buttonApagarCliente
            // 
            buttonApagarCliente.BackColor = Color.FromArgb(143, 0, 21);
            buttonApagarCliente.FlatStyle = FlatStyle.Flat;
            buttonApagarCliente.ForeColor = Color.White;
            buttonApagarCliente.Location = new Point(574, 448);
            buttonApagarCliente.Name = "buttonApagarCliente";
            buttonApagarCliente.Size = new Size(214, 43);
            buttonApagarCliente.TabIndex = 44;
            buttonApagarCliente.Text = "Apagar";
            buttonApagarCliente.UseVisualStyleBackColor = false;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 503);
            Controls.Add(buttonApagarCliente);
            Controls.Add(labelUpdateCliente);
            Controls.Add(btnSaveUpdateCliente);
            Controls.Add(textBoxNameClienteUpdate);
            Controls.Add(labelNomeUpdate);
            Controls.Add(labelBuscarCliente);
            Controls.Add(buttonUpdateCliente);
            Controls.Add(buttonReload);
            Controls.Add(textBoxBuscarCliente);
            Controls.Add(buttonConsultarCliente);
            Controls.Add(dataGridViewClientes);
            Controls.Add(labelClientesCadastrados);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(textBoxNomeCliente);
            Controls.Add(labelNomeCliente);
            Controls.Add(labelCadastrarCliente);
            Name = "FormClientes";
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUpdateCliente;
        private Button btnSaveUpdateCliente;
        private TextBox textBoxNameClienteUpdate;
        private Label labelNomeUpdate;
        private Label labelBuscarCliente;
        private Button buttonUpdateCliente;
        private Button buttonReload;
        private TextBox textBoxBuscarCliente;
        private Button buttonConsultarCliente;
        private DataGridView dataGridViewClientes;
        private Label labelClientesCadastrados;
        private Button btnCadastrarCliente;
        private TextBox textBoxNomeCliente;
        private Label labelNomeCliente;
        private Label labelCadastrarCliente;
        private Button buttonApagarCliente;
    }
}