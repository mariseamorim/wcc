using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Livro>() { };
         

            
            Livro livro1 = new Livro(" Harry Potter ", " Livro sobre uma escola de bruxaria ", 5, new Autor(" J. K. Rowling "), Genero.F);

           
            Livro livro2 = new Livro(" Código Limpo ", " Livro sobre tecnologia ", 6.50, new Autor(" Robert Cecil Martin "), Genero.F);

            Livro livro3 = new Livro(" Domain Drive Desing ", " Livro sobre tecnologia ", 50.55, new Autor(" Desconhecido "), Genero.O);

            lista.Add(livro1);
            lista.Add(livro2);

            List<Livro> lista2 = new List<Livro>
            {
                livro2,
                livro3
            };

            foreach (var elemento in lista)
            {
                Console.WriteLine($"{elemento.Titulo},{elemento.Descricao}, {elemento.Autor.Nome}, {elemento.Preco}, {elemento.Genero}");

            }
            foreach (var elemento in lista2)
            {
                Console.WriteLine($"{elemento.Titulo},{elemento.Descricao}, {elemento.Autor.Nome}, {elemento.Preco}, {elemento.Genero}");

            }


        }
    }
}