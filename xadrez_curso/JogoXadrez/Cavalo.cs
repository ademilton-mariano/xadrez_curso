using Tabuleiro;

namespace JogoXadrez;

public class Cavalo : Peca
{
    public Cavalo(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "C";
    }
}