using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Modelo
{
    public class Encuesta
    {
        private int idEncuesta;
        private string descripcion;
        private string link;
        private string dirigidoA;
        private double duracion;
        private string estado;
        private BindingList<Pregunta> preguntas = new BindingList<Pregunta>();
        private BindingList<CriterioXEncuesta> puntajeEnCriterios = new BindingList<CriterioXEncuesta>();

        public int IdEncuesta { get => idEncuesta; set => idEncuesta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Link { get => link; set => link = value; }
        public string DirigidoA { get => dirigidoA; set => dirigidoA = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public string Estado { get => estado; set => estado = value; }
        internal BindingList<Pregunta> Preguntas { get => preguntas; set => preguntas = value; }
        internal BindingList<CriterioXEncuesta> PuntajeEnCriterios { get => puntajeEnCriterios; set => puntajeEnCriterios = value; }
    }
}
