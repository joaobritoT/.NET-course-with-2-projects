// faca um programa que leia dois numeros inteitos e apresente sua diferenca

namespace Exercicio03{
    class Program{
        static void Main(string[]args){
            int n1;
            int n2;

            double diferenca;
            Console.WriteLine("Digite um numero inteiro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero inteiro: ");
            n2 = int.Parse(Console.ReadLine());

            diferenca = n1-n2;
            Console.WriteLine("A diferenca entre os numeros eh de: "+ diferenca);

            
            
        }
    }
}