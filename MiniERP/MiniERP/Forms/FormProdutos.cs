using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.Forms
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            using (var contexto = new miniERPContext())
            {
                Produto produto = new Produto();
                produto.Nome = textBoxNome.Text;
                produto.Preco = decimal.Parse(textBoxPreco.Text);
                produto.Estoque = int.Parse(textBoxEstoque.Text);

                if (comboBoxFK_Fornecedores.SelectedItem != null && comboBoxFK_Fornecedores.SelectedValue != null)
                {
                    Fornecedor fornecedorSelecionado = (Fornecedor)comboBoxFK_Fornecedores.SelectedItem;
                    int fornecedorId = fornecedorSelecionado.Id;

                    produto.FkFornecedor = fornecedorId;
                }

                contexto.Produtos.Add(produto);
                contexto.SaveChanges();

                MessageBox.Show("Produto adicionado!");
            }

            textBoxNome.Text = "";
            textBoxPreco.Text = "";
            textBoxEstoque.Text = "";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DisableTextBoxes();
            MostrarTodosProdutos();

            //Carrega todos os Fornecedores na comboBox
            using (var contexto = new miniERPContext())
            {
                comboBoxFK_Fornecedores.DisplayMember = "Nome"; 
                comboBoxFK_Fornecedores.ValueMember = "Id";
                comboBoxFK_Fornecedores.DataSource = contexto.Fornecedores.ToList();
            }
        }

        private void comboBoxFK_Fornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxFK_Fornecedores.SelectedItem != null)
            {
                // Obtém o fornecedor selecionado
                Fornecedor fornecedorSelecionado = (Fornecedor)comboBoxFK_Fornecedores.SelectedItem;

                // Exibe o nome do fornecedor selecionado no ComboBox
                comboBoxFK_Fornecedores.Text = fornecedorSelecionado.Nome; // Altere para o campo que deseja exibir
            }
            else
            {
                comboBoxFK_Fornecedores.Text = ""; // Limpa o texto do ComboBox se nenhum fornecedor estiver selecionado
            }
        }

        private void MostrarTodosProdutos()
        {
            using (var contexto = new miniERPContext())
            {
                var produtos = contexto.Produtos.ToList(); // Buscando todos os produtos cadastrados

                dataGridViewProdutos.DataSource = produtos; // Configurando o DataSource para a DataGridView

                dataGridViewProdutos.Columns["FkFornecedorNavigation"].Visible = false;
                dataGridViewProdutos.Columns["FkFornecedor"].HeaderText = "Fornecedor";

            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                int idProduto;
                if (int.TryParse(textBoxBuscar.Text, out idProduto))
                {
                    using (var contexto = new miniERPContext())
                    {
                        // Consulta o produto com o ID fornecido
                        var produtoConsultado = contexto.Produtos
                            .FirstOrDefault(p => p.Id == idProduto);

                        if (produtoConsultado != null)
                        {
                            // Limpa o DataSource atual do DataGridView
                            dataGridViewProdutos.DataSource = null;

                            // Cria uma nova lista com o produto consultado e a atribui ao DataSource do DataGridView
                            dataGridViewProdutos.DataSource = new List<Produto> { produtoConsultado };
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID de produto válido (número inteiro).");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de produto para consultar.");
            }

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                int idProduto;
                if (int.TryParse(textBoxBuscar.Text, out idProduto))
                {
                    using (var contexto = new miniERPContext())
                    {
                        var produtoParaDeletar = contexto.Produtos.Find(idProduto);

                        if (produtoParaDeletar != null)
                        {
                            // Remove o produto encontrado do contexto
                            contexto.Produtos.Remove(produtoParaDeletar);
                            contexto.SaveChanges();

                            MessageBox.Show("Produto removido com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID de produto válido (número inteiro).");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de produto para remover.");
            }
            textBoxBuscar.Text = "";
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            DisableTextBoxes();
            MostrarTodosProdutos();
            textBoxBuscar.Text = "";
        }

        private void DisableTextBoxes()
        {
            textBoxNomeUpdate.Text = "";
            textBoxPrecoUpdate.Text = "";
            textBoxEstoqueUpdate.Text = "";

            textBoxNomeUpdate.Enabled = false;
            textBoxPrecoUpdate.Enabled = false;
            textBoxEstoqueUpdate.Enabled = false;
            comboBoxFornecedorUpdate.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                using (var contexto = new miniERPContext())
                {
                    comboBoxFornecedorUpdate.DisplayMember = "Nome"; // Altere para o campo que deseja exibir
                    comboBoxFornecedorUpdate.ValueMember = "Id"; // ID será usado como valor selecionado no ComboBox
                    comboBoxFornecedorUpdate.DataSource = contexto.Fornecedores.ToList();
                }
                textBoxNomeUpdate.Enabled = true;
                textBoxPrecoUpdate.Enabled = true;
                textBoxEstoqueUpdate.Enabled = true;
                comboBoxFornecedorUpdate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de produto para poder editá-lo.");
            }



        }

        private void buttonSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                int idProduto;
                if (int.TryParse(textBoxBuscar.Text, out idProduto))
                {
                    using (var contexto = new miniERPContext())
                    {
                        var produtoParaAtualizar = contexto.Produtos.Find(idProduto);

                        if (produtoParaAtualizar != null)
                        {
                            // Atualizar os dados do produto
                            produtoParaAtualizar.Nome = textBoxNomeUpdate.Text;
                            produtoParaAtualizar.Preco = decimal.Parse(textBoxPrecoUpdate.Text);
                            produtoParaAtualizar.Estoque = int.Parse(textBoxEstoqueUpdate.Text);

                            // Verificar e atualizar o ID do fornecedor do produto
                            if (comboBoxFornecedorUpdate.SelectedItem != null && comboBoxFornecedorUpdate.SelectedValue != null)
                            {
                                Fornecedor fornecedorSelecionado = (Fornecedor)comboBoxFornecedorUpdate.SelectedItem;
                                int fornecedorId = fornecedorSelecionado.Id; // Supondo que o ID do fornecedor seja acessado através da propriedade 'Id'

                                produtoParaAtualizar.FkFornecedor = fornecedorId;
                            }

                            // Salvar as alterações no banco de dados
                            contexto.SaveChanges();

                            MessageBox.Show("Produto atualizado com sucesso.");

                            // Desabilitar campos após a atualização
                            DisableTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID de produto válido (número inteiro).");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de produto para atualizar.");
            }
        }

        private void comboBoxFornecedorUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se a seleção do ComboBox é válida
            if (comboBoxFornecedorUpdate.SelectedItem != null)
            {
                // Obtém o fornecedor selecionado
                Fornecedor fornecedorSelecionado = (Fornecedor)comboBoxFornecedorUpdate.SelectedItem;

                // Exibe o nome do fornecedor selecionado no ComboBox
                comboBoxFornecedorUpdate.Text = fornecedorSelecionado.Nome; // Altere para o campo que deseja exibir
            }
            else
            {
                comboBoxFornecedorUpdate.Text = ""; // Limpa o texto do ComboBox se nenhum fornecedor estiver selecionado
            }
        }
    }
}
