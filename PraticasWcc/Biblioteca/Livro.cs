using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Livro
    {
        public Livro()
        {
           
        }

        public Livro(string titulo, string descricao, double preco, Autor autor, Genero genero)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            Autor = autor;
            Genero = genero;
            
        }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }
        public Autor Autor { get;private  set; }
        public Genero Genero { get; private set; }
    }
    public enum Genero
    {
        [Description("Ficção")]
        F = 01,

        [Description("Tecnologia")]
        T = 02,

        [Description("Outros")]
        O = 03,

    }
}