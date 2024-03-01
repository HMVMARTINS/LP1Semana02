using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a altura do cilindro (a): ");
            float altura = float.Parse(Console.ReadLine());

            Console.Write("Insira o raio do cilindro (r): ");
            float raio = float.Parse(Console.ReadLine());

            float volume = MathF.PI * raio * altura;
            float areaSuperficie = 2 * MathF.PI * raio * (raio + altura);

            Console.WriteLine($"Volume do cilindro: {volume}");
            Console.WriteLine($"Área da superfície do cilindro: {areaSuperficie}");
        }
    }
}