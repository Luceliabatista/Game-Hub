
namespace GameHub.Games.BatalhaNaval.pecas
{
    class Rebocador
    {
        public static int LinhaInicialRebocador { get; set; }
        public static int ColunaInicialRebocador { get; set; }
        public static int LinhaFinalRebocador { get; set; }
        public static int ColunaFinalRebocador { get; set; }
        public static void PosicionandoRebocador()
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

    }
}
