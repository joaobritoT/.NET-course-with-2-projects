//Leia a base e a altura de um triangulo e calcule sua area

namespace Exercicio05{
    class Program{
        static void Main(string[]args){
            double base_do_triangulo;
            double altura_do_triangulo;
            double area;

            Console.WriteLine("Digite a base do triangulo: ");
            base_do_triangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do triangulo: ");
            altura_do_triangulo = double.Parse(Console.ReadLine());

            area = base_do_triangulo * altura_do_triangulo / 2;

            Console.WriteLine("A area do triangulo eh de: "+area);
        }
    }
}