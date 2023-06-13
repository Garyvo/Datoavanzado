using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datosavanzado.Entities
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fechaingreso { get; set; }
        public int Grado { get; set; }
        public double Promedio { get; set; }
    }
}
