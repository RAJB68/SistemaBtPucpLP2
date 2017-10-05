using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Llamada
    {
        private int idLlamada;
        private int numeroContacto;
        private string detalle;

        public int IdLlamada { get => idLlamada; set => idLlamada = value; }
        public int NumeroContacto { get => numeroContacto; set => numeroContacto = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}
