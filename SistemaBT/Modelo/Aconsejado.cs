using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //[Serializable]
    public class Aconsejado //: MiembroUniversitario
    {
        private string _nombreCompleto;
        private DateTime _fechaNacimiento;
        private string _correo;
        private int _telefono;
        private string _direccion;

        private int _codigo;
        private string _especialidad;
        private int _ciclo;
        private string _estado;
        private string _observaciones;

        public Aconsejado(string nombreCompleto, DateTime fechaNacimiento, string correo, string direccion, int codigo, string especialidad, int ciclo, string estado, string observaciones)
        {
            _nombreCompleto = nombreCompleto;
            _fechaNacimiento = fechaNacimiento;
            _correo = correo;
            _direccion = direccion;
            _codigo = codigo;
            _especialidad = especialidad;
            _ciclo = ciclo;
            _estado = estado;
            _observaciones = observaciones;
        }

        public Aconsejado() { _estado = "Inhabilitado"; }

        public string NombreCompleto { get => _nombreCompleto; set => _nombreCompleto = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Especialidad { get => _especialidad; set => _especialidad = value; }
        public int Ciclo { get => _ciclo; set => _ciclo = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }
    }
}
