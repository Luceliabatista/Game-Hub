using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Games.BatalhaNaval.pecas
{
    class Contratorpedeiro
    {
        public static int LinhaInicialContratorpedeiro { get; set; }
        public static int ColunaInicialContratorpedeiro { get; set; }
        public static int LinhaMeioContratorpedeiro { get; set; }
        public static int ColunaMeioContratorpedeiro { get; set; }
        public static int LinhaFinalContratorpedeiro { get; set; }
        public static int ColunaFinalContratorpedeiro { get; set; }
        public static void PosicionandoContratorpedeiro()
        {

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja começar o Contratorpedeiro: ");
            string[] Contratorpedeiro1 = Console.ReadLine().Split(",");
            LinhaInicialContratorpedeiro = int.Parse(Contratorpedeiro1[0]);
            ColunaInicialContratorpedeiro = int.Parse(Contratorpedeiro1[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja por o meio do Contratorpedeiro: ");
            string[] Contratorpedeiro2 = Console.ReadLine().Split(",");
            LinhaMeioContratorpedeiro = int.Parse(Contratorpedeiro2[0]);
            ColunaMeioContratorpedeiro = int.Parse(Contratorpedeiro2[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja terminar o Contratorpedeiro: ");
            string[] Contratorpedeiro3 = Console.ReadLine().Split(",");
            LinhaFinalContratorpedeiro = int.Parse(Contratorpedeiro3[0]);
            ColunaFinalContratorpedeiro = int.Parse(Contratorpedeiro3[1]);
            Console.WriteLine();

        }

    }
}
