using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeTeste
{
    [TestClass]
    public class LivroTest
    {
        [TestMethod]
        public void VerificaCadastroDeLivro()
        {
            Livro livro = new Livro();
            livro.Titulo = "Lugar de Fala";
            livro.Autor= new Autor("Djamila");
            livro.Preco = 15.95;


            var livroCadastrado = livro.Cadastrar();
            Assert.AreEqual("Lugar de Fala", livroCadastrado.Titulo);
            Assert.AreEqual("Djamila", livroCadastrado.Autor);
            Assert.AreEqual(15.95, livroCadastrado.Preco);
            Assert.AreEqual("", livroCadastrado.Descricao);
        }
    }
}
