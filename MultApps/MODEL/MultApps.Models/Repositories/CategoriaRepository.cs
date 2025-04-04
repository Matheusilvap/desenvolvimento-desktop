﻿using Dapper;
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
                parametros.Add(name:"@Nome", categoria.Nome);
                parametros.Add(name:"@Status", categoria.Status);
                
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
    }
}
