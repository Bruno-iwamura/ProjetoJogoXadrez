﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao {  get; set; }
        public Cor cor { get; protected set; }
        public int qtMovimentos { get; protected set; }
        public Tabuleiro tab {  get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qtMovimentos++;
        }
    }
}
