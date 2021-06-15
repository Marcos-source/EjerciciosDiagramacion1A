using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int acum = 0;
            int counter = 0;
            Console.WriteLine("Ingre se el numero a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingre se el numero b");
            b = int.Parse(Console.ReadLine());
            // for (int i = 0; i < b; i++) {
            
            // }
            acum = a;
            counter = a;
            while (counter!=0)
            {
                if (a-b < 0)
                {
                    counter=0;
                }else{
                    a-=b;
                }
            }
            Console.WriteLine($"{acum} dividio {b} es igual a {counter} y sobra {a}");
        }
    }
}
