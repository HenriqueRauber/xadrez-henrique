using System;
using tabuleiro;
using xadrez;

namespace xadrez_henrique
{
    class Program
    {

        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.Write(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Tabuleiro tab = new Tabuleiro(8, 8);

        //        tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
        //        tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
        //        tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 4));

        //        Tela.imprimirTabuleiro(tab);
        //    }catch(TabuleiroException e)
        //    {
        //        Console.Write(e.Message);
        //    }
        //    Console.ReadLine();
        //}
    }
}
