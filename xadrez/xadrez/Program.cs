using System;
using tabuleiro;
using nomePecas;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoTabuleiro pos = new PosicaoTabuleiro('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}
