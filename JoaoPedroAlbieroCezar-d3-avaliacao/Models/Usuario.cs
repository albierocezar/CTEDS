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
        public readonly Guid id;
        
        public Usuario(string nome)
        {
            this.nome = nome;
            this.id = Guid.NewGuid();
        }

        public Usuario(string id, string nome)
        {
            this.nome = nome;
            this.id = Guid.Parse(id);
            this.id = Guid.Parse(id);
        }
                    
        public void ToString()
        {
            Console.WriteLine($"\tId: {id}");
            Console.WriteLine($"Nome: {nome}");
        }

    }
}
