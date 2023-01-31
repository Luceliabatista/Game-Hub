using GameHub.Games.BatalhaNaval.tabuleiro;

namespace GameHub.Games.BatalhaNaval.pecas
{
    class Alvo
    {
        public Posicao Posicao { get; set; }
        public Navios Navio { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QteMunicao { get; protected set; }
        public TabuleiroBTN TabuleiroBTN { get; protected set; }
        public TabuleiroBTN Tab { get; }
        bool[,] mat;

        public Alvo( Cor cor, Navios navio, TabuleiroBTN tab )
        {
            Posicao = null;
            Navio = navio;
            Cor = cor;
            QteMunicao = 0;
            Tab = tab;
        }

        public bool ExisteMovimentoPossivel()
        {
            for (int i = 0; i < Tab.Linhas; i++) {
                for (int j = 0; j < Tab.Colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public void IncrementarQteMunicao()
        {
            QteMunicao++;
        }

        public void DecrementarQteMunicao()
        {
            QteMunicao--;
        }

    }
}


