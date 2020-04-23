using System;

namespace Library
{
    public class Personajes
    {
        public Personajes(string tipo, string nombre)
        {
            this.Tipo = tipo;
            this.Nombre = nombre;
            if (this.Tipo == "elfo")
                this.Vidas = 10;
            else
                this.Vidas = 5;
            this.Monedas = 100;
        }

        public void Atacar (Personajes Otro, ElementosAtaque ElementoA)
        {
            if (this.Monedas > ElementoA.Costo)
            {

                if (Otro.CantidadElementosDefensa > 0)
                {
                    this.Ataque++;
                    this.Monedas = this.Monedas - ElementoA.Costo;
                    Otro.Defensa++;
                    Otro.CantidadElementosDefensa--;
                }
                else
                {
                    this.Ataque++;
                    this.Monedas = this.Monedas - ElementoA.Costo;
                    Otro.Vidas = Otro.Vidas - ElementoA.Potencia;
                }

            }
            else
            {
                Console.WriteLine("no tiene monedas suficientes para utilizar ese elemento");
            }
            

        }

        public void Curar(Personajes Otro)
        {
            if (Otro.Tipo == "elfo")
            {
                Otro.Vidas = 10;
                this.Vidas++;
                this.Monedas = this.Monedas + 50;
            }
            else
            {
                Otro.Vidas = 5;
                this.Vidas = this.Vidas + 2;
                this.Monedas = this.Monedas + 50;
            }
        }



        public void ComprarElementoDefensa(ElementosDefensa ElementoD)
        {
            this.CantidadElementosDefensa++;
            this.Monedas = this.Monedas - ElementoD.Costo;
        }

        public void ComprarElementoVarios(ElementosVarios ElementoV)
        {
            this.Monedas = this.Monedas - ElementoV.Costo;
        }


       
        public String Tipo { get; set; }
        public String Nombre { get; set; }
        public int Vidas { get; set; }
        public int Defensa { get; set; }
        public int Ataque { get; set; }
        public int CantidadElementosDefensa { get; set; }
        public int Monedas { get; set; }
    }

}

