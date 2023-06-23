using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Libreria
{
    public class AppFormatos
    {
        public AppFormatos() 
        {
            Fisico fisico = new Fisico();
            Digital digital = new Digital();

            bool continuar = true;

            while (continuar)
            {

                Console.WriteLine(" - FORMATO DE LIBROS -");
                Console.WriteLine("Su libro es:");
                Console.WriteLine("1) Fisico");
                Console.WriteLine("2) Digital");
                Console.WriteLine("3) Salir");
                int opc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Nombre del libro: ");
                        string nombre1 = Console.ReadLine();
                        fisico.setLibro(nombre1);

                        Console.WriteLine("Nombre del Autor: ");
                        string autor1 = Console.ReadLine();
                        fisico.setAutor(autor1);

                        Console.WriteLine("Genero del Libro: ");
                        string genero1 = Console.ReadLine();
                        fisico.setGenero(genero1);

                        Console.WriteLine("Tipo de cubierta del Libro: ");
                        string pasta1 = Console.ReadLine();
                        fisico.setPasta(pasta1);

                        Console.WriteLine($"Libro:{fisico.getLibro()} " +
                            $" -Autor: {fisico.getAutor()} " +
                            $"-Genero: {fisico.getGenero()} " +
                            $"-Tipo de cubierta: {fisico.getPasta()}");

                        Console.WriteLine("");

                        break;


                    case 2:
                        Console.WriteLine("Nombre del libro: ");
                        string nombre2 = Console.ReadLine();
                        fisico.setLibro(nombre2);

                        Console.WriteLine("Nombre del Autor: ");
                        string autor2 = Console.ReadLine();
                        fisico.setAutor(autor2);

                        Console.WriteLine("Genero del Libro: ");
                        string genero2 = Console.ReadLine();
                        fisico.setGenero(genero2);

                        Console.WriteLine("Extension del Libro: ");
                        string pasta2 = Console.ReadLine();
                        fisico.setPasta(pasta2);

                        Console.WriteLine($"Libro:{fisico.getLibro()} " +
                            $" -Autor: {fisico.getAutor()} " +
                            $"-Genero: {fisico.getGenero()} " +
                            $"-Extensión: {fisico.getPasta()}");

                        Console.WriteLine("");

                        break;

                    case 3:
                        continuar = false;
                        Console.WriteLine("SALIENDO...");
                        break;

                    default:
                        Console.WriteLine("Ingrese una opción válida");
                        break;
                }

            }

            

        }

    }
}
