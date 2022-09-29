using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace APIPRUEBAS.Models
{
    public partial class Materia
    {
      
        public int IdMateria { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
