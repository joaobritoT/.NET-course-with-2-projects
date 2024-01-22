// faca um programa que receba 2 valores e retorne o maior entre eles sem utilizar nenhum metodo;

namespace Exercicio{
    class Program{
        static void Main(string[]args){
            double n1;
            double n2;

            Console.Write("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            n2 = double.Parse(Console.ReadLine());


            if(n1>n2){
                Console.WriteLine("O primeiro numero eh o maior");
            }else if(n2>n1){
                Console.WriteLine("O segundo numero eh maior");
            }else if(n1 == n2){
                Console.WriteLine("Os numeros tem o mesmo valor");
            }
        }
    }
}
