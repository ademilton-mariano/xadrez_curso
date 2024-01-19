using Tabuleiro;

namespace JogoXadrez;

public class PartidaXadrez
{
    public TabuleiroJogo TabuleiroJogo { get; private set; } = new TabuleiroJogo(8, 8);
    private int Turno;
    private Cor JogadorAtual;
    public bool Terminada { get; private set; }

    public PartidaXadrez()
    {
        Turno = 1;
        JogadorAtual = Cor.Branca;
        ColocarPecas();
    }

    public void ExecutaMovimento(Posicao origem, Posicao destino)
    {
        var peca = TabuleiroJogo.RetirarPeca(origem);
        peca.IncrementarQuantidadeMovimentos();
        var pecaCapturada = TabuleiroJogo.RetirarPeca(destino);
        TabuleiroJogo.ColocarPeca(peca, destino);
    }

    private void  ColocarPecas()
    {
        TabuleiroJogo.ColocarPeca(new Torre(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('a', 1).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Bispo(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('b', 1).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Cavalo(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('c', 1).ToPosicao());
        TabuleiroJogo.ColocarPeca(new DamaRainha(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('d', 1).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Rei(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('e', 1).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Cavalo(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('f', 1).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Bispo(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('g', 1).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Torre(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('h', 1).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('a', 2).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('b', 2).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('c', 2).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('d', 2).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('e', 2).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('f', 2).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('g', 2).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Preta, TabuleiroJogo), new PosicaoXadrez('h', 2).ToPosicao());

        TabuleiroJogo.ColocarPeca(new Torre(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('a', 8).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Bispo(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('b', 8).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Cavalo(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('c', 8).ToPosicao());
        TabuleiroJogo.ColocarPeca(new DamaRainha(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('d', 8).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Rei(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('e', 8).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Cavalo(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('f', 8).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Bispo(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('g', 8).ToPosicao());
        TabuleiroJogo.ColocarPeca(new Torre(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('h', 8).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('a', 7).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('b', 7).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('c', 7).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('d', 7).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('e', 7).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('f', 7).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('g', 7).ToPosicao());
        // TabuleiroJogo.ColocarPeca(new Peao(Cor.Branca, TabuleiroJogo), new PosicaoXadrez('h', 7).ToPosicao());
    }
}