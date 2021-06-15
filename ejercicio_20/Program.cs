using System;

namespace ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // 20.	Se conoce la cantidad total de preguntas realizadas y la cantidad de respuestas correctas de un test de nivel para ingresantes a la universidad.
            //  Se pide informar el porcentaje de respuestas correctas y una leyenda que indique el nivel obtenido según el siguiente criterio:
            // a.	Nivel 1  Porcentaje >=89
            // b.	Nivel 2  75<=Porcentaje<89
            // c.	Nivel 3  50<=Porcentaje<70
            // d.	Nivel 4  Porcentaje<50
            // ¿Qué error tiene este algoritmo?
            int answer = 0;
            int response = 0;
            double data = 0;
            Console.WriteLine("ingrese el total de preguntas");
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el total de respuestas acertadas");
            response = int.Parse(Console.ReadLine());
            if (response > answer) {
                Console.WriteLine("las respuestas no deben ser mayor a las preguntas");
            }else{
                if (answer < 1 && response < 1) {
                Console.WriteLine("las preguntas y las respouestas no pueden ser negativos o nulos");
                }
                else
                {
                    data = (100 * response) / answer;
                    if (data >= 89)
                    {
                        Console.WriteLine("nivel 1: "+ data +"%");
                    }
                    else if (data < 89 && data >= 75)
                    {
                        Console.WriteLine("nivel 2: "+ data +"%");
                    }
                    else if (data < 75 && data >= 50)
                    {
                        Console.WriteLine("nivel 3: "+ data +"%");
                    }
                    else if (data < 50)
                    {
                        Console.WriteLine("nivel 4: "+ data +"%");
                    }
                    else
                    {
                        Console.WriteLine("error catastrofico");
                    }
                }
            }
        }
    }
}
