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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            using (var contexto = new miniERPContext())
            {
                Cliente fornecedor = new Cliente();
                fornecedor.Nome = textBoxNomeCliente.Text;

                contexto.Clientes.Add(fornecedor);
                contexto.SaveChanges();

                MessageBox.Show("Cliente adicionado!");
            }

            textBoxNomeCliente.Text = "";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DisableTextBoxes();
            MostrarTodosClientes();
        }

        private void MostrarTodosClientes()
        {
            using (var contexto = new miniERPContext())
            {
                var clientes = contexto.Clientes.ToList(); // Buscando todos os fornecedores cadastrados

                dataGridViewClientes.DataSource = clientes; // Configurando o DataSource para a DataGridView
            }
        }

        private void buttonConsultarCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscarCliente.Text))
            {
                int idCliente;
                if (int.TryParse(textBoxBuscarCliente.Text, out idCliente))
                {
                    using (var contexto = new miniERPContext())
                    {
                        // Consulta o cliente com o ID fornecido
                        var clienteConsultado = contexto.Clientes
                            .FirstOrDefault(c => c.Id == idCliente);

                        if (clienteConsultado != null)
                        {
                            // Limpa o DataSource atual do DataGridView
                            dataGridViewClientes.DataSource = null;

                            // Cria uma nova lista com o cliente consultado e a atribui ao DataSource do DataGridView
                            dataGridViewClientes.DataSource = new List<Cliente> { clienteConsultado };
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID do cliente válido (número inteiro).");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID do cliente para consultar.");
            }
        }

        private void buttonApagarCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscarCliente.Text))
            {
                int idCliente;
                if (int.TryParse(textBoxBuscarCliente.Text, out idCliente))
                {
                    using (var contexto = new miniERPContext())
                    {
                        var clienteParaDeletar = contexto.Clientes.Find(idCliente);

                        if (clienteParaDeletar != null)
                        {
                            // Remove o cliente encontrado do contexto
                            contexto.Clientes.Remove(clienteParaDeletar);
                            contexto.SaveChanges();

                            MessageBox.Show("Cliente removido com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID de cliente válido (número inteiro).");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de cliente para remover.");
            }

            textBoxBuscarCliente.Text = "";
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            DisableTextBoxes();
            MostrarTodosClientes();
            textBoxBuscarCliente.Text = "";
        }

        private void DisableTextBoxes()
        {
            textBoxNameClienteUpdate.Text = "";

            textBoxNameClienteUpdate.Enabled = false;
        }

        private void buttonUpdateCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscarCliente.Text))
            {
                textBoxNameClienteUpdate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de produto para poder editá-lo.");
            }



        }

        private void btnSaveUpdateCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscarCliente.Text))
            {
                int idCliente;
                if (int.TryParse(textBoxBuscarCliente.Text, out idCliente))
                {
                    using (var contexto = new miniERPContext())
                    {
                        var fornecedorParaAtualizar = contexto.Clientes.Find(idCliente);

                        if (fornecedorParaAtualizar != null)
                        {
                            // Atualizar os dados do fornecedor
                            fornecedorParaAtualizar.Nome = textBoxNameClienteUpdate.Text;

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
    }
}
