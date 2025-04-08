using Dapper;
using MultApps.Models.Entidades;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MultApps.Models.Repository
{
    public class CategoriaRepository
    {
        public string ConnectionString = "Server=localhost; Database = multapps_dev; Uid = root; Pwd = root";

        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO categoria (Nome,Status)
                                   VALUES(@Nome, @Status)";

                var parametros = new DynamicParameters();
                parametros.Add(name: "@Nome", categoria.Nome);
                parametros.Add(name: "@Status", categoria.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public List<Categoria> ListarTodasCategoria()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT * FROM categoria";
                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;


            }
        }

        public Categoria obterCategoroaPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SEELCT id, nome, data_criacao, data_alteracao, status
                                   FROM categoria WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Query<Categoria>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }

        }

        public void AtualizarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = "UPDATE Categoria SET id , nome, data_criacao, data_alteracao, status";
                var parametros = new DynamicParameters();
                var resultado = db.Query(comandoSql, parametros);
             
            }
        }
    }
}
