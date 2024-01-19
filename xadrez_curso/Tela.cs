﻿using JogoXadrez;
using Tabuleiro;

namespace xadrez_curso;

public class Tela
{
    public static void ImprimirTabuleiro(TabuleiroJogo tabuleiro)
    {
        for (int i = 0; i < tabuleiro.Linhas; i++)
        {
            Console.Write(8 - i + " ");
            for (int j = 0; j < tabuleiro.Colunas; j++)
            {
                if (tabuleiro.Peca(i, j) == null)
                {
                    Console.Write("- ");
                }
                else
                {
                    ImprimirPeca(tabuleiro.Peca(i, j));
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");
    }

    public static void ImprimirPeca(Peca peca)
    {
        if (peca.Cor == Cor.Branca)
        {
            Console.Write(peca);
        }
        else
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(peca);
            Console.ForegroundColor = aux;
        }
    }

    public static PosicaoXadrez LerPosicaoXadrez()
    {
        var posicao = Console.ReadLine();
        var coluna = posicao[0];
        var linha = int.Parse(posicao[1] + "");
        return new PosicaoXadrez(coluna, linha);
    }
}