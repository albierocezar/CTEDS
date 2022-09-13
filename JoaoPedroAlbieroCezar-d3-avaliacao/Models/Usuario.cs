using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoPedroAlbieroCezar_d3_avaliacao.Models
{
    internal class Usuario
    {
        public static readonly string email_padrao = "admin@email.com";
        public static readonly string senha_padrao = "admin123";
        public readonly string nome;
        public readonly HashCode id;
        
        public Usuario(string nome)
        {
            this.nome = nome;
            this.id = new HashCode();
        }


    }
}
