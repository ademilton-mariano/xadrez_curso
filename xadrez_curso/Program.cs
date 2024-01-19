// See https://aka.ms/new-console-template for more information

using Tabuleiro;
using xadrez_curso;
using JogoXadrez;


var Tabuleiro = new TabuleiroJogo(8, 8);

Tabuleiro.ColocarPeca(new Torre(Cor.Preta, Tabuleiro), new Posicao(0,0));
Tabuleiro.ColocarPeca(new Torre(Cor.Preta, Tabuleiro), new Posicao(1,3));
Tabuleiro.ColocarPeca(new Rei(Cor.Preta, Tabuleiro), new Posicao(2,4));

Tela.ImprimirTabuleiro(Tabuleiro);

Console.ReadLine();