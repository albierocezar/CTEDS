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

                        Console.Write("Senha: ");
                        string senha = Console.ReadLine();

                        if (email == Usuario.email_padrao && senha == Usuario.senha_padrao) //Validou
                        {
                            Console.Clear(); //Limpa tela

                            Console.WriteLine("Acesso realizado com sucesso!");

                            Usuario user = new Usuario(nome);
                            Base.Write_txt(user);

                            string escolha_2;
                            Console.WriteLine("1 - Deslogar");
                            Console.WriteLine("2 - Encerrar sistema");
                            escolha_2 = Console.ReadLine();

                            switch (escolha_2)
                            {
                                case "1":
                                    escolha = string.Empty;
                                    break;

                                case "2":
                                    escolha = "2";
                                    break;

                                default:
                                    break;
                            }
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