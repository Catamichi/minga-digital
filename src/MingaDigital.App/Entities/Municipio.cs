using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MingaDigital.App.Entities
{
    public class Municipio
    {
        public Int32 MunicipioId { get; set; }
        
        [Required]
        [Index(IsUnique = true)]
        public String Nombre { get; set; }
    }
}