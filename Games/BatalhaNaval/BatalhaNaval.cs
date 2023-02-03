
using GameHub.Games.BatalhaNaval;
using GameHub.Games.BatalhaNaval.batalha;
using GameHub.Games.BatalhaNaval.pecas;
using GameHub.Services;
using Newtonsoft.Json.Linq;

namespace GameHub.Games.BatalhaNaval
{
    class Game3
    {
        public static void BatalhaNaval()
        {
            try {
                PartidaBTN partida = new();
                Jogadores.DefinirJogadores();
                Console.Clear();
                DefinicaoDePosicoesX.PosicionandoNaviosX();
                DefinicaoDePosicoesO.PosicionandoNaviosO();
                DefinicaoDePosicoesX.ExibirBaseX();
                DefinicaoDePosicoesO.ExibirBaseO();
                Console.WriteLine();

                Console.WriteLine("Para prosseguir, tecle enter..");
                Console.ReadLine();
                Console.Clear();
                while (!partida.Terminada) {
                    try {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Digite a linha e coluna do seu alvo, separando por virgula (ex: 4,5: ): ");
                        Posicao destino = Tela.LerPosicaoBTN().ToPosicao();

                        Console.Clear();

                        Tela.ImprimirTabuleiroBTN(PartidaBTN.Tab);

                        PartidaBTN.RealizaJogada(destino);

                    }
                    catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }


        }
    }
}
