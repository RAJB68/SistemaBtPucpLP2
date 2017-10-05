using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.ComponentModel;


namespace Modelo
{
    public class Actividad
    {
        private int idActividad;
        private string titulo;
        private string descripcion;
        private string tipoActividad;
        private string destinatario;
        private DateTime fechaProgramada;
        private string comentario;
        private string estado;

        private BindingList<InteraccionPresencial> interacciones = new BindingList<InteraccionPresencial>();
        private BindingList<Correo> correos = new BindingList<Correo>();
        private BindingList<Llamada> llamadas = new BindingList<Llamada>();

        public int IdActividad { get => idActividad; set => idActividad = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string TipoActividad { get => tipoActividad; set => tipoActividad = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public DateTime FechaProgramada { get => fechaProgramada; set => fechaProgramada = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Estado { get => estado; set => estado = value; }
        public BindingList<InteraccionPresencial> Interacciones { get => interacciones; set => interacciones = value; }
        public BindingList<Correo> Correos { get => correos; set => correos = value; }
        public BindingList<Llamada> Llamadas { get => llamadas; set => llamadas = value; }
    }
}
