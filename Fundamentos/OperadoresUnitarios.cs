using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnitarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);//numero1 só será incrmentado antes de comparar e o numero2 decrementado antes de comparar
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
