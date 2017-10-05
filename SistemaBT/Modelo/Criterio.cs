using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Criterio
    {
        private int idCriterio;
        private string nombre;
        private string descripcion;

        public int IdCriterio { get => idCriterio; set => idCriterio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
