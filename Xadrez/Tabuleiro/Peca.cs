﻿

namespace Tabuleiro {
    class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtoMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab) {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qtoMovimentos = 0;
        }
    }
}
