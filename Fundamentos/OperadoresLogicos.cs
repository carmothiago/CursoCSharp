using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Compru a Tv 50? {comprouTV50}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou o sorvete? {comprouSorvete}");

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou Tv32 ? {comprouTv32}");

            Console.WriteLine("Mais saudável ? {0}", !comprouSorvete);
        }
    }
}
