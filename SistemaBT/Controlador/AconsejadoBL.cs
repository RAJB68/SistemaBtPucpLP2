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
    public class AconsejadoBL
    {
        private AconsejadoDA accesoDatosAconsejado;

        public AconsejadoBL()
        {
            accesoDatosAconsejado = new AconsejadoDA();
        }

        public bool registrarAconsejado(Aconsejado a)
        {
            return accesoDatosAconsejado.registrarAconsejado(a);
        }

        public BindingList<Aconsejado> listarAconsejados()
        {
            return accesoDatosAconsejado.devolverLista();
        }

    }
}
