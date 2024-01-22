// Adapte o exercicio anterior considerando que se a media obtida for maior ou igual a 8, devera ser atribuida para 10

namespace Exercicio{
    class Program{
        static void Main(string[]args){
            int i;
            int n;
            int soma =0;
            double media;
            double media_final;

            for(i=0;i<10;i++){
                Console.WriteLine($"Digite o [{i+1}] numero: ");
                n = int.Parse(Console.ReadLine());
                soma+=n;

            }
            media = soma / 10;
            if(media>=8){
                media_final = 10;
            }
            else{
                media_final = media;
            }
            Console.WriteLine("Media parcial dos numeros: "+media);
            Console.WriteLine("A media final dos numeros digitados eh de: "+media_final);
        }
    }
}
