using NUnit.Framework;

namespace Library.Test
{
    public class TestsMago
    {
        private Mago Mago1;
        private Mago Mago2;
        private Personajes Personaje1;
        private ElementoMagico ElementoMagico1;
        private LibroHechiozos Hechizo1;
    


        [SetUp]
        public void Setup()
        {
            Mago1 = new Mago("x");
            Mago2 = new Mago("x");
            Personaje1 = new Personajes("elfo", "x");
            ElementoMagico1 = new ElementoMagico("x", 2, 20);
            Hechizo1 = new LibroHechiozos("ponzoña", 10);
        }

        [Test]
        public void ChequeoVidasInicialMagoIgualA10()
        {
            Assert.AreEqual(10,Mago1.Vidas);
        }

        [Test]
        public void VidasPersonajeCon10VidasTrasSerAtacadoPorMago()
        {
            Mago1.Atacar(Personaje1, ElementoMagico1, Hechizo1);
            
            Assert.AreEqual(3,Personaje1.Vidas);
        }

        [Test]
        public void SaldoMagoTrasComprarHechizo()
        {
            Mago1.ComprarHechizo(Hechizo1);
            
            Assert.AreEqual(90,Mago1.Monedas);
        }





    }
}
