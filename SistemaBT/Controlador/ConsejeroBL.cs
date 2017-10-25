using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;

namespace Controlador
{
   public  class ConsejeroBL
    {
        private ConsejeroDA consejeroDataAccess;

        public ConsejeroBL()
        {
            consejeroDataAccess = new ConsejeroDA();
        }
        public void registrarConsejero(Consejero c)
        {
            bool exito = false;
            exito = consejeroDataAccess.DAregistrarConsejero(c);
        }
    }
}
