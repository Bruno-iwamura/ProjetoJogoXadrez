﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tabuleiro;

namespace ProjetoJogoXadrez.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { 
        
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
