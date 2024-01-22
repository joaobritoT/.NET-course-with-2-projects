

namespace Condicoes{
    class Program{
        static void Main(string[]args){

            Console.WriteLine("Insira sua idadae:");
            int idade = int.Parse(Console.ReadLine());
            if(idade<2){
                Console.WriteLine("Eh um BB");
            }else if(idade<10){
                Console.WriteLine("eh uma crianca");
            }else if(idade <20){
                Console.WriteLine("eh um adolescente");
            }else if(idade <50){
                Console.WriteLine("Eh um adulto");
            }else{
                Console.WriteLine("EH um idoso");
            }
        }
    }
}