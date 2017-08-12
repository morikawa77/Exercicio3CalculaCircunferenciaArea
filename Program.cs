using System;

namespace Exercicio3CalculaCircunferenciaArea
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			double circ, area, raio;
			Console.WriteLine("Digite o raio do círculo: ");
            raio = Convert.ToDouble(Console.ReadLine());
            circ = 2 * Math.PI * raio;
            area = Math.PI * Math.Pow(raio, 2);
			Console.Write("A área do Círculo é " + area + ", e sua circunferência é " + circ);
			Console.ReadLine();
        }
    }
}
