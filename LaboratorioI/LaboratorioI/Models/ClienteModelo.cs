using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioI.Models
{
    public class ClienteModelo
    {
        public string nombreC { get; set; }
        public string apellidoC { get; set; }
        public string telefonoC { get; set; }
        public string descripcionC { get; set; }
        public List<Cliente> ClientesLista = new List<Cliente>();
    }
}
