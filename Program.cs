using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //FUNDAMENTOS 
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de Tipos - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadorDeAtribuicao.Executar},
                {"Operadores Unitários - Fundamentos", OperadoresUnitarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar},
                
                //ESTRUTURAS DE CONTROLE
                {"IF - Estruturas de Controle", EstruturaIF.Executar},
                {"IF / Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"IF / Elseif - Estruturas de Controle", EstruturaIfElseif.Executar},
                {"Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"For - Estruturas de Controle", EstruturaFor.Executar},
                {"ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Continue - Estruturas de Controle", UsandoContinue.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}