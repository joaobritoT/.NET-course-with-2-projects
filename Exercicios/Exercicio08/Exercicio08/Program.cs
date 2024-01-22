// faca um programa que leia 4 numeros e retorne o menor numero

namespace Exercicio08{
    class programa{
        static void Main(string[]args){
            List<int> valores = new List<int>();
            int i;
            int n;

            for(i=0;i< 4;i++){
                Console.WriteLine("Digite um numero inteiro: ");
                n = int.Parse(Console.ReadLine());
                valores.Add(n);
            }

            Console.WriteLine("O menor numero digitado foi: "+ valores.Min());
        }
    }
}
