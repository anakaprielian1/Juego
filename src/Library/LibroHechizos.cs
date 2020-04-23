using System;

namespace Library
{
    public class LibroHechiozos
    {
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