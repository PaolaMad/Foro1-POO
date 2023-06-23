using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Libreria
{
    public class Digital: Libros
    {
        private string Extension;

        public void setExtension(string extension)
        {
            this.Extension = extension;
        }

        public string getExtension()
        {
            return this.Extension;
        }

        public Digital() { 

        }
    }
}
