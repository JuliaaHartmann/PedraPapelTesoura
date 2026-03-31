class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            int escolhaJogador = Jogador.ObterEscolha();

            int escolhaComputador = Computador.ObterEscolha();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);

            Console.ReadLine();
        }
    }
}

