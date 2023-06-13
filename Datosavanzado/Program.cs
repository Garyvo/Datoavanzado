using System;
using Datosavanzado.Services;
using Datosavanzado.Entities;

namespace Datosavanzado
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            AlumnoServices servicio = new AlumnoServices();
            Alumno alumno1 = servicio.Agregar();
            servicio.Imprimir(alumno1);

            if (servicio.ValidarProm(alumno1.Promedio))
            {
                Console.WriteLine("La calificacion es aprobatoria");
            }
            else Console.WriteLine("La calificacion es reprobatoria");
        }
    }
}
