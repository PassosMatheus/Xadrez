using System;
using tabuleiro;
using nomePecas;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoTabuleiro().toPosicao();
                    
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoTabuleiro().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch(TabuleiroExeption e)
            {
                Console.WriteLine(e.Message);
            }

            PosicaoTabuleiro pos = new PosicaoTabuleiro('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}
