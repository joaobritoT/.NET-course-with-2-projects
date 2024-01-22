// Crie um algoritimo que le o nome de uma pessoa e escreve "ola" seguido de seu nome.


namespace Exercicio01{
    class Program{
        static void Main(string[]args){
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Ola, " + nome +" prazer!");
        }
    }
}