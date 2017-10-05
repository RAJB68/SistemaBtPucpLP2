using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    class Evento
    {
        private int idEvento;
        private string tipo;
        private string descripcion;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        public int IdEvento { get => idEvento; set => idEvento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}
