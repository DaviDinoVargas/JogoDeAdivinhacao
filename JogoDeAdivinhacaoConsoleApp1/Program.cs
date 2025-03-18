using static JogoDeAdivinhacaoConsoleApp1.JogoDeAdivinhacao;

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

                if (opcao == "1")
                {
                    totalTentativas = 10;
                    entradaValida = true;
                }
                else if (opcao == "2")
                {
                    totalTentativas = 5;
                    entradaValida = true;
                }
                else if (opcao == "3")
                {
                    totalTentativas = 3;
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Opção inválida! Escolha 1, 2 ou 3.");
                }
            }
            return totalTentativas;
        }

        static void Jogar(int totalTentativas)
        {
            JogoDeAdivinhacao.IniciarNovoJogo(totalTentativas);
            bool acertou = false;

            for (int tentativas = 1; tentativas <= totalTentativas; tentativas++)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"tentativa {tentativas} de {totalTentativas}");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Digite um número: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                ResultadoTentativa resultado = JogoDeAdivinhacao.VerificarTentativa(numeroDigitado);

                // Lógica do jogo

                if (resultado == ResultadoTentativa.Acertou)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Você acertou o número secreto!");
                    Console.WriteLine("----------------------------------------");
                    acertou = true;
                    break;
                }

                else if (resultado == ResultadoTentativa.NumeroMaior)
                {
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("O numero informado é maior que o numero secreto");
                    Console.WriteLine("-----------------------------------------------");
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("O numero informado é menor que o numero secreto");
                    Console.WriteLine("-----------------------------------------------");
                }

                Console.Write("Aperte <Enter>");
                Console.ReadLine();
            }

            if (!acertou)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("que pena! Você não conseguiu acertar. O número secreto era " + JogoDeAdivinhacao.ObterNumeroSecreto());
                Console.WriteLine("----------------------------------------");
            }
        }
        static bool DesejaContinuar()
        {
            Console.Write("Deseja continuar? (s/N): ");
            return Console.ReadLine()!.Trim().ToUpper() == "S";
        }
    }
}