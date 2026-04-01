class Jogador
{
    public static int ObterEscolha()
    {
        int escolhaJogador;

        do
        {
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            Console.WriteLine("=========================================");
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
}

