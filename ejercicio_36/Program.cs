using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string codSucursal = "";
            string codSucursalAnterior = "";
            string producto = "";
            int cant = 0;
            int listOfSucursales = 0;
            int maxVentas = 0;
            int sumVentas = 0;
            string maxCodSucursal = "";
            Console.WriteLine("ingrese la cantidad de sucursales a leer");
            listOfSucursales =  int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el codigo de la sucursal");
            codSucursal =  Console.ReadLine();
            codSucursalAnterior = codSucursal;
            for (int i = 0; i < listOfSucursales; i++)
            {   
                Console.WriteLine($"sucursal a leer N°{i+1}");
                while (codSucursalAnterior == codSucursal)
                {
                    Console.WriteLine("ingrese el nombre del producto");
                    producto =  Console.ReadLine();
                    Console.WriteLine("ingrese la cantidad de productos vendidos");
                    cant =  int.Parse(Console.ReadLine());
                    sumVentas = cant + sumVentas;
                    Console.WriteLine("ingrese el codigo de la sucursal");
                    codSucursal =  Console.ReadLine();
                }
                codSucursalAnterior = codSucursal;
                if (sumVentas>maxVentas)
                {
                    maxVentas=sumVentas;
                    maxCodSucursal = codSucursal;
                }
                Console.WriteLine("La cantidad total de la sucursal es = "+sumVentas);
                
            }
            Console.WriteLine($"la sucursal que mas vendio es {maxCodSucursal}, con {maxVentas}");
        }
    }
}
