using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace AccesoDatos
{
    public class AconsejadoDA
    {
        private string ruta/*= "datosAconsejados.dat"*/;
        public bool registrarAconsejado(Aconsejado a)
        {
            FileStream fs = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(fs, a);
                fs.Close();
                return true;
            } catch (Exception excep)
            {
                return false;
            }
        }

        public BindingList<Aconsejado> devolverLista()
        {
            BindingList<Aconsejado> lista = new BindingList<Aconsejado>();
            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            while (true)
            {
                try
                {
                    Aconsejado a = (Aconsejado)bf.Deserialize(fs);
                    lista.Add(a);
                } catch (Exception excep)
                {
                    fs.Close();
                    break;
                }
            }
            return lista;
        }
    }
}
