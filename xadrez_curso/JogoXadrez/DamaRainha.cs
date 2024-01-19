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

    public override bool[,] MovimentosPossiveis()
    {
        var matriz = new bool[TabuleiroJogo.Linhas, TabuleiroJogo.Colunas];

        var posicao = new Posicao(0, 0);

        // acima
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);

        while (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;

            if (TabuleiroJogo.Peca(posicao) != null && TabuleiroJogo.Peca(posicao).Cor != Cor)
                break;

            posicao.Linha -= 1;
        }

        // abaixo
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

        while (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;

            if (TabuleiroJogo.Peca(posicao) != null && TabuleiroJogo.Peca(posicao).Cor != Cor)
                break;

            posicao.Linha += 1;
        }

        // direita
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

        while (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;

            if (TabuleiroJogo.Peca(posicao) != null && TabuleiroJogo.Peca(posicao).Cor != Cor)
                break;

            posicao.Coluna += 1;
        }

        // esquerda
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

        while (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;

            if (TabuleiroJogo.Peca(posicao) != null && TabuleiroJogo.Peca(posicao).Cor != Cor)
                break;

            posicao.Coluna -= 1;
        }

        // noroeste
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
        
        while (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;

            if (TabuleiroJogo.Peca(posicao) != null && TabuleiroJogo.Peca(posicao).Cor != Cor)
                break;

            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
        }

        // nordeste
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
        
        while (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;

            if (TabuleiroJogo.Peca(posicao) != null && TabuleiroJogo.Peca(posicao).Cor != Cor)
                break;

            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
        }

        // sudeste
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
        
        while (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;

            if (TabuleiroJogo.Peca(posicao) != null && TabuleiroJogo.Peca(posicao).Cor != Cor)
                break;

            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
        }

        // sudoeste
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

        while (TabuleiroJogo.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;

            if (TabuleiroJogo.Peca(posicao) != null && TabuleiroJogo.Peca(posicao).Cor != Cor)
                break;

            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
        }

        return matriz;
    }

    public bool PodeMover(Posicao posicao)
    {
        var peca = TabuleiroJogo.Peca(posicao);
        return peca == null || peca.Cor != Cor;
    }
}