using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Libreria
{
    public class Libros
    {
        private string Libro;
        private string Autor;
        private string Genero;

        public Libros(string libro, string autor, string genero)
        {
            this.Libro = libro;
            this.Autor = autor;
            this.Genero = genero;
 
        }

        public Libros()
        {
            
        }

        public void setLibro(string libro)
        {
            this.Libro = libro;
        }

        public string getLibro()
        {
            return this.Libro;
        }

        public void setAutor(string autor)
        {
            this.Autor = autor;
        }

        public string getAutor()
        {
            return this.Autor;
        }


        public void setGenero(string genero)
        {
            this.Genero = genero;
        }

        public string getGenero()
        {
            return this.Genero;
        }

    }

}
