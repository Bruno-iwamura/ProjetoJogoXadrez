using ProjetoJogoXadrez.xadrez;
using System;
using tabuleiro;
using xadrez;

namespace ProjetoJogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro (8,8);

            //Posicao posInit = new Posicao(0,0);
            /*
            try
            {
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 4));
                tab.colocarPeca(new Rei(tab, Cor.Azul), new Posicao(0, 0));

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();

            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }*/

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
        }
    }
}