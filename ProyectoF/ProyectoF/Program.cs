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
            Random rad = new Random(); //Objeto random
            IList<Cancion> Canciones = new List<Cancion>(); // Aqui se almacenan las canciones
            List<string> canciones = new List<string>(); //Lista creada para prueba
            int IdCanciones = rad.Next(100000, 999999); //De aqui saldra el ID de las canciones, cada vez que añadamos una cancion le sumaremos +1 a este contador. Modificacion: Al inicial el programa, se crea un numero aleatorio entre el 100000 y el 999999 y a partir de ese numero se le van asignando los ID a las cnaciones.
            bool salir = false;
            string nombre, artista, album, genero;
            double duracion;
            while (true)
            {
                int dec;
                Console.WriteLine("1- Agregar cancion");
                Console.WriteLine("2- Listar todas las canciones");
                Console.WriteLine("3- Editar cancion");
                Console.WriteLine("4- Borrar cancion");
                Console.WriteLine("5- Buscar");
                Console.WriteLine("6- Salir");
                Console.WriteLine(" ");
                dec = int.Parse(Console.ReadLine());

                switch (dec)
                {
                    case 1:
                        Console.WriteLine("Introduzca el nombre");
                        nombre = Convert.ToString(Console.ReadLine());
                        canciones.Add(nombre + "      "); //Se añade el nombre a la lista de prueba
                        Console.WriteLine(" ");
                        Console.WriteLine("Introduzca el artista");
                        artista = Convert.ToString(Console.ReadLine());
                        canciones.Add("              " + artista + "      ");  //Se añade el artista a la lista de prueba
                        Console.WriteLine(" ");
                        Console.WriteLine("Introduzca el album");  //Se añade el album a la lista de prueba
                        album = Convert.ToString(Console.ReadLine());
                        canciones.Add("         " + album + "       " );
                        Console.WriteLine(" ");
                        Console.WriteLine("Introduzca el genero");  //Se añade el genero a la lista de prueba
                        genero = Convert.ToString(Console.ReadLine());
                        canciones.Add("          " + genero + "      ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Introduzca la duracion");  //Se añade la duracion a la lista de prueba
                        duracion = Convert.ToDouble(Console.ReadLine());
                        canciones.Add(Convert.ToString("              " + duracion) + "\n");
                        Console.WriteLine(" "); 
                        Canciones.Add(new Cancion(IdCanciones, nombre, artista, album, genero, duracion));
                        IdCanciones++;
                        Console.WriteLine("Cancion agregada exitosamente");
                        Console.WriteLine(" ");
                        break;

                    case 2:
                        Console.WriteLine("[Nombre]         -       [Artista]       -       [Album]      -      [Genero]         -      [Duracion]"); // Este cw sive para tener una idea mas clara a la hora e ver las cancoiones en la lista de pruebas
                        foreach (object i in canciones) {
                            Console.Write(i);
                        }
                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:
                        Buscar();
                        break;

                    case 6:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("inserte una opcion valida");
                        break;
                }
                if (salir) break;
            }
            Console.WriteLine("Pulse cualquier tecla para salir (incluso la de apagado :v)");
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
