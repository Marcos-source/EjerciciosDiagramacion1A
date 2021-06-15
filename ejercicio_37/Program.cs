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
            string maxCodProd = "";
            int minVentas = 2147483647;
            string minCodProd = "";
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
                    if (cant>maxVentas)
                    {
                        maxVentas = cant;
                        maxCodProd = producto;
                    }
                    if (cant<minVentas)
                    {
                        minVentas = cant;
                        minCodProd = producto;
                    }
                }
                Console.WriteLine($"el producto mas vendio es {maxCodProd}, con {maxVentas} ventas");
                Console.WriteLine($"el producto menos vendio es {minCodProd}, con {minVentas} ventas");
                codSucursalAnterior = codSucursal;                
            }
        }
    }
}
