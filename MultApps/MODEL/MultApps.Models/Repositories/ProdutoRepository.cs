using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositories
{
    public class ProdutoRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=";


        public bool CadastrarProduto(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO PRODUTO (nome, status)
                                   VALUES(@Nome, @Status )";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Status", produto.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public bool AtualizarProduto(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                //Colocar o comando SQL que atualiza dados na tabela.
                var comandoSql = @"UPDATE produto
                                   SET nome = @Nome, status = @Status
                                   WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", produto.Id);
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Status", produto.Status);

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }

        public bool DeletarProduto(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM produto WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;

            }

        }

        public List<Produto> ListarTodasProdutos()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_criacao AS DataCadastro, data_alteracao AS DataAlteracao, status
                                   FROM produto";
                var resultado = db.Query<Produto>(comandoSql).ToList();
                return resultado;
            }
        }

        public Produto ObterProdutoPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id,  nome, data_criacao, data_alteracao, status
                                   FROM produto WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Produto>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }
        }
        public DataTable ListarProdutos()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          categoria_id AS CategoriaId,
                                          nome AS Nome,
                                          preco AS Preco,
                                          quantidade_estoque AS Estoque,
                                          data_cadastro AS DataCadastro,
                                          data_alteracao AS DataAlteracao,
                                   FROM produto";
                var produtos = db.Query<Produto>(comandoSql).ToList();
       
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("CategoriaId", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Preco", typeof(decimal));
                dataTable.Columns.Add("Estoque", typeof(int));
                dataTable.Columns.Add("Descricao", typeof(string));
                dataTable.Columns.Add("Data Cadastro", typeof(DateTime));
                dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                foreach (var produto in produtos)
                {
                    dataTable.Rows.Add(produto.Id,
                        produto.CategoriaId,
                        produto.Nome,
                        produto.Preco,
                        produto.Estoque,
                        produto.Descricao,
                         produto.DataCriacao,
                         produto.DataAlteracao);
                }
                return dataTable;
            }
        }

        public DataTable ListarProdutosPorStatus(int status)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          categoria_id AS CategoriaId,
                                          nome AS Nome,
                                          preco AS Preco,
                                          quantidade_estoque AS Estoque,
                                          data_cadastro AS DataCadastro,
                                          data_alteracao AS DataAlteracao,
                                   FROM produto
                                   WHERE status = @Status";

                var parametros = new DynamicParameters();
                parametros.Add("@Status", status);

                var produtos = db.Query<Produto>(comandoSql, parametros).ToList();
                // Converte a lista de usuários para um DataTable
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("CategoriaId", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Preco", typeof(decimal));
                dataTable.Columns.Add("Estoque", typeof(int));
                dataTable.Columns.Add("Descricao", typeof(string));
                dataTable.Columns.Add("Data Cadastro", typeof(DateTime));
                dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                foreach (var produto in produtos)
                {
                    dataTable.Rows.Add(produto.Id,
                       produto.CategoriaId,
                       produto.Nome,
                       produto.Preco,
                       produto.Estoque,
                       produto.Descricao,
                        produto.DataCriacao,
                        produto.DataAlteracao);
                }
                return dataTable;
            }
        }

    }
}

