using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using System.ComponentModel;

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

        public BindingList<Consejero> leerConsejeros()
        {
            return consejeroDataAccess.leerConsejeros();
        }

        public BindingList<Consejero> listarConsejerosPorId(int id)
        {
            return consejeroDataAccess.listarConsejerosPorID(id);
        }
        public BindingList<Consejero> listarConsejerosPorNombre(string nombre)
        {
            return consejeroDataAccess.listarConsejerosPorNombre(nombre);
        }

        public bool modificarConsejero(Consejero c)
        {
            return consejeroDataAccess.modificarConsejero(c);
        }

        public bool eliminarConsejero(int codConsejero)
        {
            return consejeroDataAccess.elimnarConsejero(codConsejero);
        }

    }
}
