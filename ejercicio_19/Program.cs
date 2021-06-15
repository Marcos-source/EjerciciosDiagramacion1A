using System;

// 1.	Leer 4 números enteros, calcular la suma e informar el resultado

namespace EjerciciosCSharp
{
    class Program
    {
       static void Main(string[] args)
        {
            int date = 0;
            Console.WriteLine("ingrese un mes");
            date = int.Parse(Console.ReadLine());

            if (date > 12 || date<1) {
                Console.WriteLine("Error, Mes no valido");
            }else {
                switch (date)
                {
                    case 1: 
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 31 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                    break;
                    case 2: 
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 28 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                    break;
                    case 3: 
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 31 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                    break;
                    case 4: 
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 30 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                    break;
                    case 5: 
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 31 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                    break;
                    case 6: 
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 30 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                    break;
                    case 7: 
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 31 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                    break;
                    case 8:
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 31 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                     break;
                    case 9:
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 30 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                     break;
                    case 10:
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 31 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                     break;
                    case 11:
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 30 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                     break;
                    case 12:
                        Console.WriteLine("ingrese un dia");
                        date = int.Parse(Console.ReadLine());
                        if (date > 31 || date < 1) {
                            Console.WriteLine("Error, dia del mes no valido");
                        }else {
                            Console.WriteLine("Fecha Valida");
                        }
                     break;
                }
            }
        }
    }
}
