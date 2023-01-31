
using GameHub.Games.BatalhaNaval.tabuleiro;

namespace GameHub.Games.BatalhaNaval.batalha
{
    class PosicaoBTN
    {
        public int Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoBTN( int coluna, int linha )
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
