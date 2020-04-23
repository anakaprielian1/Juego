using System;

namespace Library
{
    public class LibroHechiozos
    {
        //potencia pude 1, 2 o 3.
        //si es 
        //potencia alta disminuye la vida en 3, media en 2 y baja en 1
        public LibroHechiozos(string hechizo, int costo)
        {   
            this.Costo = costo;
            if (hechizo == "ponzoña")
            {
                this.Hechizo = hechizo;
                this.Efecto= 3;
            }
            else if(hechizo == "debilitar")
            {
                this.Hechizo = hechizo;
                this.Efecto = 2;
            }
            else if(hechizo == "aturdir")
            {
                this.Hechizo = hechizo;
                this.Efecto = 2;
            }
            
        }

        public int Costo { get; set; }
        public string Hechizo { get; set; }
        public int Efecto { get; set; }
    }
}