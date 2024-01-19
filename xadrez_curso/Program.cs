// See https://aka.ms/new-console-template for more information

using Tabuleiro;
using xadrez_curso;

Posicao Posicao;
Tabuleiro.Tabuleiro Tabuleiro;

Tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

Tela.ImprimirTabuleiro(Tabuleiro);

Console.ReadLine();