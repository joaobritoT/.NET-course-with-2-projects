//faca um programa que receba um valor que eh o valor pago, um segundo valor que eh o preco final do produto e retorne o troco a ser dado


namespace Exercicio04{
    class Program{
        static void Main(string[]args){
            double preco_produto;
            double valor_pago;
            double troco;

            Console.WriteLine("Qual o valor do produto: ");
            preco_produto = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor pago: ");
            valor_pago = double.Parse(Console.ReadLine());

            if(valor_pago >= preco_produto){
                troco = valor_pago - preco_produto;
                Console.WriteLine("Troco a ser dado: "+troco);
            }
            else{
                Console.WriteLine("Nao eh possivel finalizar a operacao pois o preco pago eh menor que o valor do produto");
            }
        }
    }
}
