using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LaboratorioI.Models
{
    public class ClienteModelo
    {
        [Required]
        public string nombreC { get; set; }
        [Required]
        public string apellidoC { get; set; }
        public string telefonoC { get; set; }
        public string descripcionC { get; set; }

        
    }
}
