using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoaoPedroAlbieroCezar_d3_avaliacao.Interfaces;
using JoaoPedroAlbieroCezar_d3_avaliacao.Models;

namespace JoaoPedroAlbieroCezar_d3_avaliacao.Repositories
{
    /// <summary>
    /// Repositorio responsável por manipular a entidade usuario, mexendo com a db e o arquivo de texto
    /// </summary>
    internal class UsuarioRepository : IUsuario
    {
        private readonly string stringConexao = "Server=MP\\SQLEXPRESS; Initial Catalog=Catalog; User id=???; pwd=???;";

        public void Create_db(Usuario newUsuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ReadAll_db()
        {
            throw new NotImplementedException();
        }

        public void Update_db(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Delete_db(string idProduct)
        {
            throw new NotImplementedException();
        }

        public string db_to_string()
        {
            throw new NotImplementedException();
        }
    }
}
