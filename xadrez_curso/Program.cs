// See https://aka.ms/new-console-template for more information

using Tabuleiro;
using xadrez_curso;
using JogoXadrez;


try
{
    var Tabuleiro = new TabuleiroJogo(8, 8);

    // var PosicaoXadrez = new PosicaoXadrez('c', 7);
    // Console.WriteLine($"{PosicaoXadrez.Coluna}{PosicaoXadrez.Linha}");
    // Console.WriteLine($"{PosicaoXadrez.ToPosicao().Coluna}, {PosicaoXadrez.ToPosicao().Linha}");
    
    Tabuleiro.ColocarPeca(new Torre(Cor.Preta, Tabuleiro), new Posicao(0, 0));
    Tabuleiro.ColocarPeca(new Torre(Cor.Preta, Tabuleiro), new Posicao(1, 3));
    Tabuleiro.ColocarPeca(new Rei(Cor.Preta, Tabuleiro), new Posicao(2, 4));
    Tabuleiro.ColocarPeca(new Torre(Cor.Branca, Tabuleiro), new Posicao(3, 5));
    Tabuleiro.ColocarPeca(new Torre(Cor.Branca, Tabuleiro), new Posicao(4, 6));
    Tabuleiro.ColocarPeca(new Rei(Cor.Branca, Tabuleiro), new Posicao(5, 7));

    Tela.ImprimirTabuleiro(Tabuleiro);

}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();