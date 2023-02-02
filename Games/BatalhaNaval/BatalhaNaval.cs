
using GameHub.Games.BatalhaNaval;
using GameHub.Games.BatalhaNaval.batalha;
using GameHub.Games.BatalhaNaval.pecas;
using GameHub.Services;

namespace GameHub.Games.BatalhaNaval
{
    class Game3
    {
        public static void BatalhaNaval()
        {
            try {
                PartidaBTN partida = new();
                Jogadores.DefinirJogadores();

                while (!partida.Terminada) {

                    try {
                        Jogadores.DefinirJogadores();
                        Console.Clear();
                        DefinicaoDePosicoes.PosicionandoNavios();
                        Console.WriteLine();
                        Console.WriteLine();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Digite a linha e coluna do seu alvo, separando por virgula (ex: 4,5: )");
                        Posicao origem = Tela.LerPosicaoBTN().ToPosicao();


                        Console.Clear();
                        
                        Tela.ImprimirTabuleiroBTN(partida.Tab);

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
