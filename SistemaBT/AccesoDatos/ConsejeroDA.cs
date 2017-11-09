using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
   public  class ConsejeroDA
    {
        private MySqlConnection conexion;
        private string servidor;
        private string bd;
        private string uid;
        private string password;
        
        public ConsejeroDA()
        {
            servidor = "200.16.7.96";
            bd = "inf282g3";
            uid = "inf282g3";
            password = "wWVyTf4lAXvjlZlC";
            string connectionString;
            connectionString = "SERVER = " + servidor + "; " + "DATABASE = " + 
                                bd + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Convert Zero Datetime=True";
            conexion = new MySqlConnection(connectionString);
        }
        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }catch (MySqlException ex)
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
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DAregistrarConsejero(Consejero c)
        {

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "insertarConsejero";
                cmd.CommandType= System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_idConsejero", c.Codigo);
                cmd.Parameters.AddWithValue("_nombre", c.NombreCompleto);
                cmd.Parameters.AddWithValue("_fechaNac", c.FechaNacimiento);
                cmd.Parameters.AddWithValue("_especialidad", c.Especialidad);
                cmd.Parameters.AddWithValue("_grado", c.Grado);
                cmd.Parameters.AddWithValue("_tef", c.Telefono);
                cmd.Parameters.AddWithValue("_correo", c.Correo);
                cmd.Parameters.AddWithValue("_direccion", c.Direccion);
                cmd.Parameters.AddWithValue("_empresa", c.Empresa);
                cmd.Parameters.AddWithValue("_sector", c.Sector);
                cmd.Parameters.AddWithValue("_cargo", c.Cargo);
                cmd.Parameters.AddWithValue("_areaInt", c.AreasInteres1);
                cmd.Parameters.AddWithValue("_fechaIN", c.FechaIngreso);
                cmd.Parameters.AddWithValue("_obs", c.Observaciones);
                cmd.Parameters.AddWithValue("_estado", c.Estado);
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
            return true;
        }

        public BindingList<Consejero> leerConsejeros()
        {
            BindingList<Consejero> consejeros = new BindingList<Consejero>();

            string query = "SELECT * FROM Consejero";

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = query;


                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Consejero c = new Consejero(); ;
                    c.Codigo = dr.GetInt32("IdConsejero");
                    c.NombreCompleto=dr.GetString("NombreCompleto");
                   
                      c.FechaNacimiento=dr.GetDateTime("FechaNacimiento");
                    
                    c.Especialidad = dr.GetString("Especialidad");
                    c.Grado = dr.GetString("Grado");
                    c.Telefono = dr.GetInt32("Telefono");
                    c.Correo = dr.GetString("Correo");
                    c.Direccion = dr.GetString("Direccion");
                    c.Empresa = dr.GetString("Empresa"); 
                    c.Sector = dr.GetString("Sector");
                    c.Cargo = dr.GetString("Cargo");
                    c.AreasInteres1 = dr.GetString("AreasInteres");
                    c.FechaIngreso = dr.GetDateTime("FechaIngreso");
                    c.Observaciones = dr.GetString("Observaciones");
                    c.Estado = dr.GetString("Estado");

                    consejeros.Add(c);


                }







                this.CerrarConexion();
            }

            return consejeros;


        }

        public bool elimnarConsejero(int codConsej)
        {

            if (AbrirConexion())
            {
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "ELIMINAR_CONSEJERO";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_CODIGO", codConsej);

                cmd.ExecuteNonQuery();





                CerrarConexion();
                return true;
            }
            return false;
        }

        public bool modificarConsejero(Consejero c)
        {
            if (AbrirConexion())
            {
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "MODIFICAR_CONSEJERO";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;



                cmd.Parameters.AddWithValue("_CODIGO", c.Codigo);
                cmd.Parameters.AddWithValue("_NOMBRE", c.NombreCompleto);
                cmd.Parameters.AddWithValue("_FECHA_NAC", c.FechaNacimiento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("_TELEFONO", c.Telefono);
                cmd.Parameters.AddWithValue("_DIRECCION", c.Direccion);
                cmd.Parameters.AddWithValue("_ESPECIALIDAD", c.Especialidad);
                cmd.Parameters.AddWithValue("_GRADO", c.Grado);
                cmd.Parameters.AddWithValue("_CORREO", c.Correo);
                cmd.Parameters.AddWithValue("_EMPRESA",c.Empresa);
                cmd.Parameters.AddWithValue("_SECTOR", c.Sector);
                cmd.Parameters.AddWithValue("_CARGO", c.Cargo);
                cmd.Parameters.AddWithValue("_AREASINTERES", c.AreasInteres1);
                cmd.Parameters.AddWithValue("_OBSERVACIONES", c.Observaciones);

                cmd.ExecuteNonQuery();





                CerrarConexion();

                return true;

            }
            return false;

        }

    }
}
