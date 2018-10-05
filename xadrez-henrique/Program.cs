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
                //Tabuleiro tab = new Tabuleiro(8, 8);
                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
                //tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 4));
                //tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
                //tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));
                //tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(6, 3));

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                        
                }

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.Write(e.Message);
            }
            Console.ReadLine();
        }
    }
}
