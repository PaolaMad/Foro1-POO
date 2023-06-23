using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Libreria
{
    public class Fisico: Libros
    {

        private string Pasta;

        public void setPasta(string pasta)
        {
            this.Pasta = pasta;
        }

        public string getPasta()
        {
            return this.Pasta;
        }

        public Fisico()
        {

        }
    }
}
