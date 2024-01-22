// faca um programa que leia 6 numeros e calcule a media aritimetica dele

namespace Exercicio13{
    class Program{
        static void Main(string[]args){
            int n;
            int soma = 0 ;
            double media;
            int i = 0 ;

            while(i<6){
                Console.WriteLine("Digite um numero: ");
                n = int.Parse(Console.ReadLine());
                soma +=n;
                i++;
            }
            media = soma / 6;
            Console.WriteLine("a media dos numeros digitados eh de: " + media);
        }
    }
}
