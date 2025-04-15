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
    public class UsuarioRepositories
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=SuperSenha@10";


        public bool CadastrarUsuario(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO categoria (nome, status)
                                   VALUES(@Nome, @Status )";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public bool AtualizarUsuarios(Usuarios usuarios)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                //Colocar o comando SQL que atualiza dados na tabela.
                var comandoSql = @"UPDATE categoria
                                   SET nome = @Nome, status = @Status
                                   ";

                var parametros = new DynamicParameters();
                
                parametros.Add("@Nome", usuarios.Nome);
                parametros.Add("@Status", usuarios.Status);

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }

        public bool DeletarCategoria(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM categoria WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;

            }

        }

        public List<Categoria> ListarTodasCategorias()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_criacao AS DataCadastro, data_alteracao AS DataAlteracao, status
                                   FROM categoria";
                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;
            }
        }

        public Categoria ObterCategoriaPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_criacao, data_alteracao, status
                                   FROM categoria WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Categoria>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }
        }
    }
}
}
