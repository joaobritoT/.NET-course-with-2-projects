

namespace CicloFor{
    class Program{
        static void Main(string[]args){
            int acumuladora = 0;
            int i;
            int numero;

            for(i=0;i< 4;i++){
                Console.WriteLine("Digite um numero");
                numero = int.Parse(Console.ReadLine());
                acumuladora +=numero;

            }
            Console.WriteLine("A soma de todos os numeros eh de" + acumuladora);
        }
    }
}