using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace ProjetoDeTeste
{
    [TestClass]
    public class AutorTest
    {
        [TestMethod]
        public void VerificaSeONomeDaAutoraEMarise()
        {
            Autor autora = new Autor("Djamila");
            string nomeAutor = autora.Nome;
            Assert.AreEqual(nomeAutor, "Djamila perfeita");
        }
    }
}
