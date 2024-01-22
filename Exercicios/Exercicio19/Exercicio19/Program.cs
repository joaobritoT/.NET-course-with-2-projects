// Dado um conjunto de numeros inteiros inseridos pelo utilizador, faca um algoritimo que calcule a media dos valores maiores que 4

namespace Exercicio19{
    class Program{
        static void Main(string[]args){
            int quantidade;
            int i = 0;
            double n;
            double soma =0;
            double media=0;
            List<double> valores = new List<double>();

            Console.WriteLine("quantos numeros deseja digitar?: ");
            quantidade = int.Parse(Console.ReadLine());

            while(i<quantidade){
                Console.WriteLine($"Digite o [{i+1}] numero: ");
                n = double.Parse(Console.ReadLine());
                i++;

                if(n>4){
                    valores.Add(n);
                }

            }
            if(valores.Count()>=1){
                for(i=0;i<valores.Count();i++){
                    soma+=valores[i];
                }
                media = soma / valores.Count();
                Console.WriteLine("A media dos valores (maiores que 4) eh de: "+ Math.Round(media,2));
            }
            else{
                Console.WriteLine("Nenhum valor maior que 4 digitado");
            }
           
            
            
            
        }
    }
}
