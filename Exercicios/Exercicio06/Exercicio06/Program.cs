// crie um programa que receba um valor do quilo do produto e a quantidade de quilos do produto consumida calculando o valor final a ser pago

using System.Globalization;

namespace Exercicio06{
    class Program{
        static void Main(string[]args){
            float valor_do_quilo;
            float quantidade_consumida;
            float valor_a_ser_pago;

    

            Console.WriteLine("Qual o valor do quilo do produto: ");
            valor_do_quilo = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade consumida: ");
            quantidade_consumida = float.Parse(Console.ReadLine());
            
            

            valor_a_ser_pago = quantidade_consumida * valor_do_quilo;

            Console.WriteLine("O valor a ser pago vai ser de: R$"+valor_a_ser_pago);

        }
    }
}
