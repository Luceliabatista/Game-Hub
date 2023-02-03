
using GameHub.Entities;
using System.Data;

namespace GameHub.Services
{
    class Jogadores
    {
        public static DataRegister PontuacaoX { get; set; }
        public static DataRegister? PontuacaoO { get; set; }
        public static string CpfJogador1 { get; set; }
        public static string CpfJogador2 { get; set; }
        public static DataRegister JogadorDaRodada { get; set; }
        public static DataRegister Jogador1 { get; set; }
        public static DataRegister Jogador2 { get; set; }

        public static List<DataRegister> ContasDeUsuarios = new();

        public static void DefinirJogadores()
        {
            ContasDeUsuarios = SerializeDeserialize.Read<DataRegister>(@"C:\Users\lucel\SharpCoders\GameHub\GameHub\data\jogadores.json");

            Console.WriteLine($"Para iniciarmos o jogo, antes precisamos que defina quem são os usuários jogadores");

            do
            {
                Console.Write($"Digite o CPF do(a) 1ª jogador(a): ");
                CpfJogador1 = Console.ReadLine();
                Jogador1 = ContasDeUsuarios.Find(usuario => usuario.Cpf == CpfJogador1);

                if (Jogador1 == null)
                {
                    Console.WriteLine("Jogador ainda não cadastrado!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Jogador é o: {Jogador1.Name}");
                }

            } while (Jogador1 == null);

            do
            {
                Console.Write($"Digite o CPF do(a) 2º jogador(a): ");
                CpfJogador2 = Console.ReadLine();
                Jogador2 = ContasDeUsuarios.Find(usuario => usuario.Cpf == CpfJogador2);

                if (Jogador2 == null)
                {
                    Console.WriteLine("Jogador ainda não cadastrado!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Jogador é o: {Jogador2.Name}");

                }
            } while (Jogador2 == null);

            JogadorDaRodada = Jogador1;
        }

    }
}
