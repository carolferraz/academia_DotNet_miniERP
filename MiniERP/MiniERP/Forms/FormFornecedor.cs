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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            using (var contexto = new miniERPContext())
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Nome = textBoxNomeFornecedor.Text;

                contexto.Fornecedores.Add(fornecedor);
                contexto.SaveChanges();

                MessageBox.Show("Fornecedor adicionado!");
            }

            textBoxNomeFornecedor.Text = "";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DisableTextBoxes();
            MostrarTodosFornecedores();
        }

        private void MostrarTodosFornecedores()
        {
            using (var contexto = new miniERPContext())
            {
                var fornecedores = contexto.Fornecedores.ToList();

                dataGridViewFornecedores.DataSource = fornecedores;

                dataGridViewFornecedores.Columns["Produtos"].Visible = false;
            }
        }

        private void buttonConsultarFornecedor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscarFornecedor.Text))
            {
                int idFornecedor;
                if (int.TryParse(textBoxBuscarFornecedor.Text, out idFornecedor))
                {
                    using (var contexto = new miniERPContext())
                    {
                        // Consulta o fornecedor com o ID fornecido
                        var fornecedorConsultado = contexto.Fornecedores
                            .FirstOrDefault(f => f.Id == idFornecedor);

                        if (fornecedorConsultado != null)
                        {
                            dataGridViewFornecedores.DataSource = null;

                            dataGridViewFornecedores.DataSource = new List<Fornecedor> { fornecedorConsultado };
                        }
                        else
                        {
                            MessageBox.Show("Fornecedor não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID de fornecedor válido (número inteiro).");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de fornecedor para consultar.");
            }
        }

        private void buttonApagarFornecedor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscarFornecedor.Text))
            {
                int idFornecedor;
                if (int.TryParse(textBoxBuscarFornecedor.Text, out idFornecedor))
                {
                    using (var contexto = new miniERPContext())
                    {
                        var fornecedorParaDeletar = contexto.Fornecedores.Find(idFornecedor);

                        if (fornecedorParaDeletar != null)
                        {
                            // Remove o fornecedor encontrado do contexto
                            contexto.Fornecedores.Remove(fornecedorParaDeletar);
                            contexto.SaveChanges();

                            MessageBox.Show("Fornecedor removido com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Fornecedor não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID de fornecedor válido (número inteiro).");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de fornecedor para remover.");
            }

            textBoxBuscarFornecedor.Text = "";
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            DisableTextBoxes();
            MostrarTodosFornecedores();
            textBoxBuscarFornecedor.Text = "";
        }

        private void DisableTextBoxes()
        {
            textBoxNameFornecedorUpdate.Text = "";

            textBoxNameFornecedorUpdate.Enabled = false;
        }

        private void buttonUpdateFornecedor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscarFornecedor.Text))
            {
                textBoxNameFornecedorUpdate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de produto para poder editá-lo.");
            }



        }

        private void btnSaveUpdateFornecedor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBuscarFornecedor.Text))
            {
                int idFornecedor;
                if (int.TryParse(textBoxBuscarFornecedor.Text, out idFornecedor))
                {
                    using (var contexto = new miniERPContext())
                    {
                        var fornecedorParaAtualizar = contexto.Fornecedores.Find(idFornecedor);

                        if (fornecedorParaAtualizar != null)
                        {
                            // Atualizar os dados do fornecedor
                            fornecedorParaAtualizar.Nome = textBoxNameFornecedorUpdate.Text;

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
