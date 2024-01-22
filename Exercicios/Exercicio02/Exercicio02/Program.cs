//Crie um algoritimo que apos ler dois numeros inteiros, apresente sua soma

namespace Exercicio01{
    class Program{
        static void Main(string[]args){
            int n1;
            int n2;
            double soma;

            Console.WriteLine("Digite um numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            n2 = int.Parse(Console.ReadLine());
            soma = n1+n2;

            Console.WriteLine("A soma dos numeros digitados eh: "+soma);


        }
    }
}
