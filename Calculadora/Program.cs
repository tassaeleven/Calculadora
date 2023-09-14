using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Operacoes> filaOperacoes = new Stack<Operacoes>();    

            filaOperacoes.Push(new Operacoes { valorA = 18, valorB = 3, operador = '/' });
            filaOperacoes.Push(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Push(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Push(new Operacoes { valorA = 14, valorB = 8, operador = '-' });

            Calculadora calculadora = new Calculadora();

            Stack<Operacoes> resultados = new Stack<Operacoes>();

            Console.WriteLine("Cálculos e seus resultados: ");

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Pop();
                calculadora.Calcular(operacao);
                resultados.Push(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
            }

            Console.WriteLine("Somente o resultado dos cálculos que foram executados acima:");
            var resultadoRevert = resultados.Reverse();
            foreach (var resultado in resultadoRevert)
            {
                Console.WriteLine("{0}", resultado.resultado);
            }

            //Infelizmente não entendi muito bem o item 4 da lista de atividades.
           
        }
    }
}
