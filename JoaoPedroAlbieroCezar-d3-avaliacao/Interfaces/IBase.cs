using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoaoPedroAlbieroCezar_d3_avaliacao.Models;

namespace JoaoPedroAlbieroCezar_d3_avaliacao.Interfaces
{
    internal interface IBase
    {
        void CreateFolderFile();
        List<string> ReadAll_CSV();
        void Write_CSV(Usuario user);
    }
}
