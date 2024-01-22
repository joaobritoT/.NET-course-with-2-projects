// Faca um algoritimo que leia 3 numeros inteiros e mostre o menor deles

namespace Exercicio18{
    class Program{
        static void Main(string[]args){
            List<int> valores = new List<int>();

            int i;
            int n;

            for(i=0;i<3;i++){
                Console.WriteLine($"Digite o [{i+1}] numero: ");
                n = int.Parse(Console.ReadLine());
                valores.Add(n);
            }
            Console.WriteLine("O menor valor digitado foi: "+valores.Min());
        }
    }
}
