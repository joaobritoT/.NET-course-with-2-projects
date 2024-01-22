//refaca o exercicio anterior usando o laco FOR

namespace Exercicio14{
    class Program{
        static void Main(string[]args){
            int n;
            int soma = 0;
            int i;
            double media;

            for(i=0;i<6;i++){
                Console.WriteLine("Digite um numero: ");
                n = int.Parse(Console.ReadLine());
                soma+=n;
            }

            media = soma /6;
            Console.WriteLine("A media dos numeros digitados eh de: "+ media);
        }
    }
}