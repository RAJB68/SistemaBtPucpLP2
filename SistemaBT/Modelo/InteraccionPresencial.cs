using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class InteraccionPresencial
    {
        private int idInteraccion;
        private string detalle;
        public int IdInteraccion { get => idInteraccion; set => idInteraccion = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}
