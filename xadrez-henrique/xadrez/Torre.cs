using System;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override bool[,] movimentosPossiveis()
        {
            throw new NotImplementedException("Os movimentos da torre ainda não foram implementados!");
        }

        public override string ToString()
        {
            return "T";
        }
    }
} 
