using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
using System.ComponentModel;

namespace Controlador
{
    public class MatchBL
    {
        private MatchDA accesoDatos;

        public MatchBL() { accesoDatos = new MatchDA(); }

        public bool registrarMatch(Match m)
        {
            return accesoDatos.registrarMatch(m);
        }

        public BindingList<Match> listarMatches()
        {
            return accesoDatos.listarMatches();
        }
    }
}
