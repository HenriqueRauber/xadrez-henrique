using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tabuleiro;
using xadrez;
//using tabuleiro; 

namespace Test_xadrez
{
    [TestClass]
    public class TestJogadas
    {
        [TestMethod]
        public void TestJogadas_MovimentandoPeoesPraFrente()
        {
            partida(new Jogada[]
            {
                //ta verificando como bispo...
                new Jogada("a2","a4"),
                new Jogada("a7","a5"),
                new Jogada("b2","b4"),
                new Jogada("b7","b5"),
                new Jogada("c2","c4"),
                new Jogada("c7","c5"),
                new Jogada("d2","d4"),
                new Jogada("d7","d5"),
                new Jogada("e2","e4"),
                new Jogada("e7","e5"),
                new Jogada("f2","f4"),
                new Jogada("f7","f5"),
                new Jogada("g2","g4"),
                new Jogada("g7","g5"),
                new Jogada("h2","h4"),
                new Jogada("h7","h5"),
            });
        } 

        [TestMethod]
        public void TestJogadas_MovimentandoPeaoDoOutroJogador()
        {
            try
            {
                partida(new Jogada[]
                {
                    new Jogada("a7","a5"),
                });

                throw new Exception("Deveria ter ocorrido erro!");
            }
            catch (TabuleiroException te)
            {
                if (te.Message != "A peça de origem escolhida não é sua!")
                {
                    throw;
                }
            }
        }

        [TestMethod]
        public void TestJogadas_MovimentandoPeaoParaPosicaoInvalida()
        {
            try
            {
                partida(new Jogada[]
                {
                    new Jogada("a2","a5"),
                });

                throw new Exception("Deveria ter ocorrido erro!");
            }
            catch (TabuleiroException te) {
                if (te.Message != "Posição de destino inválida!")
                {
                    throw;
                }
            }
        }

        [TestMethod]
        public void TestJogadas_MovimentandoPeaoPosicaoInvalida2()
        {
            try
            {
                partida(new Jogada[]
                {
                    new Jogada("a2","a4"),
                    new Jogada("a7","a5"),
                    new Jogada("a4","a5"),
                });

                throw new Exception("Deveria ter ocorrido erro!");
            }
            catch (TabuleiroException te)
            {
                if (te.Message != "Posição de destino inválida!")
                {
                    throw;
                }
            }
        }


        [TestMethod]
        public void TestJogadas_RoquePequeno()
        {
            PartidaDeXadrez part = partida(new Jogada[]
            {
                new Jogada("e2","e4"),
                new Jogada("a7","a6"),
                new Jogada("f1","a6"),
                new Jogada("b7","a6"),
                new Jogada("g1","h3"),
                new Jogada("a6","a5"),
                new Jogada("e1","g1"),
            });
            //Ver se invertou o rei e a torre...
        }

        [TestMethod]
        public void TestJogadas_RoqueGrande()
        {
            partida(new Jogada[]
            {
                new Jogada("e2","e4"),
                new Jogada("a7","a6"),
                new Jogada("f1","a6"),
                new Jogada("b7","a6"),
                new Jogada("g1","h3"),
                new Jogada("a6","a5"),
                new Jogada("e1","g1"),
            });
        }

        private PartidaDeXadrez partida(params Jogada[] jogadas)
        {

            PartidaDeXadrez partida = new PartidaDeXadrez();
            foreach (Jogada jogada in jogadas)
            {
                partida.validarPosicaoDeOrigem(jogada.Origem);
                partida.validarPosicaoDeDestino(jogada.Origem, jogada.Destino);
                partida.realizaJogada(jogada.Origem, jogada.Destino);
            }
            return partida;
        }

        private class Jogada
        {
            public Posicao Origem { get; set; }
            public Posicao Destino { get; set; }

            public Jogada(string origem, string destino)
            {
                Origem = new xadrez.PosicaoXadrez(origem[0], int.Parse(origem[1] + "")).toPosicao();
                Destino = new xadrez.PosicaoXadrez(destino[0], int.Parse(destino[1] + "")).toPosicao();
            }
        }
    }
}
