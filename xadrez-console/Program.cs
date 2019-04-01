﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(2, 3));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(4, 3));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 4));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 7));


                Tela.imprimirTabuleiro(tab);
            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
