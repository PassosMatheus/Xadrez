using System;
using tabuleiro;
using nomePecas;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            try{
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoTabuleiro().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoTabuleiro().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch(TabuleiroExeption e)
            {
                Console.WriteLine(e.Message);
            }

=======
            PosicaoTabuleiro pos = new PosicaoTabuleiro('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
>>>>>>> be4772d9cabed3fd2ed0ea6c7617c519f2c6bd0d
            Console.ReadLine();
        }
    }
}
