class Jogo
{
    public static void CompararEscolhas(int escolhaJogador, int escolhaComputador)
    {
        const int ESCOLHA_PEDRA = 1;
        const int ESCOLHA_PAPEL = 2;
        const int ESCOLHA_TESOURA = 3;

        if (escolhaJogador == escolhaComputador)
        {
            if (escolhaJogador == ESCOLHA_PEDRA)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("Pedra vs Pedra");
            }
            else if (escolhaJogador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("Papel vs Papel");
            }
            else if (escolhaJogador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("Tesoura vs Tesoura");
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("Empate!");
            Console.WriteLine("=========================================");

        }
        else if (escolhaJogador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("=========================================");
            Console.Write("Pedra vs ");

            if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("Papel");
                Console.WriteLine("=========================================");
                Console.WriteLine("O computador venceu!");
            }
            else if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("=========================================");
                Console.WriteLine("Você venceu!");
            }
        }
        else if (escolhaJogador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("=========================================");
            Console.Write("Papel vs ");

            if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("=========================================");
                Console.WriteLine("O computador venceu!");
            }
            else if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine("Pedra");
                Console.WriteLine("=========================================");
                Console.WriteLine("Você venceu!");
            }
        }
        else if (escolhaJogador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("=========================================");
            Console.Write("Tesoura vs ");

            if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine("Pedra");
                Console.WriteLine("=========================================");
                Console.WriteLine("O computador venceu!");
            }
            else if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("Papel");
                Console.WriteLine("=========================================");
                Console.WriteLine("Você venceu!");
            }
        }
    }
}

