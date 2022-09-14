using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoaoPedroAlbieroCezar_d3_avaliacao.Interfaces;
using JoaoPedroAlbieroCezar_d3_avaliacao.Models;
using System.Data.SqlClient;

namespace JoaoPedroAlbieroCezar_d3_avaliacao.Repositories
{
    /// <summary>
    /// Repositorio responsável por manipular a entidade usuario, mexendo com a db 
    /// </summary>
    internal class UsuarioRepository : IUsuario
    {
        private readonly string stringConexao = "Server=labsoft.pcs.usp.br; Initial Catalog=db_13; User id=usuario_13; pwd=38779094856";

        /// <summary>
        /// Adiciona um usuario na tabela da db
        /// </summary>
        /// <param name="newUsuario"></param>
        public void Create_db(Usuario newUsuario)
        {
            using (SqlConnection con = new SqlConnection(stringConexao)) //Gera uma conexão no server passado na string
            {
                //SQL Injection
                string queryInsert = "INSERT INTO Users ([UserID], [Name], [Email], [Password]) VALUES (@UserID, @Name, @Email, @Password)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con)) //Roda o comando passado na queryInsert na conexão con
                {
                    cmd.Parameters.AddWithValue("@UserID", newUsuario.id);
                    cmd.Parameters.AddWithValue("@Name", newUsuario.nome);
                    cmd.Parameters.AddWithValue("@Email", Usuario.email_padrao);
                    cmd.Parameters.AddWithValue("@Password", Usuario.senha_padrao);

                    con.Open();

                    cmd.ExecuteNonQuery();

                }
            }
        }

        /// <summary>
        /// Imprime todos os usuários da database no terminal
        /// </summary>
        public void PrintAll()
        {
            List<Usuario> users = new();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT * FROM Users";
                con.Open();
                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario user = new Usuario(reader["UserID"].ToString(), reader["Name"].ToString());
                        users.Add(user);
                    }
                }
            }

            foreach(var user in users)
            {
                user.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <exception cref="NotImplementedException"></exception>
            public void Update_db(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user_ID"></param>
        public void Delete_db(string user_ID)
        {
                using (SqlConnection con = new SqlConnection(stringConexao))
                {
                    string queryDelete = $"DELETE FROM Users WHERE UserID = '{user_ID}';";

                    using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

        public string db_to_string()
        {
            throw new NotImplementedException();
        }
    }
}
