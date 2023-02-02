using GameHub.Entities;
using GameHub.Games.BatalhaNaval.pecas;
using GameHub.Games.BatalhaNaval.tabuleiro;
using GameHub.Services;

namespace GameHub.Games.BatalhaNaval.batalha
{
    class Tela
    {
        public static DataRegister JogadorDaRodada { get; set; }
        public static DataRegister JogadorX { get; set; }
        public static DataRegister JogadorO { get; set; }

        public static List<DataRegister> ContasDeUsuarios = new();

        public static void ImprimirPartida( PartidaBTN partida )
        {
            Console.WriteLine($"Esta é a base do(a) {Jogadores.JogadorO.Name}, que você está atacando agora");

            ImprimirTabuleiroBTN(partida.Tab);
            Console.WriteLine();
            ImprimirAlvossCapturados(partida);

            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.Turno);
            if (!partida.Terminada) {
                Console.WriteLine($"Aguardando a jogada de {Jogadores.JogadorDaRodada.Name}:");
            }
            else {
                Console.WriteLine("FIM DE JOGO!!");
                Console.WriteLine("VENCEDOR: " + partida.JogadorAtual);
                if (Jogadores.JogadorX == Jogadores.JogadorDaRodada) {
                    Jogadores.JogadorX.Pontuacao++;
                    Jogadores.JogadorX.Save();
                }
                else {
                    Jogadores.JogadorO.Pontuacao++;
                    Jogadores.JogadorO.Save();
                }

            }
        }

        public static void ImprimirAlvossCapturados( PartidaBTN partida )
        {

            Console.WriteLine("Navios afundados: ");
            Console.Write($"Jogador {Jogadores.JogadorX.Name}: ");
            ImprimirConjunto(partida.AlvoCapturados(Cor.Branca));
            Console.WriteLine();
            Console.Write($"Jogador {Jogadores.JogadorO.Name}: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partida.AlvoCapturados(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void ImprimirConjunto( HashSet<Alvo> conjunto )
        {
            Console.Write("[");
            foreach (Alvo x in conjunto) {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static void ImprimirTabuleiroBTN( TabuleiroBTN tab )
        {
            for (int i = 0; i < tab.Linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++) {
                    ImprimirAlvos(tab.Alvo(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  0  1  2  3  4  5  6  7");
        }

        public static void ImprimirTabuleiroBTN( TabuleiroBTN tab, bool[,] posicoesPossiveis )
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.Linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++) {
                    if (posicoesPossiveis[i, j]) {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirAlvos(tab.Alvo(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  0  1  2  3  4  5  6  7");
            Console.BackgroundColor = fundoOriginal;

        }


        public static PosicaoBTN LerPosicaoBTN()
        {
            string[] s = Console.ReadLine().Split(",");
            int coluna = int.Parse(s[0]);
            int linha = int.Parse(s[1] + "");

            return new PosicaoBTN(coluna, linha);
        }
        public static void ImprimirAlvos( Alvo peca )
        {
            if (peca == null) {
                Console.Write("-  ");
            }
            else {
                if (peca.Cor == Cor.Branca) {
                    Console.Write(peca);
                }
                else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

    }
}
