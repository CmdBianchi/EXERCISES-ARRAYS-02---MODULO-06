using System;
namespace EXERCISES_ARRAYS__02___MODULO_06{
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) { // ----- > VETOR COM DOIS TIPOS DE ARGUMENTOS | DEVE TER CLASSE PARA QUE FUNCIONE 
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)  {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2"));
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
