using System;

namespace Library
{public class ElementosAtaque
    {
        //potencia pude 1, 2 o 3.
        //si es 
        //potencia alta disminuye la vida en 3, media en 2 y baja en 1
        public ElementosAtaque(string descripcion, int potencia, int costo)
        {
            this.Descripcion = descripcion;
            this.Potencia = potencia;
            this.Costo = costo;
        }

        public String Descripcion { get; set; }
        public int Potencia { get; set; }
        public int Costo { get; set; }
    }    }

