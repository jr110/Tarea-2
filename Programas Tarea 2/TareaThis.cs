using System;

namespace TareasThis
{
    class Program
    {
        class persona
        {
            public string Nombre,Apellido;
            public persona(string N, string A)
            {
                this.Nombre = N;
                this.Apellido=A;
            }

            public void imprimirpersona()
        {
            Console.WriteLine("{0} {1}",Nombre,Apellido);
        }
        }

        
        static void Main(string[] args)
        {
            persona Pedro= new persona("pedro","perez");
            Pedro.imprimirpersona();
            Console.WriteLine("Hello World!");
        }
    }
}
