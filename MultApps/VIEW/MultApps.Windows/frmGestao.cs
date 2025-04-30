using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using MultApps.Models.Sevices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class frmGestao : Form
    {
        public frmGestao()
           {
                InitializeComponent();
                var categoria = new[] { "Todas", "Eletrônicos", "Alimentos e Bebidas", "Utensílios domésticos", "Brinquedos", "Materiais Escolares", "Calçados", "Roupas" };
                var status = new[] { "Todos", "Ativos", "Inativos" };
                cmbPreco.Items.AddRange(categoria);
                cmbStatus.Items.AddRange(status);

                cmbStatus.SelectedIndex = 0;
                cmbPreco.SelectedIndex = 0;
            }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //1 Passo pegar os dados da tela.
            //try para capturar erros de conversão de valores.
            try
            {


                var produto = new Produto();
                produto.nome = txtNome.Text;
                produto.descricao = txtDescricao.Text;
                produto.imagem = txtEstoque.Text;
                produto.
                produto.Status = (StatusEnum)cmbStatus.SelectedIndex;

                //2 Passo criar o objeto de repositório.
                var usuarioRepository = new UsuarioRepository();

                //3 Passo chamar o método de cadastro.
                var sucesso = usuarioRepository.CadastrarUsuario(produto);

                if (sucesso)
                {
                    MessageBox.Show($"Usuário {produto.nome} cadastrado com sucesso!");
                    CarregarTodosUsuarios();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar o usuário {produto.nome}");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }



        private bool TemCamposEmBranco()
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Campo Nome é obrigatório");
                    txtNome.Focus();
                    return true;
                }

                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    MessageBox.Show("Campo Descrição é obrigatório");
                    txtDescricao.Focus();
                    return true;
                }

                if (string.IsNullOrEmpty(txtPreco.Text))
                {
                    MessageBox.Show("Campo Preco é obrigatório");
                    txtPreco.Focus();
                    return true;
                }

            if (string.IsNullOrEmpty(txtEstoque.Text))
            {
                MessageBox.Show("Campo Estoque é obrigatório");
                txtEstoque.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtImagem.Text))
            {
                MessageBox.Show("Campo Imagem é obrigatório");
                txtImagem.Focus();
                return true;
            }

            if (cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Campo Status é obrigatório");
                    cmbStatus.Focus();
                    return true;
                }
                return false;
            }

            private void FrmUsuarios_Load(object sender, EventArgs e)
            {
                CarregarTodosProdutos();
            }

            private void CarregarTodosProdutos()
            {
                var produtoRepository = new ProdutoRepository();

                var listarProdutos = produtoRepository.ListarProdutos();
                dataGridView1.DataSource = listarProdutos;
            }

            private void LimparCampos()
            {
                txtDescricao.Clear();
                txtEstoque.Clear();
                txtNome.Clear();
                txtImagem.Clear();
                txtPreco.Clear();
                cmbStatus.SelectedIndex = -1;

            }


            private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0)
                {
                    MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                    return;
                }

                // Obtenha a linha selecionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Obtenha o ID da categoria da linha selecionada
                var produtoId = (int)row.Cells[0].Value;

                // Use o método ObterCategoriaPorId para buscar os dados da categoria no banco de dados
                var usuarioRepository = new UsuarioRepository();
                var usuario = usuarioRepository.ObterUsuarioPorId(produtoId);

                if (produto == null)
                {
                    MessageBox.Show($"Categoria: #{produtoId} não encontrada");
                    return;
                }
                // Preencha os campos de edição com os dados obtidos
                txtNome.Text = usuario.Nome;
                txtDescricao.Text = produto.Descricao;
                txtEstoque.Text = usuario.Email;
                txtPreco.Text =produto.Preco;
                txtImagem.Text produto.Imagem;
                cmbStatus.SelectedIndex = (int)produto.Status;

                btnSalvar.Text = "Salvar alterações";
            }

        private void cmbStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var produtoRepositorio = new ProdutoRepository();
            switch (cmbPreco.SelectedIndex)
            {
                case 0:
                    CarregarTodosUsuarios();
                    break;

                case 1:
                    var produtoAtivos = produtoRepositorio.ListarProdutosPorStatus(1);
                    dataGridView1.DataSource = produtoAtivos;
                    break;

                case 2:
                    var usuarioInativos = produtoRepositorio.ListarProdutosPorStatus(0);
                    dataGridView1.DataSource = produtoInativos;
                    break;

            }
        }
    }
    }

