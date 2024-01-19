// See https://aka.ms/new-console-template for more information

using Tabuleiro;
using xadrez_curso;
using JogoXadrez;


try
{
    var Tabuleiro = new TabuleiroJogo(8, 8);

    Tabuleiro.ColocarPeca(new Torre(Cor.Preta, Tabuleiro), new Posicao(0,0));
    Tabuleiro.ColocarPeca(new Torre(Cor.Preta, Tabuleiro), new Posicao(1,3));
    Tabuleiro.ColocarPeca(new Rei(Cor.Preta, Tabuleiro), new Posicao(0,9));

    Tela.ImprimirTabuleiro(Tabuleiro);

}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();