
using GameHub.Entities;
using System.Data;

namespace GameHub.Services
{
    class Jogadores
    {
        public static DataRegister PontuacaoX { get; set; }
        public static DataRegister? PontuacaoO { get; set; }
        public static string CpfJogadorX { get; set; }
        public static string CpfJogadorO { get; set; }
        public static DataRegister JogadorDaRodada { get; set; }
        public static DataRegister JogadorX { get; set; }
        public static DataRegister JogadorO { get; set; }

        public static List<DataRegister> ContasDeUsuarios = new();

        public static void DefinirJogadores()
        {
            ContasDeUsuarios = SerializeDeserialize.Read<DataRegister>(@"C:\Users\lucel\SharpCoders\GameHub\GameHub\data\jogadores.json");

            Console.WriteLine($"Para iniciarmos o jogo, antes precisamos que defina quem são os usuários jogadores");

            do {
                Console.Write($"Digite o CPF do(a) jogador(a) X: ");
                CpfJogadorX = Console.ReadLine();
                JogadorX = ContasDeUsuarios.Find(usuario => usuario.Cpf == CpfJogadorX);

                if (JogadorX == null) {
                    Console.WriteLine("Jogador X ainda não cadastrado!");
                    break;
                }
                else {
                    Console.WriteLine($"Jogador X é o: {JogadorX.Name}");
                }

            } while (JogadorX == null);

            do {
                Console.Write($"Digite o CPF do(a) jogador(a) O: ");
                CpfJogadorO = Console.ReadLine();
                JogadorO = ContasDeUsuarios.Find(usuario => usuario.Cpf == CpfJogadorO);

                if (JogadorO == null) {
                    Console.WriteLine("Jogador O ainda não cadastrado!");
                    break;
                }
                else {
                    Console.WriteLine($"Jogador X é o: {JogadorO.Name}");

                }
            } while (JogadorO == null);

            JogadorDaRodada = JogadorX;
        }

    }
}
