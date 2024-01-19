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

    public override bool[,] MovimentosPossiveis()
    {
        var matriz = new bool[TabuleiroJogo.Linhas, TabuleiroJogo.Colunas];

        var posicao = new Posicao(0, 0);

        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna - 1);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna + 1);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 2);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 2);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna + 1);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna - 1);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 2);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        return matriz;
    }

    private bool PodeMover(Posicao posicao)
    {
        var peca = TabuleiroJogo.Peca(posicao);
        return peca == null || peca.Cor != Cor;
    }
}