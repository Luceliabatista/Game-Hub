using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Games.BatalhaNaval.pecas
{
    class PortaAvioes
    {
        public static int LinhaInicialPortaAvioes { get; set; }
        public static int ColunaInicialPortaAvioes { get; set; }
        public static int LinhaMeio1PortaAvioes { get; set; }
        public static int ColunaMeio1PortaAvioes { get; set; }
        public static int LinhaMeio2PortaAvioes { get; set; }
        public static int ColunaMeio2PortaAvioes { get; set; }
        public static int LinhaMeio3PortaAvioes { get; set; }
        public static int ColunaMeio3PortaAvioes { get; set; }
        public static int LinhaFinalPortaAvioes { get; set; }
        public static int ColunaFinalPortaAvioes { get; set; }

        public static void PosicionandoPortaAvioes()
        {

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja começar o PortaAvioes: ");
            string[] PortaAvioes1 = Console.ReadLine().Split(",");
            LinhaInicialPortaAvioes = int.Parse(PortaAvioes1[0]);
            ColunaInicialPortaAvioes = int.Parse(PortaAvioes1[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja por a 2ª parte do PortaAvioes: ");
            string[] PortaAvioes2 = Console.ReadLine().Split(",");
            LinhaMeio1PortaAvioes = int.Parse(PortaAvioes2[0]);
            ColunaMeio1PortaAvioes = int.Parse(PortaAvioes2[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja por a 3ª parte do PortaAvioes: ");
            string[] PortaAvioes3 = Console.ReadLine().Split(",");
            LinhaMeio2PortaAvioes = int.Parse(PortaAvioes3[0]);
            ColunaMeio2PortaAvioes = int.Parse(PortaAvioes3[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja por a 4ª parte do PortaAvioes: ");
            string[] PortaAvioes4 = Console.ReadLine().Split(",");
            LinhaMeio3PortaAvioes = int.Parse(PortaAvioes4[0]);
            ColunaMeio3PortaAvioes = int.Parse(PortaAvioes4[1]);
            Console.WriteLine();

            Console.WriteLine("Em que linha e coluna(nesta ordem)deseja terminar o PortaAvioes: ");
            string[] PortaAvioes5 = Console.ReadLine().Split(",");
            LinhaFinalPortaAvioes = int.Parse(PortaAvioes5[0]);
            ColunaFinalPortaAvioes = int.Parse(PortaAvioes5[1]);
            Console.WriteLine();
        }
    }
}
