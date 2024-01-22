/* o  preco de um carro eh calculado pela soma do preco de fabrica com o preco dos impostos (45% de preco de fabrica) e a procentagem do revendedor(28% do preco de fabrica)
faca um programa que leia o nome do automovel e o preco de fabrica e escreva o valor final do carro*/

namespace Exercicio15{
    class Program{
        static void Main(string[]args){
            string nome_do_carro;
            double valor_de_fabrica;
            double impostos;
            double comissao;
            double valor_final;

            Console.WriteLine("Digite o nome do carro: ");
            nome_do_carro = Console.ReadLine();

            Console.WriteLine("Qual o valor de fabrica deste carro?: ");
            valor_de_fabrica = int.Parse(Console.ReadLine());

            impostos = 0.45 * valor_de_fabrica;
            comissao = 0.28 * valor_de_fabrica;

            valor_final =  valor_de_fabrica + impostos + comissao;

            Console.WriteLine("O valor do veiculo: "+nome_do_carro+" \nCalculando impostos e comissao eh de: "+valor_final);
            

        }
    }
}
