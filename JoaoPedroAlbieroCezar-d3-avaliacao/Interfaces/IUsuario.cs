using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoaoPedroAlbieroCezar_d3_avaliacao.Models;

namespace JoaoPedroAlbieroCezar_d3_avaliacao.Interfaces
{
    internal interface IUsuario
    {   
        /// <summary>
        /// Adiciona um usuário na db
        /// </summary>
        /// <param name="newUsuario">Usuario que será adicionado na db</param>
        void Create_db(Usuario newUsuario);

        /// <summary>
        /// Retorna uma lista com todos os usuários presentes na db
        /// </summary>
        /// <returns> </returns>
        List<Usuario> ReadAll_db();

        /// <summary>
        /// Edita um produto existente
        /// </summary>
        /// <param name="usuario"></param>
        void Update_db(Usuario usuario);

        /// <summary>
        /// Deleta o usuario com essa ID
        /// </summary>
        /// <param name="idProduct"></param>
        void Delete_db(string idProduct);

        string db_to_string();

        
    }
}
