﻿using System;
using tabuleiro;

namespace xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + P);
            Console.ReadLine();
        }
    }
}
