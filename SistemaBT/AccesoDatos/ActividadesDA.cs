using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class ActividadesDA
    {
        private MySqlConnection conexion;
        private string servidor;
        private string bd;
        private string uid;
        private string password;

        public ActividadesDA()
        {
            servidor = "200.16.7.96";
            bd = "inf282g3";
            uid = "inf282g3";
            password = "wWVyTf4lAXvjlZlC";
            string connectionString;
            connectionString = "SERVER = " + servidor + "; " + "DATABASE = " +
                                bd + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            conexion = new MySqlConnection(connectionString);
        }

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se puede conectar al servidor. Mandar mail a Paz");
                        break;

                    case 1045:
                        MessageBox.Show("Usuario o contrasena equivocados.");
                        break;
                }
                return false;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public BindingList<Actividad> listarActividades(int codConsejero)
        {
            BindingList<Actividad> lista = new BindingList<Actividad>();
            string query = "SELECT * FROM Actividad WHERE IdConsejero = " + codConsejero;
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = query;


                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Actividad a = new Actividad(); ;
                    a.IdActividad = dr.GetInt32("IdActividad");
                    a.Titulo = dr.GetString("Titulo");
                    a.Descripcion = dr.GetString("Descripcion");
                    a.TipoActividad = dr.GetString("TipoActividad");
                    a.Destinatario = dr.GetString("Destinatario");
                    a.FechaProgramada = dr.GetDateTime("FechaProgramada");
                    a.Comentario = dr.GetString("Comentario");
                    a.Estado = dr.GetString("Estado");

                    lista.Add(a);


                }
                this.CerrarConexion();
            }
            return lista;
        }

        public void agregarActividad(int codConsejero,Actividad a)
        {
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "agregarActividad";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_id_Consejero", codConsejero);
                cmd.Parameters.AddWithValue("_titulo", a.Titulo);
                cmd.Parameters.AddWithValue("_descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("_tipoActividad", a.TipoActividad);
                cmd.Parameters.AddWithValue("_destinatario", a.Destinatario);
                cmd.Parameters.AddWithValue("_fechaProg", a.FechaProgramada);
                cmd.Parameters.AddWithValue("_comentario", a.Comentario);
                cmd.Parameters.AddWithValue("_estado", a.Estado);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                this.CerrarConexion();
            }
        }

        public void eliminarActividad(int codActividad)
        {
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "eliminarActividad";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_id_Actividad", codActividad);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                this.CerrarConexion();
            }
        }
    }
}
