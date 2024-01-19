using Tabuleiro;

namespace JogoXadrez;

public class Peao : Peca
{
    public Peao(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "P ";
    }

    private bool PodeMover(Posicao posicao)
    {
        var peca = TabuleiroJogo.Peca(posicao);
        return peca == null || peca.Cor != Cor;
    }

    public override bool[,] MovimentosPossiveis()
    {
        throw new NotImplementedException();
    }
}