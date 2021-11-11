using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Livro>() { };
            Autor jk = new Autor(" J. K. Rowling ");
            Livro livro1 = new Livro(" Harry Potter ", " Livro sobre uma escola de bruxaria ", 5, jk, " Ficção ");

            Autor autor3 = new Autor(" Robert Cecil Martin ");
            Livro livro2 = new Livro(" Código Limpo ", " Livro sobre tecnologia ", 6.50, autor3, " Tecnologia ");

            Autor auto3 = new Autor(" Desconhecido ");
            Livro livro3 = new Livro(" Domain Drive Desing ", " Livro sobre tecnologia ", 50.55, auto3, " Tecnologia ");

            lista.Add(livro1);
            lista.Add(livro2);

            foreach (var elemento in lista)
            {
                Console.WriteLine($"{elemento.Titulo},{elemento.Descricao}, {elemento.Autor.Nome}, {elemento.Preco}, {elemento.Genero}");

            }


        }
    }
}
