/*Crie um programa que receba 3 valores que representarao os lados de um triangulo e verifique se os valores formam um triangulo e classifique esse triangulo como:

a. Equilatero(3 lados iguais)
b. Isoceles(2 lados iguais)
c. Escaleno(3 lados diferentes)

De notar que para formar um triangulo:
A. Nenhum lado pode ser igual a zero
B. Um nado nao pode ser maior que a soma dos outros 2 lados

*/




namespace Exercicio10{
    class Program{
        static void Main(string[]args){
            double a,b,c;
            bool verificacao = true;
            string classificacao ="";

            Console.WriteLine("Digite o primeiro lado do triangulo: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do triangulo: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do triangulo: ");
            c = double.Parse(Console.ReadLine());

            if(a == 0 || b == 0 || c == 0){
                verificacao = false;
            }else if(a > b + c || b > a+c || c> b+a){
                verificacao = true;
            }

            if(verificacao == true){
                if(a == b && a==c){
                    classificacao = "Equilatero";
                }else if(a == b || a == c || b ==c){
                    classificacao = "isoceles";
                }else if(a != b && a!= c && c!=b){
                    classificacao = "escaleno";
                }
            }else{
                Console.WriteLine("Impossivel formar um triangulo com os numeros fornecidos");
            }

            Console.WriteLine(classificacao);
        }
    }
}