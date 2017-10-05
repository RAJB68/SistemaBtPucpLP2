using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Presentacion: Actividad
    {
        private int idPresentacion;
        private string descripcion;
        private DateTime fecha;
        private string resultado;
        public int IdPresentacion { get => idPresentacion; set => idPresentacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Resultado { get => resultado; set => resultado = value; }
    }
}
