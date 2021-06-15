using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota = 0;
            const int notaDeAprovacion = 6;
            Console.WriteLine("ingrese las 4 notas");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"ingrese la nota {i+1}");
                nota = nota + int.Parse(Console.ReadLine());
            }
            if ((nota/4) >= notaDeAprovacion)
            {
                Console.WriteLine($"Su nota es mayor a {notaDeAprovacion} usted aprobo");
            }else{
                Console.WriteLine($"Su nota es menor a {notaDeAprovacion} usted reprobo");
            }
        }
    }
}
