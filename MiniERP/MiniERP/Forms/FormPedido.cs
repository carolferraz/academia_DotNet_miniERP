using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            MostrarTodosProdutos();

            //Carrega todos os clientes na comboBox
            using (var contexto = new miniERPContext())
            {
                var clientes = contexto.Clientes.ToList();

                comboBoxClientes.DisplayMember = "Nome";
                comboBoxClientes.ValueMember = "Id";
                comboBoxClientes.DataSource = clientes;
            }
        }

        private void MostrarTodosProdutos()
        {
            using (var contexto = new miniERPContext())
            {
                var produtos = contexto.Produtos.ToList();

                dataGridViewProdutos.DataSource = produtos;
            }
        }

        private void MostrarItensDoPedido()
        {
            using (var contexto = new miniERPContext())
            {
                var produtos = contexto.Pedidos.ToList();

                dataGridViewPedido.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Id",
                    HeaderText = "Id",
                });

                dataGridViewPedido.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TotalItem",
                    HeaderText = "Valor total por item",
                });

                if (dataGridViewPedido.Columns.Contains("FkProdutoNavigation"))
                {
                    dataGridViewPedido.Columns["FkProdutoNavigation"].Visible = false;
                }

                dataGridViewPedido.DataSource = produtos;
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSelecionarProduto.Text) && !string.IsNullOrWhiteSpace(textBoxQuantidade.Text))
            {
                int idProduto;
                if (int.TryParse(textBoxSelecionarProduto.Text, out idProduto))
                {
                    int quantidade;
                    if (int.TryParse(textBoxQuantidade.Text, out quantidade) && quantidade > 0) 
                    {
                        using (var contexto = new miniERPContext())
                        {

                            var produtoConsultado = contexto.Produtos.FirstOrDefault(p => p.Id == idProduto);

                            if (produtoConsultado != null)
                            {
                                Pedido novoPedido = new Pedido();

                                if (comboBoxClientes.SelectedItem != null && comboBoxClientes.SelectedValue != null)
                                {
                                    Cliente clienteSelecionado = (Cliente)comboBoxClientes.SelectedItem;
                                    int clienteId = clienteSelecionado.Id;

                                    novoPedido.FkCliente = clienteId;
                                }
                                novoPedido.FkProduto = produtoConsultado.Id;
                                novoPedido.Quantidade = quantidade;
                                novoPedido.TotalItem = produtoConsultado.Preco * quantidade;
                                novoPedido.Emissao = DateTime.Now;

                                contexto.Pedidos.Add(novoPedido);
                                contexto.SaveChanges();

                                MessageBox.Show("Pedido registrado com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira uma quantidade válida (número inteiro maior que zero).");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID de produto válido (número inteiro).");
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha o ID do produto e a quantidade para fazer um pedido.");
            }
            MostrarItensDoPedido();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            MostrarItensDoPedido();
        }

        private void buttonApagarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSelecionarProduto.Text))
            {
                int idItem;
                if (int.TryParse(textBoxSelecionarProduto.Text, out idItem))
                {
                    using (var contexto = new miniERPContext())
                    {
                        var produtoConsultado = contexto.Pedidos.FirstOrDefault(p => p.Id == idItem);

                        if (produtoConsultado != null)
                        {
                            contexto.Pedidos.Remove(produtoConsultado);
                            contexto.SaveChanges();

                            MessageBox.Show("Item removido.");
                        }
                        else
                        {
                            MessageBox.Show("Item não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID de produto válido (número inteiro).");
                }
            }
        }

        private void LimparPedido()
        {
            using (var contexto = new miniERPContext())
            {
                var todosPedidos = contexto.Pedidos.ToList();

                if (todosPedidos.Any())
                {
                    contexto.Pedidos.RemoveRange(todosPedidos);
                    contexto.SaveChanges();

                    MessageBox.Show("Todos os itens foram removidos.");
                }
                else
                {
                    MessageBox.Show("Não há itens para limpar.");
                }
            }
        }
        private void buttonLimparPedido_Click(object sender, EventArgs e)
        {
            LimparPedido();
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedItem != null)
            {
                Cliente clienteSelecionado = (Cliente)comboBoxClientes.SelectedItem;

                comboBoxClientes.Text = clienteSelecionado.Nome;
            }
            else
            {
                comboBoxClientes.Text = "";
            }

        }

        private void buttonEmitirNF_Click(object sender, EventArgs e)
        {
            using (var contexto = new miniERPContext())
            {
                var pedidos = contexto.Pedidos
                                    .Include("FkProdutoNavigation")
                                    .Include("FkClienteNavigation")
                                    .ToList();

                if (pedidos.Any())
                {
                    var documento = new Document();
                    var nomeArquivo = $"Nota_Fiscal.pdf";

                    using (var stream = new FileStream(nomeArquivo, FileMode.Create))
                    {
                        PdfWriter.GetInstance(documento, stream);
                        documento.Open();

                        foreach (var pedido in pedidos)
                        {
                            documento.Add(new Paragraph($"Pedido ID: {pedido.Id}"));
                            documento.Add(new Paragraph($"Data de Emissão: {pedido.Emissao}"));
                            documento.Add(new Paragraph($"Cliente: {pedido.FkClienteNavigation?.Nome}"));

                            documento.Add(new Paragraph("\nItens do Pedido:"));
                            documento.Add(new Paragraph($"Produto: {pedido.FkProdutoNavigation?.Nome} - Quantidade: {pedido.Quantidade} - Total do Item: {pedido.TotalItem}"));
                        }

                        documento.Close();
                    }

                    MessageBox.Show($"Nota fiscal gerada com sucesso! Salva em {nomeArquivo}");
                }
                else
                {
                    MessageBox.Show("Não há pedidos registrados para gerar a nota fiscal.");
                }
            }
            LimparPedido();
        }
    }
}
