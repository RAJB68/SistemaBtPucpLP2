using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;

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
                                bd + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
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
            string query = "INSERT INTO Consejero(IdConsejero, NombreCompleto, FechaNacimiento, Especialidad, " +
                                                  "Grado, Telefono, Correo, Direccion, Empresa, Sector, " +
                                                  "Cargo, AreasInteres, FechaIngreso, Observaciones, Estado) " +
                           "VALUES('"+c.Codigo+"','"+c.NombreCompleto+"','"+c.FechaNacimiento.ToString("aaaa-mm-dd")+"','"+c.Especialidad+
                           "','"+c.Grado+ "','"+c.Telefono+ "','"+c.Correo+ "','"+c.Direccion+ "','"+c.Empresa+
                           "','"+c.Sector+ "','"+c.Cargo+ "','"+c.AreasInteres1+ "','"+c.FechaIngreso.ToString("aaaa-mm-dd") +
                           "','"+c.Observaciones+"','"+c.Estado+ "')";

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
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
                    c.FechaNacimiento = dr.GetDateTime("FechaNacimiento");
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

    }
}
