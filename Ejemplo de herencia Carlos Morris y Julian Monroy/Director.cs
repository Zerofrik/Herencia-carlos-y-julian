using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_de_herencia_Carlos_Morris_y_Julian_Monroy
{
    internal class Director : PersonalPelicula
    {
        private int _añosexperiencia { get; set; }
        private int _cantidadObras { get; set; }
        private DateTime _iniciocontrato { get; set; }


        public int añosexperiencia
        {
            get
            {
                return _añosexperiencia;
            }
            set { _añosexperiencia = value; }
        }
        public int CantidadObras
        {
            get
            {
                return _cantidadObras;
            }
            set { _cantidadObras = value; }
        }
        public DateTime Iniciocontrato
        {
            get
            {
                return _iniciocontrato;
            }
            set { _iniciocontrato = value; }
        }
        public Director(string nombredelpersonal, int edad, string email, string telefono, string carrera, string area, int salario) : base(nombredelpersonal, edad, email, telefono, carrera, area, salario)
        {
        }
    }
}
