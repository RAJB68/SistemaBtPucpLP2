using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;    

namespace Modelo
{
    class Match
    {
        private int idMatch;
        private DateTime fechaAsignacion;
        private DateTime fechaFin;
        private string estado;
        private BindingList<Encuesta> encuestas = new BindingList<Encuesta>();
        private BindingList<Aconsejado> aconsejados = new BindingList<Aconsejado>();

        public int IdMatch { get => idMatch; set => idMatch = value; }
        public DateTime FechaAsignacion { get => fechaAsignacion; set => fechaAsignacion = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Estado { get => estado; set => estado = value; }
        public BindingList<Encuesta> Encuestas { get => encuestas; set => encuestas = value; }
        internal BindingList<Aconsejado> Aconsejados { get => aconsejados; set => aconsejados = value; }
    }
}
