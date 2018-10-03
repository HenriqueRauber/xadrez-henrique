using System;
using tabuleiro;
using xadrez;

namespace xadrez_henrique
{
    class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 4));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(6, 3));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.Write(e.Message);
            }
            Console.ReadLine();
        }
    }
}
