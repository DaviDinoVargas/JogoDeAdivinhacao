namespace JogoDeAdivinhacaoConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // loop principal do jogo
            while (true)
            {
                Console.Clear();
                ExibirMenu();
                int totalTentativas = EscolherDificuldade();
                Jogar(totalTentativas);
                if (!DesejaContinuar())
                    break;
            }

            static void ExibirMenu()
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("         Jogo de Adivinhação");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("        Escolha a Dificuldade: ");
                Console.WriteLine("       1- Fácil     10 tentativas");
                Console.WriteLine("       2- Normal    5 tentativas");
                Console.WriteLine("       3- Dificil   3 tentativas");
                Console.WriteLine("----------------------------------------");
            }

            static int EscolherDificuldade()
            {
                int totalTentativas = 0;
                bool entradaValida = false;
                while (!entradaValida)
                {
                    Console.Write("Digite sua dificuldade: ");
                    string opcao = Console.ReadLine()!.Trim();

                    switch (opcao)
                    {
                        case "1": totalTentativas = 10; entradaValida = true; break;
                        case "2": totalTentativas = 5; entradaValida = true; break;
                        case "3": totalTentativas = 3; entradaValida = true; break;
                        default: Console.WriteLine("Opção inválida! Escolha 1, 2 ou 3."); break;
                    }
                }
                return totalTentativas;
            }

            static void Jogar(int totalTentativas)
            {
                // gerar um número secreto aleatório
                Random geradorDeNumeros = new Random();
                int numeroSecreto = geradorDeNumeros.Next(1, 21);

                for (int tentativas = 1; tentativas <= totalTentativas; tentativas++)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine($"tentativa {tentativas} de {totalTentativas}");
                    Console.WriteLine("--------------------------------------------");
                    Console.Write("Digite um número: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    // Lógica do jogo

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Você acertou o número secreto!");
                        Console.WriteLine("----------------------------------------");
                        break;
                    }

                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("O numero informado é maior que o numero secreto");
                        Console.WriteLine("-----------------------------------------------");
                    }
                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("O numero informado é menor que o numero secreto");
                        Console.WriteLine("-----------------------------------------------");

                    }
                    if (tentativas == totalTentativas)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("que pena! Você não conseguiu acertar. O número secreto era " + numeroSecreto);
                        Console.WriteLine("----------------------------------------");
                        break;
                    }

                    Console.Write("Aperte <Enter>");
                    Console.ReadLine();
                }
            }

                static bool DesejaContinuar()
                {
                    Console.Write("Deseja continuar? (s/N): ");
                    return Console.ReadLine()!.Trim().ToUpper() == "S";
             
                        
                }
            
        }
    }
}
