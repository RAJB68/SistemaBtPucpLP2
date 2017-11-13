using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class AconsejadoDA
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        public AconsejadoDA()
        {
            conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
            cmd = new MySqlCommand();
        }


        public bool registrarAconsejado(Aconsejado a)
        {
            try
            {
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "CREAR_ACONSEJADO";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_Id", a.Codigo.ToString());
                cmd.Parameters.AddWithValue("_nombre", a.NombreCompleto);
                cmd.Parameters.AddWithValue("_fecha", a.FechaNacimiento);
                cmd.Parameters.AddWithValue("_tel", a.Telefono.ToString());
                cmd.Parameters.AddWithValue("_email", a.Correo);
                cmd.Parameters.AddWithValue("_dir", a.Direccion);
                cmd.Parameters.AddWithValue("_esp", a.Especialidad);
                cmd.Parameters.AddWithValue("_ciclo", a.Ciclo.ToString());
                cmd.Parameters.AddWithValue("_obser", a.Observaciones);
                cmd.Parameters.AddWithValue("_estad", a.Estado);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            } catch(Exception e)
            {
                //System.Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool modificarAconsejado(Aconsejado a/*, string campoMantenido*/)
        {
            try
            {
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "MODIFICAR_ACONSEJADO";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_Id", a.Codigo.ToString());
                cmd.Parameters.AddWithValue("_nombre", a.NombreCompleto);
                cmd.Parameters.AddWithValue("_fecha", a.FechaNacimiento);
                cmd.Parameters.AddWithValue("_tel", a.Telefono.ToString());
                cmd.Parameters.AddWithValue("_email", a.Correo);
                cmd.Parameters.AddWithValue("_dir", a.Direccion);
                cmd.Parameters.AddWithValue("_esp", a.Especialidad);
                cmd.Parameters.AddWithValue("_cic", a.Ciclo.ToString());
                cmd.Parameters.AddWithValue("_obser", a.Observaciones);
                cmd.Parameters.AddWithValue("_estad", a.Estado);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool eliminarAconsejado(Aconsejado a/*, string campoMantenido*/)
        {
            try
            {
                conn.Open();


                cmd.Connection = conn;
                cmd.CommandText = "ELIMINAR_ACONSEJADO";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_id", a.Codigo.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public BindingList<Aconsejado> devolverLista()
        {
            BindingList<Aconsejado> lista = new BindingList<Aconsejado>();

            try
            {
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "LISTAR_ACONSEJADOS";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Aconsejado a = new Aconsejado();
                    a.Codigo = Int32.Parse(reader.GetString("IdAconsejado"));
                    a.NombreCompleto = reader.GetString("NombreCompleto");
                    a.FechaNacimiento = reader.GetDateTime("FechaNacimiento");
                    a.Telefono = Int32.Parse(reader.GetString("Telefono"));
                    a.Correo = reader.GetString("Correo");
                    a.Direccion = reader.GetString("Direccion");
                    a.Especialidad = reader.GetString("Especialidad");
                    a.Ciclo = Int32.Parse(reader.GetString("Ciclo"));
                    a.Observaciones = reader.GetString("Observaciones");
                    a.Estado = reader.GetString("Estado");
                    lista.Add(a);
                }
                return lista;

            } catch (Exception e)
            {
                return null;
            }
        }
    }
}