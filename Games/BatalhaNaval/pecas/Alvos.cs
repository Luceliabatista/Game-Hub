using GameHub.Games.BatalhaNaval.tabuleiro;

namespace GameHub.Games.BatalhaNaval.pecas
{
   abstract class Alvo
    {
        public Posicao Posicao { get; set; }
        public Navios Navio { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public TabuleiroBTN TabuleiroBTN { get; protected set; }
        public TabuleiroBTN Tab { get; }
        bool[,] mat;

        public Alvo( TabuleiroBTN tab )
        {
            Posicao = null;
            QteMovimentos = 0;
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

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public void DecrementarQteMovimentos()
        {
            QteMovimentos--;
        }

        public bool MovimentoPossivel( Posicao pos ) { return MovimentosPossiveis()[pos.Linha, pos.Coluna]; }
        public abstract bool[,] MovimentosPossiveis();
    }
}


