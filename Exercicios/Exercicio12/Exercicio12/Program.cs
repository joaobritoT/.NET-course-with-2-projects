//refaca o exercicio anterior usando switch case

namespace Exercicio12{
    class Program{
        static void Main(string[]args){
            string codigo ="";
            string produto;

            Console.WriteLine("Digite o codigo do produto: ");
            codigo = Console.ReadLine();

            switch(codigo){
                case "001":
                    produto = "Parafuso";
                    break;
                case "002":
                    produto = "Porca";
                    break;
                case "003":
                    produto = "Prego";
                    break;
                default:
                    produto = "Nao definido";
                    break;
            }

            Console.WriteLine("O codigo "+codigo+" representa o seguinte produto: " + produto);
            
        }
    }
}