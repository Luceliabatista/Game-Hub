
using GameHub.Entities;
using GameHub.Games.BatalhaNaval.pecas;
using GameHub.Games.BatalhaNaval.batalha;
using GameHub.Games.BatalhaNaval.tabuleiro;

namespace GameHub.Games.BatalhaNaval.batalha
{
    class PartidaBTN
    {
        public TabuleiroBTN Tab { get; private set; }
        public int Turno { get; private set; }
        public DataRegister JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private readonly HashSet<Alvo> Alvo;
        private readonly HashSet<Alvo> Capturadas;
        public static string CpfJogadorX { get; set; }
        public static string CpfJogadorO { get; set; }
        public static DataRegister JogadorDaRodada { get; set; }
        public static DataRegister JogadorX { get; set; }
        public static DataRegister JogadorO { get; set; }

        public static List<DataRegister> ContasDeUsuarios = new();


        public PartidaBTN()
        {
            Tab = new TabuleiroBTN(8, 8);
            Turno = 1;
            Terminada = false;
            Alvo = new HashSet<Alvo>();
            Capturadas = new HashSet<Alvo>();
        }

        public Alvo ExecutaMovimento( Posicao origem, Posicao destino )
        {
            Alvo p = Tab.RetirarAlvo(origem);
            p.IncrementarQteMunicao();
            Alvo alvoCapturado = Tab.RetirarAlvo(destino);
            Tab.AtingirAlvo(p, destino);
            if (alvoCapturado != null) {
                Capturadas.Add(alvoCapturado);
            }

            return alvoCapturado;
        }

        public void RealizaJogada( Posicao origem, Posicao destino )
        {
            Alvo alvoCapturado = ExecutaMovimento(origem, destino);

            Turno++;
            MudaJogador();
        }

        private void DesfazMovimento( Posicao origem, Posicao destino, Alvo alvoCapturado )
        {
            Alvo p = Tab.RetirarAlvo(destino);
            p.DecrementarQteMunicao();
            if (alvoCapturado != null) {
                Tab.AtingirAlvo(alvoCapturado, destino);
                Capturadas.Remove(alvoCapturado);
            }
            Tab.AtingirAlvo(p, origem);
        }

        //VALIDAR SE TENHO MUNICAO P ATIRAR



        private void MudaJogador()
        {
            JogadorAtual = JogadorDaRodada == JogadorX ? JogadorO : JogadorX;
        }

        public HashSet<Alvo> AlvoCapturados( Cor cor )
        {
            HashSet<Alvo> aux = new();
            foreach (Alvo x in Capturadas) {
                if (x.Cor == cor) {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Alvo> AlvoEmJogo( Cor cor )
        {
            HashSet<Alvo> aux = new();
            foreach (Alvo x in Alvo) {
                if (x.Cor == cor) {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(AlvoCapturados(cor));
            return aux;
        }

        private static Cor Adversaria( Cor cor )
        {
            if (cor == Cor.Branca) {
                return Cor.Preta;
            }
            else {
                return Cor.Branca;
            }
        }


    
    }
}

