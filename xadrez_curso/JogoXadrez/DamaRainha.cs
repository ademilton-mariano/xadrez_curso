using Tabuleiro;

namespace JogoXadrez;

public class DamaRainha : Peca
{
    public DamaRainha(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "D";
    }
}