using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.ComponentModel;
using Modelo;

namespace Controlador
{
    public class ActividadesBL
    {
        private ActividadesDA AccesoActividades = new ActividadesDA();

        public BindingList<Actividad>  listarActividades(int codConsejero)
        {
            return AccesoActividades.listarActividades(codConsejero);
        }

        public void agregarActividad(int codConsejero,Actividad a)
        {
            AccesoActividades.agregarActividad(codConsejero,a);
        }

        public void eliminarActividad(int codActividad)
        {
            AccesoActividades.eliminarActividad(codActividad);
        }
    }
}
