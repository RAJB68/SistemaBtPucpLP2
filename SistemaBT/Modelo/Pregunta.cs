using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pregunta
    {
        private int idPregunta;
        private string descripcion;
        private string respuesta;
        private double puntaje;
        private string estado;

        public int IdPregunta { get => idPregunta; set => idPregunta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public double Puntaje { get => puntaje; set => puntaje = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
