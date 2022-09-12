using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoaoPedroAlbieroCezar_d3_avaliacao.Interfaces;

namespace JoaoPedroAlbieroCezar_d3_avaliacao.Models
{
    /// <summary>
    /// Classe responsável por manipular o arquivo de texto
    /// </summary>
    internal class Base : IBase
    {
        const string path = "log/usuarios.csv";
        public static void Write_CSV(Usuario user)
        {
            DateTime now = DateTime.Now;
            
        }
    }
}
