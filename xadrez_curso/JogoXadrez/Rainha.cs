using Tabuleiro;

namespace JogoXadrez;

public class Rainha : Peca
{
    public Rainha(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "D";
    }
}