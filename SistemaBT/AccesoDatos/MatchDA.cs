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
            conn = new MySqlConnection("server=200.16.7.96;user=inf282g3;database=inf282g3;port=3306;password=wWVyTf4lAXvjlZlC;");
            cmd = new MySqlCommand();
        }

        public bool registrarMatch(Match m)
        {
            try
            {
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "AGREGAR_MATCH";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_IdAconsejado", m.IdAconsejado);
                cmd.Parameters.AddWithValue("_IdConsejero", m.IdConsejero);
                cmd.Parameters.AddWithValue("_FechaAsignacion", m.FechaAsignacion);
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

        public BindingList<Match> listarMatches()
        {
            BindingList<Match> lista = new BindingList<Match>();

            try
            {
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "LISTAR_MATCHES";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Match m = new Match();
                    //m.IdMatch = Int32.Parse(reader.GetString("IdMatch"));
                    m.IdAconsejado = Int32.Parse(reader.GetString("IdAconsejado"));
                    m.IdConsejero = Int32.Parse(reader.GetString("IdConsejero"));
                    m.FechaAsignacion = reader.GetDateTime("FechaAsignacion");
                    m.FechaFin = reader.GetDateTime("FechaFin");
                    m.Estado = reader.GetString("Estado");

                    lista.Add(m);
                }



                cmd.CommandText = "LISTAR_ENCUESTAS_POR_MATCH";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                for (int i=0; i<lista.Count; i++)
                {
                    Match match = lista.ElementAt(i);
                    cmd.Parameters.AddWithValue("_idAconsejado", match.IdAconsejado);
                    cmd.Parameters.AddWithValue("_idConsejero", match.IdConsejero);
                    //cmd.Parameters.AddWithValue("_idMatch", match.IdMatch);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Encuesta e = new Encuesta();
                        e.IdEncuesta = Int32.Parse(reader.GetString("IdEncuesta"));
                        //e.IdMatch = Int32.Parse(reader.GetString("IdMatch"));
                        e.Descripcion = reader.GetString("Descripcion");
                        e.Link = reader.GetString("Link");
                        e.Duracion = Int32.Parse(reader.GetString("Duracion"));
                        e.Estado = reader.GetString("Estado");
                    }

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
