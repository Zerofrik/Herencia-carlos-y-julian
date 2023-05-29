using System;

namespace Ejemplo_de_herencia_Carlos_Morris_y_Julian_Monroy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalPelicula personal1 = new PersonalPelicula("julian felipe", 25, "julianfe@gmail.com", "3146284040", "diseñador grafico", "efectos", 500);
            Console.WriteLine($"{personal1.Nombredelpersonal} con {personal1.Edad} años correo:{personal1.Email} numero:{personal1.Telefono}, es {personal1.Carrera} en el area de {personal1.Area} con un salario de {personal1.Salario}");

            Console.WriteLine("-----------------------------------------------------------------");

            Actor ActorUno = new Actor("Carlos dicaprio", 80, "carlos@gmail.com", "3132456789", "actor", "elenco", 200);
            ActorUno.Papel = "el semental";
            ActorUno.Tiempoenpantalla = "3 horas";
            ActorUno.Cantidadlineas = 10000;
            Console.WriteLine($"{ActorUno.Nombredelpersonal} tiene {ActorUno.Edad} años correo: {ActorUno.Email} telefono: {ActorUno.Telefono}");
            Console.WriteLine($"Es {ActorUno.Carrera} en el area de {ActorUno.Area} con un salario de {ActorUno.Salario}");
            Console.WriteLine($"tiene el papel de {ActorUno.Papel} apareciendo {ActorUno.Tiempoenpantalla} con {ActorUno.Cantidadlineas} lineas");

            Console.WriteLine("-----------------------------------------------------------------");

            Director director1 = new Director("Juan Pablo", 30, "jpPvt@gmail.com", "3125653458", "Director de cine", "direccion", 20000);
            director1.añosexperiencia = 10;
            director1.CantidadObras = 4;
            director1.Iniciocontrato = new DateTime(2023, 5, 29);
            Console.WriteLine($"{director1.Nombredelpersonal} tiene {director1.Edad} años correo: {director1.Email} telefono: {director1.Telefono}");
            Console.WriteLine($"Es {director1.Carrera} en el area de {director1.Area} con un salario de {director1.Salario}");
            Console.WriteLine($"tiene {director1.añosexperiencia} años experiencia con {director1.CantidadObras} obras, inicio el contrato el {director1.Iniciocontrato}");

        }
    }
}
