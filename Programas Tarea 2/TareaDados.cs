using System;

namespace TareaDados
{
    class Dado
    {
        public int valor;
        public string color;
        public int mayor;

        //constructor 1
        public Dado (int valor)
        {
            this.valor=valor;
            
        }
        // costructor 2
        public Dado (int valor,string color)
        {
            this.valor=valor;
            this.color=color;
        }
        //Operadores sobrecargados
        public static bool operator >(Dado c1, Dado c2)
        {
           return (c1.valor.CompareTo(c2.valor)>0);
        }
         public static bool operator <(Dado c1, Dado c2)
        {
           return (c1.valor.CompareTo(c2.valor)<0);
        }
        public static bool operator ==(Dado c1, Dado c2)
        {
           return (c1.valor.CompareTo(c2.valor)>0);
        }
        public static bool operator !=(Dado c1, Dado c2)
        {
           return (c1.valor.CompareTo(c2.valor)!=c2.valor);
        }
        public void imprimir()
        {
            Console.WriteLine("La cara mayor fue {0} del color {1}",valor,color);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Primer campo es el valor de la cara.
            Dado d1=new Dado(4,"amarillo");
            Dado d2=new Dado(2,"rojo");
            Dado d3=new Dado(5,"azul");
            if (d1.valor>d2.valor && d1.valor>d3.valor)
            {
                d1.imprimir();
            }
            else if (d2.valor>d1.valor && d2.valor>d3.valor)
            {
                d2.imprimir();
            }
            else if (d3.valor>d2.valor && d3.valor>d1.valor)
            {
                d3.imprimir();
            }
            else if (d3.valor==d2.valor && d3.valor==d1.valor)
            {
                Console.WriteLine("Tienen el mismos valor de caras");
            }
        }
    }
}
