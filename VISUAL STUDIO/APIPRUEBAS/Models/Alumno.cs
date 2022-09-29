using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace APIPRUEBAS.Models
{
    public partial class Alumno
    {
      
        public int IdAlumno { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido_Pa { get; set; } = null!;
        public string Apellido_Ma { get; set; } = null!;
        public int Edad { get; set; }
        public string Sexo { get; set; } = null!;

     
    }
}
