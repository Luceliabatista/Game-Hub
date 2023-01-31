
using GameHub.Games.BatalhaNaval.pecas;

namespace GameHub.Games.BatalhaNaval.tabuleiro
{
    class TabuleiroBTN 
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private readonly Alvo[,] Alvos;

        public TabuleiroBTN( int linhas, int colunas )
        {
            Linhas = linhas;
            Colunas = colunas;
            Alvos = new Alvo[linhas, colunas];
        }

        public Alvo Alvo( int linha, int coluna )
        {
            return Alvos[linha, coluna];
        }
        public Alvo Alvo( Posicao pos )
        {
            return Alvos[pos.Linha, pos.Coluna];
        }

        public bool AlvoAtingigo( Posicao pos )
        {
            ValidarPosicao(pos);
            return Alvo(pos) != null;
        }

        public void AtingirAlvo( Alvo p, Posicao pos )
        {
            if (AlvoAtingigo(pos)) {
                throw new TabuleiroException("Este alvo já foi atingido!");
            }
            Alvos[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
        public Alvo RetirarAlvo( Posicao pos )
        {
            if (Alvo(pos) == null) {
                return null;
            }
            Alvo aux = Alvo(pos);
            aux.Posicao = null;
            Alvos[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool PosicaoValida( Posicao pos )
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas) {
                return false;
            }
            return true;
        }
        public void ValidarPosicao( Posicao pos )
        {
            if (!PosicaoValida(pos)) {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
