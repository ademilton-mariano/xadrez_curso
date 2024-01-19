using Tabuleiro;

namespace JogoXadrez;

public class Bispo : Peca
{
    public Bispo(Cor cor, TabuleiroJogo tabuleiro) : base(cor, tabuleiro)
    {
    }

    public override string ToString()
    {
        return "B";
    }

    public override bool[,] MovimentosPossiveis()
    {
        var matriz = new bool[TabuleiroJogo.Linhas, TabuleiroJogo.Colunas];

        var posicao = new Posicao(0, 0);

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
    
    private bool PodeMover(Posicao posicao)
    {
        var peca = TabuleiroJogo.Peca(posicao);
        return peca == null || peca.Cor != Cor;
    }
}