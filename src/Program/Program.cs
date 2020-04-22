using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //creacion de objetos personajes y elementos

            Personajes Legolas = new Personajes("elfo", "legolas");
            Personajes Gimli = new Personajes("enano", "gimpli");
            Personajes Frodo = new Personajes("hobbit", "frodo");

            ElementosAtaque Martillo = new ElementosAtaque("martillo", 1, 10);
            ElementosAtaque ArcoFlecha = new ElementosAtaque("arco y flecha", 2, 20);
            ElementosAtaque Espada = new ElementosAtaque("espada", 3, 30);

            ElementosDefensa Escudo = new ElementosDefensa("escudo", 50);

            ElementosVarios Tunica = new ElementosVarios("tunica blanca", 5);
            ElementosVarios Anillo = new ElementosVarios("anillo", 10);

            //juego

            Legolas.ComprarElementoDefensa(Escudo);

            Legolas.Atacar(Gimli, ArcoFlecha);

            Gimli.Atacar(Legolas, Martillo);

            Console.WriteLine(Legolas.Vidas); // 10 ya que es elfo y compro escudo
            Console.WriteLine(Gimli.Vidas); // 3 porque tenia 5 y se uso arco y flecha (potencia 2)
            Console.WriteLine(Legolas.Monedas); // 30 = 100 -50 del escudo y -20 del arco y flecha

            Frodo.Curar(Gimli);

            Console.WriteLine(Gimli.Vidas); // vuelve a tener 5 porque lo curaron
            Console.WriteLine(Frodo.Vidas); // ahora tiene 7, ya que sumo 2 por curar al enano
            













        }


    }


}
