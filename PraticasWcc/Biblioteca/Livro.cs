using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Livro
    {
        public Livro(string titulo, string descricao, double preco, Autor autor, string genero)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            Autor = autor;
            Genero = genero;
        }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public Autor Autor { get; set; }
        public string Genero { get; set; }
    }
}