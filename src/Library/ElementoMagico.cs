using System;

namespace Library
{
    public class ElementoMagico
    {
        public ElementoMagico(string descripcion, int potencia, int costo)
        {
            this.Descripcion = descripcion;
            this.Potencia = potencia;
            this.Costo = costo;
        }

        public String Descripcion { get; set; }
        public int Potencia { get; set; }
        public int Costo { get; set; }
    }
}
