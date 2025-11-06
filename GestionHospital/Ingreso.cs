using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    public class Ingreso
    {
        public int Id { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaAlta { get; set; } // Puede estar en curso
        public string Motivo { get; set; }
        public string Habitacion { get; set; }
        public string Especialidad { get; set; }

        public Ingreso(int id, DateTime fechaIngreso, DateTime? fechaAlta ,string motivo, string habitacion, string Especialidad)
        {
            this.Id = id;
            this.FechaAlta = fechaAlta;
            this.FechaIngreso = fechaIngreso;
            this.Motivo = motivo;
            this.Habitacion = habitacion;
            this.Especialidad = Especialidad;
        }
    }
}
