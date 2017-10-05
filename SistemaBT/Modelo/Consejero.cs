using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Modelo
{
    public class Consejero
    {
        private int codigo;
        private string nombreCompleto;
        private DateTime fechaNacimiento;
        private string especialidad;
        private string grado;
        private int telefono;
        private string correo;
        private string direccion;
        private string empresa;
        private string sector;
        private string cargo;
        private string AreasInteres;
        private DateTime fechaIngreso;
        private string observaciones;
        private string estado;

        private BindingList<Actividad> actividades = new BindingList<Actividad>();

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Grado { get => grado; set => grado = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Sector { get => sector; set => sector = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string AreasInteres1 { get => AreasInteres; set => AreasInteres = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
