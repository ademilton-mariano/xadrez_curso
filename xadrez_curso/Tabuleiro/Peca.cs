namespace Tabuleiro;

public class Peca
{
    public Posicao Posicao { get; set; }
    public Cor Cor { get; set; }
    public int QuantidadeMovimentos { get; protected set; }
    public TabuleiroJogo TabuleiroJogo { get; protected set; }

    public Peca(Cor cor, TabuleiroJogo tabuleiro)
    {
        Posicao = null;
        Cor = cor;
        TabuleiroJogo = tabuleiro;
        QuantidadeMovimentos = 0;
    }

    public void IncrementarQuantidadeMovimentos()
    {
        QuantidadeMovimentos++;
    }
}