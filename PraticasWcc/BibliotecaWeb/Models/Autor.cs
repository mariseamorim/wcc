using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWeb.Models
{
    public class Autor
    {
        private string _nome { get; set; }
        public Autor()
        {
           
        }
        public Autor(string nome)
        {
            Nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public List<Autor> ListaDeAutor => new List<Autor>() { 
            this ,
            new Autor("João")
        };

    }
}