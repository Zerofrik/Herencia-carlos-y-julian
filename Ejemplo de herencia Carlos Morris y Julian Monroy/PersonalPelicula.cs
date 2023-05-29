using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_de_herencia_Carlos_Morris_y_Julian_Monroy
{
    internal class PersonalPelicula
    {
        private string _nombredelpersonal { get; set; }
        private int _edad { get; set; }
        private string _email { get; set; }
        private string _telefono { get; set; }
        private string _carrera { get; set; }
        private string _area { get; set; }
        private int _salario { get; set; }

        public string Nombredelpersonal
        {
            get
            {
                return _nombredelpersonal;
            }
            set { _nombredelpersonal = value; }
        }
        public int Edad
        {
            get
            {
                return _edad;
            }
            set { _edad = value; }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set { _email = value; }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set { _telefono = value; }
        }
        public string Carrera
        {
            get
            {
                return _carrera;
            }
            set { _carrera = value; }
        }
        public string Area
        {
            get
            {
                return _area;
            }
            set { _area = value; }
        }
        public int Salario
        {
            get
            {
                return _salario;
            }
            set { _salario = value; }
        }

        public PersonalPelicula(string nombredelpersonal, int edad, string email, string telefono, string carrera, string area, int salario)
        {
            _nombredelpersonal = nombredelpersonal;
            _edad = edad;
            _email = email;
            _telefono = telefono;
            _carrera = carrera;
            _area = area;
            _salario = salario;

        }

    }
}
