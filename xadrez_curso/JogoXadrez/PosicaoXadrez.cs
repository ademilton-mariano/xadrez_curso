﻿using Tabuleiro;

namespace JogoXadrez;

public class PosicaoXadrez
{
    public char Coluna { get; set; }
    public int Linha { get; set; }

    public PosicaoXadrez(char coluna, int linha)
    {
        Coluna = coluna;
        Linha = linha;
    }
    
    public Posicao ToPosicao()
    {
        return new Posicao(8 - Linha, Coluna - 'a');
    }
}