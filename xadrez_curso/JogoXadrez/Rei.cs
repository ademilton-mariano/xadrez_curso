using Tabuleiro;

namespace JogoXadrez;

public class Rei: Peca
{
    public Rei(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "R";
    }

    public override bool[,] MovimentosPossiveis()
    {
        var matriz = new bool[TabuleiroJogo.Linhas, TabuleiroJogo.Colunas];

        var posicao = new Posicao(0, 0);

        // acima
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
        
        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // abaixo
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
        
        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // direita
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // esquerda
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // noroeste
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // nordeste
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // sudeste
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

        if (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // sudoeste
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

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