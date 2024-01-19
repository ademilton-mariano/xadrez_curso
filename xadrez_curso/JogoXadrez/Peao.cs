using Tabuleiro;

namespace JogoXadrez;

public class Peao : Peca
{
    public Peao(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "P";
    }
}