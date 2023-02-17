using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public int Apellidos { get; set; }

        public string RazonSocial { get; set; }

        public int NumeroDocumento { get; set; }

        public int IdTipoCliente { get; set; }

        public int MyProperty { get; set; }
    }
}
