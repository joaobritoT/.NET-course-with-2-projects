// faca um programa que verifique se o numero eh impar

namespace Exercicio09{
    class Program{
        static void Main(string[]args){
            int n;
            bool impar;

            Console.WriteLine("Digite um numero inteiro: ");
            n = int.Parse(Console.ReadLine());

            if(n%2 == 0){
                impar = false;
            }else{
                impar = true;
            }

            if(impar == true){
                Console.WriteLine("O numero eh impar");

            }else{
                Console.WriteLine("O numero eh par");
            }
        }
    }
}