using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWeb.Models
{
    public class Livro
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

        public string Titulo { get;  set; }
        public string Descricao { get;  set; }
        public double Preco { get;  set; }
        public Autor Autor { get;  set; }
        public Genero Genero { get;  set; }

        public Livro Cadastrar()
        {
            return this;
            /*return new Livro()
            {

                Titulo = Titulo,
                Descricao = Descricao,
                Preco = Preco,
                Autor = Autor,
                Genero = Genero,
            };*/
        }
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