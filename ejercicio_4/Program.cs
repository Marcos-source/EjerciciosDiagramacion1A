using System;

//4.	Se ingresa 3 números que representan horas, minutos y segundos. 
// Se pide informar el resultado expresado en segundos. Determinar qué tipo de valor es el aconsejable para los datos solicitados

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos = 0;
            int acumulador = 0;
            Console.WriteLine("ingrese las horas");
            segundos = int.Parse(Console.ReadLine());
            acumulador = acumulador + (segundos * 3600);
            Console.WriteLine("ingrese los minutos");
            segundos = int.Parse(Console.ReadLine());
            acumulador = acumulador + (segundos * 60);
            Console.WriteLine("ingrese los segundos");
            segundos = int.Parse(Console.ReadLine());
            acumulador = acumulador + segundos;
            Console.WriteLine($"El resultado es: {acumulador}");
        }
    }
}
