using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantAlumnos = 0;
            int notaMateria = 0;
            int acumNotaMateria = 0;
            int alumnosApproved = 0;
            int maxAlumosAprovados = 0;
            int minAlumnosAprovados = 2147483647;
            int materiaMayorIndice = 0;
            int materiaMenorIndice = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Curso N°{i+1}");
                Console.WriteLine($"ingrese la cantidad de alumnos del curso N° {i+1}");
                cantAlumnos =  int.Parse(Console.ReadLine());
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Materia N°{j+1}");
                    for (int k = 0; k < cantAlumnos; k++)
                    {
                        Console.WriteLine($"ingrese ingrese la nota del alumno N° {k+1}");
                        notaMateria = int.Parse(Console.ReadLine());
                        acumNotaMateria = acumNotaMateria + notaMateria;
                        if (notaMateria>6)
                        {
                            alumnosApproved++;
                        }
                    }
                    Console.WriteLine($"el promedio de notas de la materia N°{j+1} es {acumNotaMateria/cantAlumnos}");
                    Console.WriteLine($"la cantidad de alumnos aprovados de la materia N°{j+1} es {alumnosApproved}");
                    Console.WriteLine($"la cantidad de alumnos desaprovados de la materia N°{j+1} es {cantAlumnos-alumnosApproved}");
                    if (alumnosApproved>maxAlumosAprovados)
                    {
                        maxAlumosAprovados = alumnosApproved;
                        materiaMayorIndice = j+1;
                    }
                    if (alumnosApproved<minAlumnosAprovados)
                    {
                        minAlumnosAprovados=alumnosApproved; 
                        materiaMenorIndice = j+1;  
                    }
                    acumNotaMateria = 0;
                    alumnosApproved = 0;
                }
                Console.WriteLine($"Materia con menor indice de aprovacion = N°{materiaMenorIndice}");
                Console.WriteLine($"Materia con mayor indice de aprovacion = N°{materiaMayorIndice}");
            }
        }
    }
}
