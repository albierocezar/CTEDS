using System;
using System.Collections.Generic;
using System.Globalization;
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
        const string path = "log/usuarios.txt";

        /// <summary>
        /// Cria pasta e/ou arquivo caso não exista
        /// </summary>
        private static void CreateFolderFile()
        {
            string folder = path.Split("/")[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        public List<Usuario> ReadAll_txt()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Escreve o id, nome e horario de acesso do usuário
        /// </summary>
        /// <param name="user">usuario que será adicionado</param>
        public static void Write_txt(Usuario user)
        {
            CreateFolderFile();

            DateTime now = DateTime.Now;
            string now_to_string = now.ToString("G", CultureInfo.GetCultureInfo("es-ES")); // dd/mm/yyyy h:m:s
                                                                                           // 
            using (StreamWriter usuarios_CSV = new(path))
            {
                usuarios_CSV.WriteLine($"Id: {user.id.ToString()}");
                usuarios_CSV.WriteLine($"Nome: {user.nome}");
                usuarios_CSV.WriteLine($"Data/Hora de acesso: {now_to_string}");

            }
        }
    }   
}
