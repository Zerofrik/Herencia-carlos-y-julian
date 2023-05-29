using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_de_herencia_Carlos_Morris_y_Julian_Monroy
{
    internal class Actor : PersonalPelicula
    {
        private string _papel { get; set; }
        private string _tiempoenpantalla { get; set; }
        private int _cantidadlineas { get; set; }


        public string Papel
        {
            get
            {
                return _papel;
            }
            set { _papel = value; }
        }
        public string Tiempoenpantalla
        {
            get
            {
                return _tiempoenpantalla;
            }
            set { _tiempoenpantalla = value; }
        }
        public int Cantidadlineas
        {
            get
            {
                return _cantidadlineas;
            }
            set { _cantidadlineas = value; }
        }
        public Actor(string nombredelpersonal, int edad, string email, string telefono, string carrera, string area, int salario) : base(nombredelpersonal, edad, email, telefono, carrera, area, salario)
        {
        }

    }
}
