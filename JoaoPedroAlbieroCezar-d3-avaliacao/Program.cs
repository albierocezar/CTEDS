using JoaoPedroAlbieroCezar_d3_avaliacao.Models;

namespace JoaoPedroAlbieroCezar_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha = string.Empty;
            do
            {
                Console.WriteLine("Seja bem vindo ao sistema, em que podemos ajudar?");
                Console.WriteLine("1 - Acessar");
                Console.WriteLine("2 - Cancelar");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1": //Acessar
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        Console.Write("Senha");
                        string senha = Console.ReadLine();

                        if (email == Usuario.email_padrao && senha == Usuario.senha_padrao) //Validou
                        {
                            Usuario user = new Usuario(nome);
                        }
                        else //erro
                        {
                            Console.WriteLine("Email ou senha incorretos \n\tPor favor, tente novamente.");
                        }
                        break;

                    case "2": //Cancelar

                        break;

                    default:
                        Console.WriteLine("Escolha não é valida");
                        break;
                }
            } while (escolha != "2");
        }
    }
}