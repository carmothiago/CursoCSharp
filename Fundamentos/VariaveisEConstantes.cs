using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //área da circunferência
            double raio = 4.5;
            const double PI = 3.14;
            
            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Sálario é " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_00;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador é " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de mercado da Applé é" + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreAsEstrelas);

            char letra = 'b';
            Console.WriteLine(letra);

            string texto = "Seja Bem vindo!!";
            Console.WriteLine(texto);
        }
    }
}
