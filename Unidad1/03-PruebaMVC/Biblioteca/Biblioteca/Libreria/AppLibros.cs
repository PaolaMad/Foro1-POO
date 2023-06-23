using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Libreria
{
    public class AppLibros
    {
        Libros libro = new Libros();

        List<Libros> pendientes = new();
        List<Libros> leidos = new();

        public AppLibros()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine(" - BIBLIOTECA - ");
                Console.WriteLine("Elija la opcion que desea reallizar: ");
                Console.WriteLine("1) Añadir a lista Pendientes");
                Console.WriteLine("2) Añadir a lista Leidos");
                Console.WriteLine("3) Ver lista Pendientes");
                Console.WriteLine("4) Ver lista Leidos");
                Console.WriteLine("5) Salir");

                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        AñadiPendientes();
                        break;

                    case 2:
                        AñadirLeidos();
                        break;

                    case 3:
                        VerPendientes();
                        break; 
                    
                    case 4:
                        VerLeidos();
                        break;

                    case 5:
                        continuar = false;
                        Console.WriteLine("SALIENDO...");
                        break;

                    default:
                        Console.WriteLine("Ingrese una opción válida");
                        break;
                }

                Console.WriteLine("");

            }
   
        }

        private void VerLeidos()
        {
            if (leidos.Count == 0)
            {
                Console.WriteLine("No hay libros leidos");
            }
            else
            {
                Console.WriteLine("Tienes estos libros leidos: ");
                foreach (var librosLeidos in leidos)
                {
                    Console.WriteLine(
                        $"Libro: {librosLeidos.getLibro()} " +
                        $"- Autor: {librosLeidos.getAutor()} " +
                        $"- Genero: {librosLeidos.getGenero()}");
                }
            }
        }

        private void AñadirLeidos()
        {
            Console.WriteLine("Ingrese el nombre del libro: ");
            string nombreLibro = Console.ReadLine();
            libro.setLibro(nombreLibro);

            Console.WriteLine("Ingrese el nombre del autor: ");
            string autor = Console.ReadLine();
            libro.setAutor(autor);

            Console.WriteLine("Ingrese el genero del libro: ");
            string genero = Console.ReadLine();
            libro.setGenero(genero);

            leidos.Add(libro);
            Console.WriteLine("El libro ha sido añadido a la lista de Leidos");

        }

        private void VerPendientes()
        {
            if (pendientes.Count == 0 )
            {
                Console.WriteLine("No hay libros pendientes");
            }
            else
            {
                Console.WriteLine("Tienes estos libros pendients: ");
                foreach (var librosPendientes in pendientes)
                {
                    Console.WriteLine(
                        $"Libro: {librosPendientes.getLibro()} " +
                        $"- Autor: {librosPendientes.getAutor()} " +
                        $"- Genero: {librosPendientes.getGenero()}");
                }
            }
        }

        private void AñadiPendientes()
        {
            Console.WriteLine("Ingrese el nombre del libro: ");
            string nombreLibro = Console.ReadLine();
            libro.setLibro(nombreLibro);

            Console.WriteLine("Ingrese el nombre del autor: ");
            string autor = Console.ReadLine();
            libro.setAutor(autor);

            Console.WriteLine("Ingrese el genero del libro: ");
            string genero = Console.ReadLine();
            libro.setGenero(genero);

            pendientes.Add(libro);

            Console.WriteLine("¡El libro ha sido añadido a la lista de pendientes!");
        }
    }
} 
