using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13.	Leer dos fechas en formato DDMMAAAA. Informar cuál de ellas es la menor  o si son iguales.
            int date = 0;
            int mes = 0;
            int dia = 0;
            int anio =0;
            Console.WriteLine("ingrese otra fecha en el siguiente formato DDMMAAAA");
            date = int.Parse(Console.ReadLine());
            dia = date/1000000;
            mes = (date%1000000)/10000;
            anio = date%10000;;
            Console.WriteLine(dia+"/"+mes+"/"+anio);

            if ( mes >= 1 && mes <= 12 )
                {
                    switch ( mes )
                    {
                        case 1 : if ( dia >= 1 && dia <= 31 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case  2 : if( anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0 )
                                    if ( dia >= 1 && dia <= 29 )
                                        Console.WriteLine( "FECHA CORRECTA" );
                                    else
                                        Console.WriteLine( "FECHA INCORRECTA" );
                                else
                                    if ( dia >= 1 && dia <= 28 )
                                        Console.WriteLine( "FECHA CORRECTA" );
                                    else
                                        Console.WriteLine( "FECHA INCORRECTA" );
                                        break;
                        case 3 : if ( dia >= 1 && dia <= 31 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case 4 : if ( dia >= 1 && dia <= 30 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case 5 : if ( dia >= 1 && dia <= 31 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case 6 : if ( dia >= 1 && dia <= 30 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case 7 : if ( dia >= 1 && dia <= 31 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case 8 : if ( dia >= 1 && dia <= 31 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case 9 : if ( dia >= 1 && dia <= 30 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case 10 : if ( dia >= 1 && dia <= 31 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case 11 : if ( dia >= 1 && dia <= 30 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                        case 12 : if ( dia >= 1 && dia <= 31 )
                                    Console.WriteLine( "FECHA CORRECTA" );
                                else
                                    Console.WriteLine( "FECHA INCORRECTA" );
                                break;
                    }
                }
                else
                    Console.WriteLine( "FECHA INCORRECTA" );
        }
    }
}
