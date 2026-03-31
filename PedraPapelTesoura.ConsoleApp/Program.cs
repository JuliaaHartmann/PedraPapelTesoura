using System.Security.Cryptography;

const int ESCOLHA_PEDRA = 1;
const int ESCOLHA_PAPEL = 2;
const int ESCOLHA_TESOURA = 3;

while (true)
{
    Console.Clear();
    // Lógica do Jogo
    // 1. Escolha do jogador (Input)
    int escolhaJogador;

    do
    {
        Console.WriteLine("1 - Pedra");
        Console.WriteLine("2 - Papel");
        Console.WriteLine("3 - Tesoura");

        Console.Write("Digite uma opção válida: ");
        string strEscolhaJogador = Console.ReadLine();

        //se for escolha válida
        if (
            strEscolhaJogador == "1" ||
            strEscolhaJogador == "2" ||
            strEscolhaJogador == "3"
        )
        {
            escolhaJogador = Convert.ToInt32(strEscolhaJogador);
            break;
        }
    } while (true);

    //2. Escolha do Computador
    int escolhaComputador = RandomNumberGenerator.GetInt32(1, 4);

    //3. Comparação do Pedra, Papel, Tesoura 
    if (escolhaJogador == escolhaComputador)
    {
        Console.WriteLine("Empate!");
    }
    else if (escolhaJogador == ESCOLHA_PEDRA)
    {
        Console.Write("Pedra vs ");

        if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine("O computador venceu!");
        }
        else if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine("Você venceu!");
        }
    }
    else if (escolhaJogador == ESCOLHA_PAPEL)
    {
        Console.Write("Papel vs ");

        if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine("O computador venceu!");
        }
        else if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Pedra");
            Console.WriteLine("Você venceu!");
        }
    }
    else if (escolhaJogador == ESCOLHA_TESOURA)
    {
        Console.Write("Tesoura vs ");

        if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Pedra");
            Console.WriteLine("O computador venceu!");
        }
        else if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine("Você venceu!");
        }
    }

    Console.ReadLine();
}
