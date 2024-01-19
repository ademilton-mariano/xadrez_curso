using Tabuleiro;

namespace JogoXadrez;

public class Rei: Peca
{
    public Rei(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "R ";
    }
}