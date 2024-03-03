using System;
class JogoAdivinhacao
{
    private string palavraSecreta;
    private int tentativasMaximas;
    private int tentativas;

    public JogoAdivinhacao(string palavraSecreta, int tentativasMaximas)
    {
        this.palavraSecreta = palavraSecreta.ToLower();
        this.tentativasMaximas = tentativasMaximas;
        this.tentativas = 0;
    }

    public void Jogar()
    {
        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar a palavra secreta.");

        while (tentativas < tentativasMaximas)
        {
            Console.Write("Digite o seu palpite: ");
            string palpite = Console.ReadLine().ToLower();

            tentativas++;

            if (palpite == palavraSecreta)
            {
                Console.WriteLine($"Parabéns! Você acertou a palavra secreta '{palavraSecreta}'.");
                return;
            }
            else
            {
                Console.WriteLine("Palavra incorreta. Tente novamente.");
            }
        }

        Console.WriteLine($"Suas {tentativasMaximas} tentativas acabaram. A palavra secreta era '{palavraSecreta}'.");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite a palavra secreta: ");
        string palavraSecreta = Console.ReadLine();

        Console.Write("Digite o número máximo de tentativas: ");
        int tentativasMaximas;
        while (!int.TryParse(Console.ReadLine(), out tentativasMaximas) || tentativasMaximas <= 0)
        {
            Console.WriteLine("Número inválido. Digite novamente:");
        }

        JogoAdivinhacao jogo = new JogoAdivinhacao(palavraSecreta, tentativasMaximas);
        jogo.Jogar();
    }
}



//Fazer um programa que
// O usuario insira uma palavra secreta 
// terá 5 tentativas para adivinhar a palavra secreta = int
// Deve aparecer na tela ao usuario as opções
// Digite a palavra secreta ( palavra que deve ser advinhada)= String
// Digite palpite, tentativa de advinhar  = String
// Informar se acertou a palavra secreta = Strig
// Infomar se errou a palavra secreta dar opção de tentar novamente
// Se errar todas as 5 tentativas, informar que acabaram as tentativas = int
// Informar qual era a palavra secreta = String
// Com orientação a objetos


//Strings
//Inserir a palavra secreta
//Bem-vindo ao jogo de adivinhação
//Tente adivinhar a palavra secreta
//Digitar o seu palpite
//Palavra incorreta. Tente novamente
//Parabéns você acertou a palavra secreta 
//Tentativas  acabaram

//Variaceis
//palavra secreta
//tentativas maximas
//tentativas
//palpite



