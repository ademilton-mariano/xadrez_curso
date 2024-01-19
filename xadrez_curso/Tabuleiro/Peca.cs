namespace Tabuleiro;

public abstract class Peca
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

    public abstract bool[,] MovimentosPossiveis();
    
    public bool ExisteMovimentosPossiveis()
    {
        bool[,] matriz = MovimentosPossiveis();
        for (int i = 0; i < TabuleiroJogo.Linhas; i++)
        {
            for (int j = 0; j < TabuleiroJogo.Colunas; j++)
            {
                if (matriz[i, j])
                {
                    return true;
                }
            }
        }

        return false;
    }
}