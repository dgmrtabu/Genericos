using SeccionGenericosClases.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeccionGenericosClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplo();
            Console.Read();
        }

        static void EjemploRestricciones()
        {
            //var manejadorStruct = new Manejador<Animales>();
            //var manejadorClaseConstructorPrivado = new Manejador<Utilidades>();
            var manejadorClase = new Manejador<Empleado>();
            var manejadorClase2 = new Manejador<Persona>();

        }

        static void Ejemplo()
        {

            var manejador = new Manejador<Persona>();
            manejador.Agregar(new Persona() { Nombre = "Isaac", FechaNacimiento = new DateTime(1920, 1, 1) });
            manejador.Agregar(new Persona() { Nombre = "Seldon", FechaNacimiento = new DateTime(2200, 1, 1) });
            manejador.Agregar(new Persona() { Nombre = "Ursula", FechaNacimiento = new DateTime(1980, 1, 1) });
            var lista = manejador.ObtenerTodos();
            var primero = manejador.ObtenerPrimero(x => x.FechaNacimiento.Year > 2000);
            manejador.Eliminar(x => x.FechaNacimiento.Year <= 1950);

            var manejador2 = new ManejadorAutomovil();
            manejador2.Agregar(new Automovil() { Marca = "Honda", Modelo = "", Anio = 2000 });
            manejador2.Agregar(new Automovil() { Marca = "Benz", Modelo = "", Anio = 2010 });
            var lista2 = manejador2.ObtenerTodos();
            var primero2 = manejador2.ObtenerPrimero(x => x.Anio > 2000);
            manejador2.Eliminar(x => x.Anio <= 2000);


        }

        static void EjemploPersona()
        {
            var manejador = new ManejadorPersona();
            manejador.Agregar(new Persona() { Nombre = "Isaac", FechaNacimiento = new DateTime(1920, 1, 1) });
            manejador.Agregar(new Persona() { Nombre = "Seldon", FechaNacimiento = new DateTime(2200, 1, 1) });
            manejador.Agregar(new Persona() { Nombre = "Ursula", FechaNacimiento = new DateTime(1980, 1, 1) });
            var lista = manejador.ObtenerTodos();
            var primero = manejador.ObtenerPrimero(x => x.FechaNacimiento.Year > 2000);
            manejador.Eliminar(x => x.FechaNacimiento.Year <= 1950);
        }

        static void EjemploAutomovil()
        {
            var manejador = new ManejadorAutomovil();
            manejador.Agregar(new Automovil() { Marca = "Honda", Modelo = "", Anio = 2000 });
            manejador.Agregar(new Automovil() { Marca = "Benz", Modelo = "", Anio = 2010 });
            var lista = manejador.ObtenerTodos();
            var primero = manejador.ObtenerPrimero(x => x.Anio > 2000);
            manejador.Eliminar(x => x.Anio <= 2000);
        }


    }

    public struct Animales
    {
        public string Nombre { get; set; }
    }

    public class Utilidades
    {
        private Utilidades() { }
    }
}
