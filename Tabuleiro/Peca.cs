using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor Cor { get;protected set; }
        public int QtdMovimentos { get; set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            Cor = cor;
            Tab = tab;
            this.QtdMovimentos = 0; 
        }
    }
}
