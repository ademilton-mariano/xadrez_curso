using Tabuleiro;

namespace JogoXadrez;

public class Bispo : Peca
{
    public Bispo(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "B";
    }
}