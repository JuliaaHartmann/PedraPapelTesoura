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
        Console.Write("----------");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(" Pedra");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(",");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(" Papel");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(",");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(" Tesoura");
        Console.ResetColor();
        Console.WriteLine("---------");
        Console.WriteLine("=========================================");

    }

    static bool JogadorDesejaContinuar()
    {
        Console.WriteLine("=========================================");
        Console.Write("Deseja continuar? [S/N]: ");

        if (Console.ReadLine()?.ToUpper() != "S")
            return false;

        return true;
    }
}

