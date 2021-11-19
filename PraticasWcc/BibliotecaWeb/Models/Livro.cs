using BibliotecaWeb.Services;
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
       
        public Livro(string titulo, string descricao, double preco, Autor autor, string[] genero)
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
        public string[] Genero { get;  set; }

        public List<string> ListaLivros { get; set; }

        public Livro()
        {
            ListaLivros = new List<string>();
        }

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
        public List<Livro> ListaDeLivro => new List<Livro>()
        {
            this,
           new Livro("Lugar de Fala", "", 18.90, new Autor("DJamila"), new string[]{})

        };

        public List<Livro> GetLivros()
        {
            var servico = new BibliotecaService();
            var resposta = servico.BuscaLivro();

            var listaDeLivro = new List<Livro>();
            foreach (var item in resposta.Results)
            {
                var livro = new Livro()
                {
                    Titulo = item.TrackName,
                    Autor = new Autor(item.ArtistName),
                    Preco = item.Price,
                    Genero = item.Genres,
                    Descricao = item.Description
                };

                listaDeLivro.Add(livro);
            }

            return listaDeLivro;

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