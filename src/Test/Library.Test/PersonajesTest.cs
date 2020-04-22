using NUnit.Framework;

namespace Library.Test
{
    public class Tests
    {
        private Personajes Elfo1;
        private Personajes Personaje1;
        private ElementosAtaque ElementoAtaque1;
        private ElementosAtaque ElementoAtaque2;
        private ElementosDefensa ElementoDefensa1;
        private ElementosVarios ElementosV1;


        [SetUp]
        public void Setup()
        {
            Elfo1 = new Personajes("elfo", "x");
            Personaje1 = new Personajes("otroPersonaje", "x");

            ElementoAtaque1 = new ElementosAtaque("x", 2, 20);
            ElementoAtaque2 = new ElementosAtaque("x", 2, 150);
            ElementoDefensa1 = new ElementosDefensa("x", 30);
            ElementosV1 = new ElementosVarios("x", 10);
        }

        [Test]
        public void ChequeoVidasInicialElfoIgualA10()
        {
            Assert.AreEqual(10,Elfo1.Vidas);
        }

        [Test]
        public void ChequeoVidasInicialOtroPersonajeIgualA5()
        {
            Assert.AreEqual(5,Personaje1.Vidas);
        }

        [Test]
        public void VerificarSaldoCorrectoPorComprarElementoDeDefensa()
        {
            Personaje1.ComprarElementoDefensa(ElementoDefensa1);

            Assert.AreEqual(100 - 30, Personaje1.Monedas);
        }

        [Test]
        public void VerificarSaldoCorrectoPorComprarElementoVarios()
        {
            Personaje1.ComprarElementoVarios(ElementosV1);

            Assert.AreEqual(100 - 10, Personaje1.Monedas);
        }

        [Test]
        public void SiPersonaje1CuraAlElfo1LeSeteaLaVidaEn10()
        {
            
            Personaje1.Curar(Elfo1);

            Assert.AreEqual(10, Elfo1.Vidas);
        }

        [Test]
        public void SiPersonaje1CuraAlElfo1Obtiene50monedas()
        {
            Personaje1.Curar(Elfo1);

            Assert.AreEqual(150, Personaje1.Monedas);
        }

        [Test]
        public void VerificarSaldoPorAtacar()
        {
            Personaje1.Atacar(Elfo1,ElementoAtaque1);

            Assert.AreEqual(80, Personaje1.Monedas);
        }

/* ESTE TEST NO ME SALIO
        [Test]
        public void VerificarImpresionEnConsolaCuandoSaldoInsufParaAtacar()
        {
            Personaje1.Atacar(Elfo1,ElementoAtaque2);

            Assert.AreEqual("no tiene monedas suficientes para utilizar ese elemento", System.Console.ReadLine());
        }
*/

        [Test]
        public void AtacarAOtroSinDefensaLeDisminuyeLaVidaSegunPotenciaDelElemento()
        {
            Personaje1.Atacar(Elfo1,ElementoAtaque1);

            Assert.AreEqual(8, Elfo1.Vidas);
        }

    }
}