/* faca um programa que retorne o nome de um produto a partir de um codigo do mesmeo, considere os seguintes codigos:
a. 001 - parafuso
b. 002 - porca
c. 003 - prego
d. qualquer outro codigo - "nao definido"
*/

namespace Exercicio11{
    class Program{
        static void Main(string[]args){
            string codigo = "";
            string produto = "";

            Console.WriteLine("Digite o codigo do produto: ");
            codigo = Console.ReadLine();

            if(codigo == "001"){
                produto = "parafuso";
            }else if(codigo == "002"){
                produto = "porca";
            }else if(codigo == "003"){
                produto = "prego";
            }else{
                produto ="Nao definido";
            }
            Console.WriteLine("O codigo " + codigo + " representa o produto: " + produto);
        }
    }
}