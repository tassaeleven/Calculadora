using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes Calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '/': operacao.resultado = Divisao(operacao); break;
                case '+': operacao.resultado = Soma(operacao);break;
                case '*': operacao.resultado = Multiplicacao(operacao); break;
                case '-': operacao.resultado = Subtracao(operacao);break;               
                
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public long Soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public long Subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public long Multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public long Divisao(Operacoes operacao)
        {
            return operacao.valorA / operacao.valorB;
        }
       
    }
}
