using ProjetoJogoXadrez.xadrez;
using System;
using System.Net.Http.Headers;
using tabuleiro;
using xadrez;

namespace ProjetoJogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Posicao posInit = new Posicao(0,0);
            
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.ExcutaMovimento(origem, destino);

                    Tela.imprimirTabuleiro(partida.tab);
                }

                Console.ReadLine();

            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            //PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            //Console.WriteLine(pos);

            // Console.WriteLine(pos.toPosicao());
        }
    }
}