using System;
namespace SmoothOperator
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Insera número inteiro não-negativo: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input >= 0 && userInput <=255) 
                // Verifica se o número está dentro do intervalo do tipo byte
                }
                    byte n = (byte)userinput:

                    //Resultado da operação de decremento de n
                    Console.WriteLine($"Resultado da operação de decremento de n: {--n}");
                    
                    //Resultado da operação de incremento de n
                    Console.WriteLine($"Resultado da operação de incremento de n: {++n}");

                    //Resultado da divisão por 2
                    Console.WriteLine($"Resultado da divisão por 2: {n/2}");

                    //Resultado do shift left por 3
                    Console.WriteLine($"Resultado do shift left por 3: {n<<3}");

                    //Resultado do Xor com 5
                    Console.WriteLine($"Resultado do Xor com 5: {n^5}");

                    //Verifica se é maior que 10
                    Console.WriteLine($"É maior que 10? {n>10}");
                }
                else
                {
                    Console.WriteLine("Número inválido. Por favor, insira um número interiro não-negativo dentro do intervalo de um byte (0-255).");
                }
            }
          

