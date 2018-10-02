using System;
using tabuleiro;

namespace xadrez_henrique
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                { 
                    Console.Write($"{tab.peca(i, j)?.ToString() ?? "-"} ");
                }
                Console.WriteLine();
            }
        }
    }
}
