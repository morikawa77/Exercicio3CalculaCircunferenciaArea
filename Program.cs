using System;

namespace Exercicio3CalculaCircunferenciaArea
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int raio;
			double circ, area, raio2;
			Console.WriteLine("Digite o raio do círculo: ");
			raio = Convert.ToInt32(Console.ReadLine());
            raio2 = raio * raio;
			circ = 2 * Math.PI * raio;
            area = Math.PI * raio2;
			Console.Write("A área do Círculo é " + area + ", e sua circunferência é " + circ);
			Console.ReadLine();
        }
    }
}
