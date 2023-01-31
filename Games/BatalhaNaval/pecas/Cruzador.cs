using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Games.BatalhaNaval.pecas
{
    class Cruzador
    {
        public static int LinhaInicialCruzador { get; set; }
        public static int ColunaInicialCruzador { get; set; }
        public static int LinhaMeio1Cruzador { get; set; }
        public static int ColunaMeio1Cruzador { get; set; }
        public static int LinhaMeio2Cruzador { get; set; }
        public static int ColunaMeio2Cruzador { get; set; }
        public static int LinhaFinalCruzador { get; set; }
        public static int ColunaFinalCruzador { get; set; }
        public static void PosicionandoCruzador()
        {
            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja começar o Cruzador: ");
            string[] Cruzador1 = Console.ReadLine().Split(",");
            LinhaInicialCruzador = int.Parse(Cruzador1[0]);
            ColunaInicialCruzador = int.Parse(Cruzador1[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja por a 2ª parte do Cruzador: ");
            string[] Cruzador2 = Console.ReadLine().Split(",");
            LinhaMeio1Cruzador = int.Parse(Cruzador2[0]);
            ColunaMeio1Cruzador = int.Parse(Cruzador2[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja por a 3ª parte do Cruzador: ");
            string[] Cruzador3 = Console.ReadLine().Split(",");
            LinhaMeio2Cruzador = int.Parse(Cruzador3[0]);
            ColunaMeio2Cruzador = int.Parse(Cruzador3[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja terminar o Cruzador: ");
            string[] Cruzador4 = Console.ReadLine().Split(",");
            LinhaFinalCruzador = int.Parse(Cruzador4[0]);
            ColunaFinalCruzador = int.Parse(Cruzador4[1]);
            Console.WriteLine();
        }
    }
}
