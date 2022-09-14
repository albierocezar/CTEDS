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
        void Create_db(Usuario newUsuario);

        void PrintAll();

        void Update_db(Usuario usuario);

        void Delete_db(string idProduct);

        string db_to_string();

        
    }
}
