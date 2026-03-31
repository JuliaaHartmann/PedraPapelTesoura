using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            int escolhaJogador = ObterEscolhaJogador();

            int escolhaComputador = ObterEscolhaComputador();

            CompararEscolhas(escolhaJogador, escolhaComputador);

            Console.ReadLine();
        }
    }
    
    static int ObterEscolhaJogador()
    {
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

        return escolhaJogador;
    }
    static int ObterEscolhaComputador()
    {
        return RandomNumberGenerator.GetInt32(1, 4);
    }
    static void CompararEscolhas(int escolhaJogador, int escolhaComputador)
    {
        const int ESCOLHA_PEDRA = 1;
        const int ESCOLHA_PAPEL = 2;
        const int ESCOLHA_TESOURA = 3;

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
    }
}

