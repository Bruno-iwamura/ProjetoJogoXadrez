using ProjetoJogoXadrez.xadrez;
using System;
using tabuleiro;

namespace ProjetoJogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro (8,8);

            //Posicao posInit = new Posicao(0,0);

            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0,0));
            tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(1,3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(3,4));

            Tela.imprimirTabuleiro (tab);

            Console.ReadLine();

        }
    }
}