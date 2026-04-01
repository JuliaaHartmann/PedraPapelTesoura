class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirTitulo();

            int escolhaJogador = Jogador.ObterEscolha();

            int escolhaComputador = Computador.ObterEscolha();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);

            if (!JogadorDesejaContinuar())
                break;
        }
    }
    static void ExibirTitulo()
    {
        Console.Clear();
        Console.WriteLine("=========================================");
        Console.WriteLine("----------Pedra, Papel e Tesoura---------");
        Console.WriteLine("=========================================");
    }

    static bool JogadorDesejaContinuar()
    {
        Console.Write("Deseja continuar? [S/N]: ");

        if (Console.ReadLine()?.ToUpper() != "S")
            return false;

        return true;
    }
}

