using System;

namespace Calculo_IMC
{
    class Program
    {
        static void Main(string[] args)

        {
            float peso, altura;

            
            Console.WriteLine("Cálculo do IMC");
            Console.WriteLine("Informe o peso, em kg");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura, em mts");
            altura = float.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("valor do imc:" + imc);

            if (imc < 18.49)
            {
                Console.WriteLine("abaixo do peso");
            }
            else if (imc < 24.99)
            {
                Console.WriteLine("peso normal");
            }
            else if (imc < 29.99)
            {
                Console.WriteLine("acima do peso");
            }
            else if (imc < 34.99)
            {
                Console.WriteLine("obesidade grau I");
            }
            else if (imc < 39.99)
            {
                Console.WriteLine("obesidade grau II (severa)");
            }
            else
            {
                Console.WriteLine("obesidade grau III (mórbida)");
            }

        }
    }
}
