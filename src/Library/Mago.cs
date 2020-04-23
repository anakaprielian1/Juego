using System;

namespace Library
{
    public class Mago
    {
        public Mago(string nickName)
        {
            this.NickName = nickName;
            this.Vidas = 10;
            this.MagicAtackDefens = 2;
            this.Monedas = 100;
        }

        public int Vidas { get; set; }
        public string NickName { get; set; }
        public int MagicAtackDefens { get; set; }
        public int Monedas { get; set; }
        public int CantidadElementosDefensa { get; set; }

        public void Atacar (Personajes Otro, ElementoMagico ElementoA, LibroHechiozos ElementoH)
        {   
            if (this.Monedas > (ElementoA.Costo + ElementoH.Costo))
            {

                if (Otro.CantidadElementosDefensa > 0)
                {
                    
                    this.Monedas = this.Monedas - (ElementoA.Costo + ElementoH.Costo);
                    
                    if (ElementoH.Hechizo == "ponzoña")
                    {
                        Otro.Vidas = Otro.Vidas - ElementoH.Efecto;
                    }
                    Otro.CantidadElementosDefensa--;
                }
                else
                {
                    
                    this.Monedas = this.Monedas - ElementoA.Costo;
                    Otro.Vidas = Otro.Vidas - ((ElementoA.Potencia + MagicAtackDefens + ElementoH.Efecto)) ;
                }

            }
            else
            {
                Console.WriteLine("no tiene monedas suficientes para utilizar ese elemento");
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

        public void ComprarHechizo(LibroHechiozos ElementoH)
        {
            this.Monedas = this.Monedas - ElementoH.Costo;
        }

    }
}