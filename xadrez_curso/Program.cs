using JogoXadrez;
using Tabuleiro;
using xadrez_curso;

try
{
    var novaPartida = new PartidaXadrez();

    while (!novaPartida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(novaPartida.TabuleiroJogo);

        Console.WriteLine("Origem: ");
        var origem = Tela.LerPosicaoXadrez().ToPosicao();

        bool [,] posicoesPossiveis = novaPartida.TabuleiroJogo.Peca(origem).MovimentosPossiveis();

        Console.Clear();
        Tela.ImprimirTabuleiro(novaPartida.TabuleiroJogo, posicoesPossiveis);

        Console.WriteLine("Destino: ");
        var destino = Tela.LerPosicaoXadrez().ToPosicao();

        novaPartida.ExecutaMovimento(origem, destino);
    }
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();