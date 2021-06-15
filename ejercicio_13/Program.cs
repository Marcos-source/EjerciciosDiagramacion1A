using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13.	Leer dos fechas en formato DDMMAAAA. Informar cuál de ellas es la menor  o si son iguales.
            int dateOne = 0;
            int dateTwo = 0;
            Console.WriteLine("ingrese una fecha en el siguiente formato DDMMAAAA");
            dateOne = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otra fecha en el siguiente formato DDMMAAAA");
            dateTwo = int.Parse(Console.ReadLine());
            
            if ((dateOne%10000)>0 && (dateTwo%10000)>0)
            {
                if ((dateOne%10000) > (dateTwo%10000)) {
                Console.WriteLine("La primer fecha es mayor");
                } else if((dateTwo%10000) > (dateOne%10000)) {
                Console.WriteLine("La segunda fecha es mayor");
                } else {

                int mesUno = (dateOne%1000000)/10000;
                int mesDos = (dateTwo%1000000)/10000;

                if (mesUno>0 && mesUno<13 && mesDos>0 && mesDos<13) {
                    if (mesUno > mesDos) {
                        Console.WriteLine("La primer fecha es mayor");
                    }else if (mesUno < mesDos) {
                        Console.WriteLine("La segunda fecha es mayor");
                    }else {
                        if (mesUno == 2 && dateOne/1000000 > 0 && dateOne/1000000 < 29 && mesDos == 2 && dateTwo/1000000 > 0 && dateTwo/1000000 < 29) {
                            if (dateOne/1000000 > dateTwo/1000000) {
                                Console.WriteLine("La primer fecha es mayor");
                            }else if (dateOne/1000000 < dateTwo/1000000) {
                                Console.WriteLine("La segunda fecha es mayor");
                            }else{
                                 Console.WriteLine("las fechas son iguales");
                            }
                        }else if ((mesUno)%2 == 0 && dateOne/1000000 > 0 && dateOne/1000000 < 31 && (mesDos)%2 == 0 && dateTwo/1000000 > 0 && dateTwo/1000000 < 31) {
                             if (dateOne/1000000 > dateTwo/1000000) {
                                Console.WriteLine("La primer fecha es mayor");
                            }else if (dateOne/1000000 < dateTwo/1000000) {
                                Console.WriteLine("La segunda fecha es mayor");
                            }else{
                                 Console.WriteLine("las fechas son iguales");
                            }
                        }else if ((mesUno)%2 != 0 && dateOne/1000000 > 0 && dateOne/1000000 < 32 && (mesDos)%2 != 0 && dateTwo/1000000 > 0 && dateTwo/1000000 < 32) {
                            if (dateOne/1000000 > dateTwo/1000000) {
                                Console.WriteLine("La primer fecha es mayor");
                            }else if (dateOne/1000000 < dateTwo/1000000) {
                                Console.WriteLine("La segunda fecha es mayor");
                            }else{
                                 Console.WriteLine("las fechas son iguales");
                            }
                        }else{
                            Console.WriteLine("el dia no coincide con un mes real");
                        }
                    }
                }else {
                    Console.WriteLine("el mes no puede ser negativo");
                }

            } 
            } else {
                Console.WriteLine("el año no puede ser negativo");
            } 
        }
    }
}
