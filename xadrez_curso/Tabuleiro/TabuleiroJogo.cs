namespace Tabuleiro;

public class TabuleiroJogo
{
    public int Linhas { get; set; }
    public int Colunas { get; set; }
    private Peca[,] Pecas { get; set; }

    public TabuleiroJogo(int linhas, int colunas)
    {
        Linhas = linhas;
        Colunas = colunas;
        Pecas = new Peca[linhas, colunas];
    }

    public Peca Peca(int linha, int coluna)
    {
        return Pecas[linha, coluna];
    }
    public void ColocarPeca(Peca peca, Posicao posicao)
    {
        if (ExistePeca(posicao))
        {
            throw new TabuleiroException("Já existe uma peça nessa posição!");
        }
        Pecas[posicao.Linha, posicao.Coluna] = peca;
        peca.Posicao = posicao;
    }

    public Peca Peca(Posicao posicao)
    {
        return Pecas[posicao.Linha, posicao.Coluna];
    }

    public bool PosicaoValida(Posicao posicao)
    {
        return posicao.Linha >= 0 && posicao.Linha < Linhas && posicao.Coluna >= 0 && posicao.Coluna < Colunas;
    }

    public void ValidarPosicao(Posicao posicao)
    {
        if (!PosicaoValida(posicao))
        {
            throw new TabuleiroException("Posição inválida!");
        }
    }

    public bool ExistePeca(Posicao posicao)
    {
        ValidarPosicao(posicao);
        return Peca(posicao) != null;
    }

    public Peca RetirarPeca(Posicao posicao)
    {
        if (Peca(posicao) == null)
            return null;

        var aux = Peca(posicao);
        aux.Posicao = null;
        Pecas[posicao.Linha, posicao.Coluna] = null;
        return aux;
    }
}