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
        private string ruta/*= "datosAconsejados.dat"*/;
        public AconsejadoDA()
        {
            
        }


        public bool registrarAconsejado(Aconsejado a)
        {
            //FileStream fs = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            //BinaryFormatter bf = new BinaryFormatter();
            //try
            //{
            //    bf.Serialize(fs, a);
            //    fs.Close();
            //    return true;
            //} catch (Exception excep)
            //{
            //    return false;
            //}
            try
            {
                MySqlConnection conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();

                string insertar = "INSERT INTO Aconsejado (IdAconsejado,NombreCompleto,FechaNacimiento,Telefono,Correo,Direccion,Especialidad,Ciclo,Observaciones,Estado)" +
                                  "VALUES (" + a.Codigo.ToString() + ",'" + a.NombreCompleto + "','" + a.FechaNacimiento.ToString() + "'," + a.Telefono + ",'" + a.Correo + "','" + a.Direccion + "','" + a.Especialidad + "'," + a.Ciclo.ToString() + ",'" + a.Observaciones + "','" + a.Estado + "');";        //+
                                  //"WHERE IdAconsejado NOT IN (SELECT IdAconsejado FROM Aconsejado WHERE IdAconsejado = " + a.Codigo.ToString() +");";

                cmd.Connection = conn;
                cmd.CommandText = insertar;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            } catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool modificarAconsejado(Aconsejado a/*, string campoMantenido*/)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();

                string modificar = "UPDATE Aconsejado SET (IdAconsejado,NombreCompleto,FechaNacimiento,Telefono,Correo,Direccion,Especialidad,Ciclo,Observaciones,Estado)" +
                                  "values (" + a.Codigo.ToString() + "," + a.NombreCompleto + "," + a.FechaNacimiento.ToString() + "," + a.Telefono + "," + a.Correo + "," + a.Direccion + "," + a.Especialidad + "," + a.Ciclo.ToString() + "," + a.Observaciones + "," + a.Estado + ")" +
                                  "WHERE NOT EXISTS (SELECT IdAconsejado FROM Aconsejado WHERE IdAconsejado = '" + a.Codigo.ToString() + "'); ";
                /*FALTA ESPECIFICAR COMO REDACTAR LA SENTENCIA*/


                cmd.Connection = conn;
                cmd.CommandText = modificar;
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
                MySqlConnection conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();

                string eliminar = "DELETE FROM Aconsejado SET (IdAconsejado,NombreCompleto,FechaNacimiento,Telefono,Correo,Direccion,Especialidad,Ciclo,Observaciones,Estado)" +
                                  "values (" + a.Codigo.ToString() + "," + a.NombreCompleto + "," + a.FechaNacimiento.ToString() + "," + a.Telefono + "," + a.Correo + "," + a.Direccion + "," + a.Especialidad + "," + a.Ciclo.ToString() + "," + a.Observaciones + "," + a.Estado + ")" +
                                  "WHERE NOT EXISTS (SELECT IdAconsejado FROM Aconsejado WHERE IdAconsejado = '" + a.Codigo.ToString() + "'); ";
                /*FALTA ESPECIFICAR COMO REDACTAR LA SENTENCIA*/


                cmd.Connection = conn;
                cmd.CommandText = eliminar;
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
            //FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            //BinaryFormatter bf = new BinaryFormatter();
            //while (true)
            //{
            //    try
            //    {
            //        Aconsejado a = (Aconsejado)bf.Deserialize(fs);
            //        lista.Add(a);
            //    } catch (Exception excep)
            //    {
            //        fs.Close();
            //        break;
            //    }
            //}
            //return lista;

            try
            {
                MySqlConnection conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();

                string query = "SELECT * from Aconsejado";

                cmd.Connection = conn;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Aconsejado a = new Aconsejado();
                    a.Codigo = Int32.Parse(reader.GetString("IdAconsejado"));
                    a.NombreCompleto = reader.GetString("NombreCompleto");
                    a.FechaNacimiento = DateTime.Parse(reader.GetString("FechaNacimiento"));
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
