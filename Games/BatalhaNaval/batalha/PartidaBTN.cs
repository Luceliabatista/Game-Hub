
using GameHub.Entities;
using GameHub.Games.BatalhaNaval.pecas;
using GameHub.Games.BatalhaNaval.batalha;
using GameHub.Games.BatalhaNaval.tabuleiro;

namespace GameHub.Games.BatalhaNaval.batalha
{
    class PartidaBTN
    {
        public static TabuleiroBTN Tab { get; private set; }
        public static int Turno { get; private set; }
        public static DataRegister JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private readonly HashSet<Alvo> Alvo;
        private static HashSet<Alvo> Capturadas;
        public static string CpfJogador1 { get; set; }
        public static string CpfJogador2 { get; set; }
        public static DataRegister JogadorDaRodada { get; set; }
        public static DataRegister Jogador1 { get; set; }
        public static DataRegister Jogador2 { get; set; }

        public static List<DataRegister> ContasDeUsuarios = new();


        public PartidaBTN()
        {
            Tab = new TabuleiroBTN(8, 8);
            Turno = 1;
            Terminada = false;
            Alvo = new HashSet<Alvo>();
            Capturadas = new HashSet<Alvo>();
        }

        public static Alvo ExecutaMovimento(Posicao destino )
        {
            Alvo p = Tab.RetirarAlvo(destino);
            p.IncrementarQteMovimentos();
            Alvo alvoCapturado = Tab.RetirarAlvo(destino);
            //Tab.AtingirAlvo(p, destino);
            if (alvoCapturado != null)
            {
                Capturadas.Add(alvoCapturado);
            }

            return alvoCapturado;
        }

        public static void RealizaJogada( Posicao destino )
        {
            if (JogadorDaRodada == Jogador1) {
                if( destino.Linha != Rebocador.LinhaInicialRebocadorO && destino.Coluna != Rebocador.ColunaInicialRebocadorO ||  destino.Linha !=  Rebocador.LinhaFinalRebocadorO &&  destino.Coluna != Rebocador.ColunaFinalRebocadorO) {
                    Console.Write(" X ");
                }
                else {
                    
                }
            }
            //else {
            //    if (destino != Rebocador.LinhaInicialRebocador && destino != Rebocador.ColunaInicialRebocador || destino != Rebocador.LinhaFinalRebocador && destino != Rebocador.ColunaFinalRebocador)
            //}
            //Alvo alvoCapturado = ExecutaMovimento(destino);

            Turno++;
            MudaJogador();
        }

        //public static void ValidarAlvo(Posicao destino )
        //{
        //    if (Tab.Alvo(destino) == Alvo) {
        //        return;
        //    }
        //    throw new TabuleiroException("Posição de destino inválida!");
        //}

        //VALIDAR SE TENHO MUNICAO P ATIRAR



        public static void MudaJogador()
        {
            JogadorAtual = JogadorDaRodada == Jogador1 ? Jogador2 : Jogador1;
        }

        public HashSet<Alvo> AlvoCapturados(Cor cor)
        {
            HashSet<Alvo> aux = new();
            foreach (Alvo x in Capturadas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Alvo> AlvoEmJogo(Cor cor)
        {
            HashSet<Alvo> aux = new();
            foreach (Alvo x in Alvo)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(AlvoCapturados(cor));
            return aux;
        }

        private static Cor Adversaria(Cor cor)
        {
            if (cor == Cor.Branca)
            {
                return Cor.Preta;
            }
            else
            {
                return Cor.Branca;
            }
        }



    }
}

