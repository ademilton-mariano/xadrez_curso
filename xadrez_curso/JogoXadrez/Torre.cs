using Tabuleiro;

namespace JogoXadrez;

public class Torre: Peca
{
    public Torre(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "T";
    }
}