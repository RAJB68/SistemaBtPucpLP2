using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CriterioXEncuesta
    {
        private int idCriterioXEncuesta;
        private int idCriterio;
        private double puntaje;
        public int IdCriterioXEncuesta { get => idCriterioXEncuesta; set => idCriterioXEncuesta = value; }
        public int IdCriterio { get => idCriterio; set => idCriterio = value; }
        public double Puntaje { get => puntaje; set => puntaje = value; }
    }
}
