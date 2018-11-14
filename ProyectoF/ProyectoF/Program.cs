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
            
            int IdCanciones = 1; //De aqui saldra el ID de las canciones, cada vez que añadamos una cancion le sumaremos +1 a este contador. Modificacion: Al iniciar programa es 1.
            bool salir = false;
            string nombre, artista, album, genero, calidad, formato;
            double duracion;
            while (true)
            {
                Console.Clear();

                int dec=0;
                Console.WriteLine("1- Agregar cancion");
                Console.WriteLine("2- Listar todas las canciones");
                Console.WriteLine("3- Editar cancion");
                Console.WriteLine("4- Borrar cancion");
                Console.WriteLine("5- Buscar");
                Console.WriteLine("6- Salir");
                Console.WriteLine(" ");

                try  //Evita que se inserten cualquier tipo de valor diferente a un numero.
                {
                    dec = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    
                }

                Console.Clear();

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

                        Console.WriteLine("Introduzca la calidad");  //Se añade la duracion a la lista de prueba
                        calidad = Console.ReadLine();

                        Console.WriteLine(" ");

                        Console.WriteLine("Introduzca el formato");  //Se añade la duracion a la lista de prueba
                        formato = Console.ReadLine();

                        Console.WriteLine(" ");

                        Canciones.Add(new Cancion(IdCanciones, nombre, artista, album, genero, duracion, calidad, formato)); //Se crea un objeto Cancion con sus respectivos parametros

                        IdCanciones++;

                        Console.Clear();
                        Console.WriteLine("Cancion agregada exitosamente");
                        Console.WriteLine(" ");
                        Console.ReadKey();
                        break;

                    case 2:

                        
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
                        int id, dec1=0;

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
                        
                       

                        switch (dec1)
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

                            case 2:
                                string vArtista; //Variable que tiene el nombre del nuevo artista que se modificara
                                Console.WriteLine("Ingrese el nuevo artista");
                                vArtista = Console.ReadLine();

                                foreach (Cancion c in Canciones)
                                {
                                    if (c.ID == id) //Se busca la cancion cuyo ID sea ingresado.
                                    {
                                        c.Artista = vArtista;
                                    }
                                }
                                break;

                            case 3:
                                string vAlbum; //Variable que tiene el nombre del nuevo artista que se modificara
                                Console.WriteLine("Ingrese el nuevo nombre del album");
                                vAlbum = Console.ReadLine();

                                foreach (Cancion c in Canciones)
                                {
                                    if (c.ID == id) //Se busca la cancion cuyo ID sea ingresado.
                                    {
                                        c.Album = vAlbum;
                                    }
                                }
                                break;

                            case 4:
                                string vGenero; //Variable que tiene el nombre del nuevo artista que se modificara
                                Console.WriteLine("Ingrese el nuevo genero");
                                vGenero = Console.ReadLine();

                                foreach (Cancion c in Canciones)
                                {
                                    if (c.ID == id) //Se busca la cancion cuyo ID sea ingresado.
                                    {
                                        c.Genero = vGenero;
                                    }
                                }
                                break;

                            case 5:
                                double vDuracion; //Variable que tiene el nombre del nuevo artista que se modificara
                                Console.WriteLine("Ingrese la nueva duracion");
                                vDuracion = Int32.Parse(Console.ReadLine());

                                foreach (Cancion c in Canciones)
                                {
                                    if (c.ID == id) //Se busca la cancion cuyo ID sea ingresado.
                                    {
                                        c.Duracion = vDuracion;
                                    }
                                }
                                break;
                            case 6:
                                string vCalidad; //Variable que tiene el nombre del nuevo artista que se modificara
                                Console.WriteLine("Ingrese la nueva calidad");
                                vCalidad = Console.ReadLine();

                                foreach (Cancion c in Canciones)
                                {
                                    if (c.ID == id) //Se busca la cancion cuyo ID sea ingresado.
                                    {
                                        c.Calidad = vCalidad;
                                    }
                                }
                                break;

                            case 7:
                                string vFormato; //Variable que tiene el nombre del nuevo artista que se modificara
                                Console.WriteLine("Ingrese el nuevo formato");
                                vFormato = Console.ReadLine();

                                foreach (Cancion c in Canciones)
                                {
                                    if (c.ID == id) //Se busca la cancion cuyo ID sea ingresado.
                                    {
                                        c.Formato = vFormato;
                                    }
                                }
                                break;

                            default:
                                Console.WriteLine("inserte una opcion valida");
                                break;
                        }

                        break;

                    case 4:
                        
                        int vElim;
                        bool vConf=false;
                        Console.WriteLine("Ingrese el ID de la cancion a elminar");
                        vElim = int.Parse(Console.ReadLine());

                        for(int i=0; i<Canciones.Count; i++)
                        {
                            if (Canciones[i].ID == vElim)
                            {
                                Canciones.RemoveAt(i);
                                i--;
                                vConf = true;
                            }
                        }
                        if (vConf)
                        {
                            Console.WriteLine("Cancion eliminada exitosamente");
                            vConf = false;
                        }
                        else
                        {
                            Console.WriteLine("No existe ninguna cancion asociada a ese ID");
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        
                        Console.WriteLine("Buscar:\n");
                        Console.WriteLine("\t1- Por Artista");
                        Console.WriteLine("\t2- Por Genero");
                        Console.WriteLine("\t3- Por Nombre");
                        Console.WriteLine("\t4- Por ID");

                        int des = Int32.Parse(Console.ReadLine());

                        switch (des) {
                            case 1:
                                Console.WriteLine("Ingrese el nombre del artista");
                                string vArtista = Console.ReadLine();
                                foreach (Cancion k in Canciones) //Se imprimen las canciones
                                {
                                    if (k.Artista == vArtista) {
                                        Console.WriteLine("ID: " + k.ID);
                                        Console.WriteLine("Nombre: " + k.Nombre);
                                        Console.WriteLine("Artistsa: " + k.Artista);
                                        Console.WriteLine("Album: " + k.Album);
                                        Console.WriteLine("Genero: " + k.Genero);
                                        Console.WriteLine("Duracion: " + k.Duracion);
                                        Console.WriteLine("Calidad: " + k.Calidad);
                                        Console.WriteLine("Formato: " + k.Formato + "\n");
                                    }
                                }
                                break;

                            case 2:
                                Console.WriteLine("Ingrese el genero de la cancion");
                                string vGenero = Console.ReadLine();
                                foreach (Cancion k in Canciones) //Se imprimen las canciones
                                {
                                    if (k.Genero == vGenero)
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
                                }
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el nombre de la cancion");
                                string vNombre = Console.ReadLine();
                                foreach (Cancion k in Canciones) //Se imprimen las canciones
                                {
                                    if (k.Nombre == vNombre)
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
                                }
                                break;
                            
                        }

                        Console.ReadLine();
                        break;

                    case 6:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("inserte una opcion valida");
                        Console.ReadKey();
                        break;
                }
                if (salir) break;
            }
            Console.WriteLine("Pulse cualquier tecla para salir (incluso la de apagado :v)");
            Console.ReadKey();
        }

        
    }
}
