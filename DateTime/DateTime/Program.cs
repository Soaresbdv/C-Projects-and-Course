using System;
namespace Course{
    class Program{
        static void Main(string[] args){
            
            DateTime d1 = DateTime.Now; // '.Now' instancia o objeto no instante que foi executado
            DateTime d2 = new DateTime(14, 08, 2023); // Ele possui diversas sobrecargas no construtor
            DateTime d3 = new DateTime(14, 08, 2023, 15, 38, 3); // Ele possui diversas sobrecargas no construtor
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today; // Gera uma data do momento de execução do compilador às 00:00h
            DateTime d6 = DateTime.UtcNow;
            DateTime d7 = DateTime.Parse("200-08-15");
            DateTime d8 = DateTime.Parse("200-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d1.Ticks); // '.Tick' instancia a função em 100 nano segundos desde o dia 1/jan

            
        }
    }
}