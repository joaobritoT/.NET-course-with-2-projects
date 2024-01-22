// Daado uma serie de 10 valores inteiros, calcule a media aritimetica desdes valores

namespace Exercicio{
    class Program{
        static void Main(string[]args){
            int i;
            int n;
            int soma =0;
            double media;

            for(i=0;i<10;i++){
                Console.WriteLine($"Digite o [{i+1}] numero: ");
                n = int.Parse(Console.ReadLine());
                soma+=n;

            }
            media = soma / 10;
            Console.WriteLine("A media dos numeros digitados eh de: "+media);
        }
    }
}
