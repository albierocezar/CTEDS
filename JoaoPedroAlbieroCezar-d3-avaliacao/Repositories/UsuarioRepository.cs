using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoaoPedroAlbieroCezar_d3_avaliacao.Interfaces;

namespace JoaoPedroAlbieroCezar_d3_avaliacao.Repositories
{
    /// <summary>
    /// Repositorio responsável por manipular a entidade usuario, mexendo com a db e o arquivo de texto
    /// </summary>
    internal class UsuarioRepository : IUsuario
    {
        private const string path_txt = "log/usuarios.txt";

    }
}
