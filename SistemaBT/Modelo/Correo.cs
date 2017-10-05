using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Correo
    {
        private int idCorreo;
        private string destinatario;
        private string asunto;
        private string mensaje;
        public int IdCorreo { get => idCorreo; set => idCorreo = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Asunto { get => asunto; set => asunto = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
