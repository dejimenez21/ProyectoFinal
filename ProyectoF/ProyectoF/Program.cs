using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoF
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec;

            Console.WriteLine("1- Agregar cancion");
            Console.WriteLine("2- Listar todas las canciones");
            Console.WriteLine("3- Editar cancion");
            Console.WriteLine("4- Borrar cancion");
            Console.WriteLine("5- Buscar");

            dec = int.Parse(Console.ReadLine());

            switch (dec)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    Buscar();

                    break;
            }

            Console.ReadKey();
        }

        static void Buscar()
        {
            int db;

            Console.Clear();
            Console.WriteLine("Buscar:\n");
            Console.WriteLine("\t1- Por Artista");
            Console.WriteLine("\t2- Por Genero");
            Console.WriteLine("\t3- Por Nombre");

            db = int.Parse(Console.ReadLine());
        }

        static void AgregarCancion()
        {

        }
    }
}
