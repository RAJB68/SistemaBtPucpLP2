using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class MatchDA
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        public MatchDA()
        {
        }

        public bool registrarMatch(Match m)
        {
            try
            {
                conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
                cmd = new MySqlCommand();
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "AGREGAR_MATCH";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_IdAconsejado", m.IdAconsejado);
                cmd.Parameters.AddWithValue("_IdConsejero", m.IdConsejero);
                cmd.Parameters.AddWithValue("_FechaAsignacion", m.FechaAsignacion);
                cmd.Parameters.AddWithValue("_FechaFin", m.FechaFin);
                cmd.Parameters.AddWithValue("_Estado", m.Estado);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool finalizarMatch(Match m)
        {
            try
            {
                conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
                cmd = new MySqlCommand();
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "FINALIZAR_MATCH";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_FechaFin", m.FechaFin);
                cmd.Parameters.AddWithValue("_Estado", m.Estado);
                cmd.Parameters.AddWithValue("_IdMatch", m.IdMatch);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool eliminarMatchesPorAconsejado(int id)
        {
            try
            {
                conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
                cmd = new MySqlCommand();
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "ELIMINAR_MATCHES_POR_ACONSEJADO";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_IdAconsejado", id);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public BindingList<Match> listarMatches(int codAconsejado)
        {
            BindingList<Match> lista = new BindingList<Match>();

            try
            {
                conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
                cmd = new MySqlCommand();
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "LISTAR_MATCH";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_IdAconsejado", codAconsejado);
                
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Match m = new Match();
                    m.IdMatch = Int32.Parse(reader.GetString("IdMatch"));
                    m.IdAconsejado = Int32.Parse(reader.GetString("IdAconsejado"));
                    m.IdConsejero = Int32.Parse(reader.GetString("IdConsejero"));
                    m.FechaAsignacion = reader.GetDateTime("FechaAsignacion");
                    m.FechaFin = reader.GetDateTime("FechaFin");
                    m.Estado = reader.GetString("Estado");
                    lista.Add(m);
                }

                return lista;

            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
