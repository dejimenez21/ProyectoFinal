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
            
            IList<Cancion> Canciones = new List<Cancion>(); // Aqui se almacenan las canciones
            //List<string> canciones = new List<string>(); //Lista creada para prueba
            int IdCanciones = 1; //De aqui saldra el ID de las canciones, cada vez que añadamos una cancion le sumaremos +1 a este contador. Modificacion: Al iniciar programa es 1.
            bool salir = false;
            string nombre, artista, album, genero;
            double duracion;
            while (true)
            {
                Console.Clear();

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
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("Introduzca el artista");
                        artista = Convert.ToString(Console.ReadLine());
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("Introduzca el album");  

                        album = Convert.ToString(Console.ReadLine());
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("Introduzca el genero");  //Se añade el genero a la lista de prueba
                        genero = Convert.ToString(Console.ReadLine());
                       
                        Console.WriteLine(" ");
                        Console.WriteLine("Introduzca la duracion");  //Se añade la duracion a la lista de prueba
                        duracion = Convert.ToDouble(Console.ReadLine());
                       
                        Console.WriteLine(" ");

                        Canciones.Add(new Cancion(IdCanciones, nombre, artista, album, genero, duracion)); //Se crea un objeto Cancion con sus respectivos parametros

                        IdCanciones++;

                        Console.Clear();
                        Console.WriteLine("Cancion agregada exitosamente");
                        Console.WriteLine(" ");
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.Clear();
                        foreach (Cancion k in Canciones) //Se imprimen las canciones
                        {
                            Console.WriteLine("ID: " + k.ID);
                            Console.WriteLine("Nombre: " + k.Nombre);
                            Console.WriteLine("Artistsa: " + k.Artista);
                            Console.WriteLine("Album: " + k.Album);
                            Console.WriteLine("Genero: " + k.Genero);
                            Console.WriteLine("Duracion: " + k.Duracion);
                            Console.WriteLine("Calidad: " + k.Calidad);
                            Console.WriteLine("Formato: " + k.Formato + "\n");
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        int id, dec1;

                        Console.WriteLine("Ingrese el ID de la cancion a editar:");
                        id = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("Editar:");
                        Console.WriteLine("\t1- Nombre");
                        Console.WriteLine("\t2- Artista");
                        Console.WriteLine("\t3- Album");
                        Console.WriteLine("\t4- Genero");
                        Console.WriteLine("\t5- Duracion");
                        Console.WriteLine("\t6- Calidad");
                        Console.WriteLine("\t7- Formato");

                        dec1 = int.Parse(Console.ReadLine());

                        switch (dec)
                        {
                            case 1:
                                string vNom;
                                Console.WriteLine("Ingrese el nombre nuevo");
                                vNom = Console.ReadLine();

                                foreach(Cancion c in Canciones)
                                {
                                    if (c.ID == id) //Se busca la cancion cuyo ID sea ingresado.
                                    {
                                        c.Nombre = vNom;
                                    }
                                }
                                break;
                        }

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

        static void EditarCancion()
        {
            int id, dec;

            Console.WriteLine("Ingrese el ID de la cancion a editar:");
            id = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Editar:");
            Console.WriteLine("\t1- Nombre");
            Console.WriteLine("\t2- Artista");
            Console.WriteLine("\t3- Album");
            Console.WriteLine("\t4- Genero");
            Console.WriteLine("\t5- Duracion");
            Console.WriteLine("\t6- Calidad");
            Console.WriteLine("\t7- Formato");

            dec = int.Parse(Console.ReadLine());

            //switch (dec)
            //{
            //    case 1:

            //        foreach(object j in canciones)
            //}
        }
    }
}
