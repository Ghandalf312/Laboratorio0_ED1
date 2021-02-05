using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioI.Models.Storage
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public List<ClienteModelo> listaClientes;
        private Singleton()
        {
            listaClientes = new List<ClienteModelo>();
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
