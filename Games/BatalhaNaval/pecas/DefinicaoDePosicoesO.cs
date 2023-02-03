using GameHub.Services;

namespace GameHub.Games.BatalhaNaval.pecas
{
    class DefinicaoDePosicoesO
    {
        public static int LinhaInicialRebocadorO { get; set; }
        public static int ColunaInicialRebocadorO { get; set; }
        public static int LinhaFinalRebocadorO { get; set; }
        public static int ColunaFinalRebocadorO { get; set; }
        public static void PosicionandoNaviosO()
        {
            Console.Clear();
            Console.WriteLine("Agora é a vez de preparar a base de " + Jogadores.Jogador2.Name);
            Console.WriteLine("Seus navios são: 1 PortaAvioes, 1 Cruzador, 1 Contratorpedeiro, 1 Rebocador\n");

            Console.WriteLine("Começaremos posicionando o REBOCADOR\n");

            Console.WriteLine("Utilizando números de 0 a 7, e os separando por virgula (ex.: 1,2) , informe:\n");


            //Rebocador
            Rebocador.PosicionandoRebocadorO();

            //Contratorpedeiro
            Contratorpedeiro.PosicionandoContratorpedeiro();

            //Cruzador
            Cruzador.PosicionandoCruzador();

            //PortaAvioes
            PortaAvioes.PosicionandoPortaAvioes();


            Console.WriteLine();
        }
        public static void ExibirBaseO()
        {
            Console.WriteLine();
            Console.WriteLine($"Esta é sua base {Jogadores.Jogador2.Name}");
            for (int a = 0; a < 8; a++)
            {
                Console.Write(8 - a + " ");
                for (int b = 0; b < 8; b++)
                {
                    if (a == Rebocador.LinhaInicialRebocadorO && b == Rebocador.ColunaInicialRebocadorO || a == Rebocador.LinhaFinalRebocadorO && b == Rebocador.ColunaFinalRebocadorO)
                    {
                        Console.Write("R  ");
                    }
                    else if (a == Contratorpedeiro.LinhaInicialContratorpedeiro && b == Contratorpedeiro.ColunaInicialContratorpedeiro || a == Contratorpedeiro.LinhaMeioContratorpedeiro && b == Contratorpedeiro.ColunaMeioContratorpedeiro || a == Contratorpedeiro.LinhaFinalContratorpedeiro && b == Contratorpedeiro.ColunaFinalContratorpedeiro)
                    {
                        Console.Write("Ct ");
                    }
                    else if (a == Cruzador.LinhaInicialCruzador && b == Cruzador.ColunaInicialCruzador || a == Cruzador.LinhaMeio1Cruzador && b == Cruzador.ColunaMeio1Cruzador || a == Cruzador.LinhaMeio2Cruzador && b == Cruzador.ColunaMeio2Cruzador || a == Cruzador.LinhaFinalCruzador && b == Cruzador.ColunaFinalCruzador)
                    {
                        Console.Write("Cr ");
                    }
                    else if (a == PortaAvioes.LinhaInicialPortaAvioes && b == PortaAvioes.ColunaInicialPortaAvioes || a == PortaAvioes.LinhaMeio1PortaAvioes && b == PortaAvioes.ColunaMeio1PortaAvioes || a == PortaAvioes.LinhaMeio2PortaAvioes && b == PortaAvioes.ColunaMeio2PortaAvioes || a == PortaAvioes.LinhaMeio3PortaAvioes && b == PortaAvioes.ColunaMeio3PortaAvioes || a == PortaAvioes.LinhaFinalPortaAvioes && b == PortaAvioes.ColunaFinalPortaAvioes)
                    {
                        Console.Write("Pa ");
                    }
                    else
                    {
                        Console.Write("-  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
