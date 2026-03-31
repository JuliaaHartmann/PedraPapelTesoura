using System.Security.Cryptography;

class Computador
{
    public static int ObterEscolha()
    {
        return RandomNumberGenerator.GetInt32(1, 4);
    }
}

