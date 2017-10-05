using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Cumpleaños: Actividad
    {
        private int idCumpleaños;
        private string destinatario;
        private DateTime fecha;
        private string descripcion;
        public int IdCumpleaños { get => idCumpleaños; set => idCumpleaños = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
