

namespace Variaveis{
    class Program{
        static void Main(string[]args){
            //char sempre um caractere
            char caractere = 'c';
            //usamos string para declarar uma variarel com mais de 1 caractere
            string frase = "Ola, sou uma frase";
            //para valores interios, declaramos a variavel como int
            int n1 = 10;
            //para variaveis decimais, delcaramos como double
            double n2 = 10.4;
            //para valores booleanos, utilizamos bool
            bool verdade = true;
            bool mentira = false;

            Console.WriteLine($"[{caractere}],[{frase}],[{n1}],[{n2}],");

        }
    }
}