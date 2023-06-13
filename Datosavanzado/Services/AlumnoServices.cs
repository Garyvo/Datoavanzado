using Datosavanzado.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datosavanzado.Services
{
    public class AlumnoServices
    {
        public Alumno Agregar()
        {
            try
            {
                Alumno alumno = new Alumno()
                {
                    Nombre = "Majo",
                    Fechaingreso = DateTime.Now,
                    Grado = 3,
                    Promedio = 7,
                };
                return alumno;
            }
            catch (Exception ex)
            {

                throw new Exception("Sucedio un error :c" + ex.Message);
            }

            
        }

        public void Imprimir(Alumno request)
        {
            try
            {

                Console.WriteLine("El nombre es: " + request.Nombre);
                Console.WriteLine("La fecha de ingreso es: " + request.Fechaingreso);
                Console.WriteLine("El grado es: " + request.Grado);
                Console.WriteLine("El promedio es: " + request.Promedio);

            }
            catch (Exception ex)
            {

                throw new Exception("Sucedio un error :c " + ex.Message);
            }
        }

        public bool ValidarProm(double cal)
        {
            bool validar = false;
            if(cal>=7)
            {
                validar = true;
            }
            return validar;
        }
    }
}
