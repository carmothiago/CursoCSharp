using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.8;
            int notaTruncada = (int) nota;
            Console.WriteLine(notaTruncada);

            Console.WriteLine("digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"idade inserida : {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"resultado : {idadeInteiro}");

            Console.Write("digite um primeiro numero");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine(numero1);

            Console.Write("digite um segundo numero");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(numero2);
        }
    }
}
