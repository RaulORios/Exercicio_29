using System;

namespace Exercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 29     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int numero1;
            int numero2;
            int numero3;
            string texto_resultado = string.Empty;
            int soma = 0;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if ((numero1 == numero2) || (numero2 == numero3) || (numero1 == numero3))
            {
                Console.WriteLine("Operação cancelada, não deve haver números iguais.");
            }
            else if (numero1 < numero2 && numero1 < numero3)
                {

                    soma = numero2 + numero3;
                    texto_resultado = $"{numero2} e {numero3}";
    
                }

                if (numero1 < numero2)
                    if (numero1 > numero3)
                    {
                        Console.WriteLine($"Os maiores números são: {numero2} e {numero1}, num total de: {numero2 + numero1}.");
                    }
                if (numero1 > numero2)
                    if (numero2 > numero3)
                    {
                        Console.WriteLine($"Os maiores números são: {numero1} e {numero2}, num total de: {numero1 + numero2}.");
                    }
                if (numero1 > numero2)
                    if (numero2 < numero3)
                    {
                        Console.WriteLine($"Os maiores números são: {numero1} e {numero3}, num total de: {numero1 + numero3}.");
                    }

            Console.WriteLine($"Os maiores números são: {texto_resultado}, num total de: {soma}.");

            Console.ReadKey();

        }
    }
}
