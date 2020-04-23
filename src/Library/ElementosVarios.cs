using System;

namespace Library
{
     public class ElementosVarios
    {

        public ElementosVarios(string descripcion, int costo)
        {
            this.Descripcion = descripcion;
            this.Costo = costo;
        }

        public String Descripcion { get; set; }
        public int Costo { get; set; }
    }

}