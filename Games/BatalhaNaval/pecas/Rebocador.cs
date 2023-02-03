
using GameHub.Games.BatalhaNaval.tabuleiro;
using GameHub.Games.JogoDeXadrez;

namespace GameHub.Games.BatalhaNaval.pecas
{
    class Rebocador : Alvo
    {
        public Rebocador( TabuleiroBTN tab ) : base(tab) { }

        public static int LinhaInicialRebocador { get; set; }
        public static int ColunaInicialRebocador { get; set; }
        public static int LinhaFinalRebocador { get; set; }
        public static int ColunaFinalRebocador { get; set; }
        public static int LinhaInicialRebocadorO { get; set; }
        public static int ColunaInicialRebocadorO { get; set; }
        public static int LinhaFinalRebocadorO { get; set; }
        public static int ColunaFinalRebocadorO { get; set; }

        
        public static void PosicionandoRebocadorX()
        {

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja começar o rebocador: ");
            string[] Rebocador1 = Console.ReadLine().Split(",");
            LinhaInicialRebocador = int.Parse(Rebocador1[0]);
            ColunaInicialRebocador = int.Parse(Rebocador1[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja terminar o rebocador: ");
            string[] Rebocador2 = Console.ReadLine().Split(",");
            LinhaFinalRebocador = int.Parse(Rebocador2[0]);
            ColunaFinalRebocador = int.Parse(Rebocador2[1]);
            Console.WriteLine();

        }


        public static void PosicionandoRebocadorO()
        {

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja começar o rebocador: ");
            string[] RebocadorO1 = Console.ReadLine().Split(",");
            LinhaInicialRebocadorO = int.Parse(RebocadorO1[0]);
            ColunaInicialRebocadorO = int.Parse(RebocadorO1[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja terminar o rebocador: ");
            string[] RebocadorO2 = Console.ReadLine().Split(",");
            LinhaFinalRebocadorO = int.Parse(RebocadorO2[0]);
            ColunaFinalRebocadorO = int.Parse(RebocadorO2[1]);
            Console.WriteLine();

        }

        private bool PodeMover( Posicao pos )
        {
            Alvo p = Tab.Alvo(pos);
            return p == null;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new(0, 0);

            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }
    }
}