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
            IList<Playlist> Playlist = new List<Playlist>(); //Aqui se almacenan las playlist

            int IdCanciones = 1; //De aqui saldra el ID de las canciones, cada vez que añadamos una cancion le sumaremos +1 a este contador. Modificacion: Al iniciar programa es 1.
            int IdPlaylist = 1;
            int cantCanciones = 0;
            bool salir = false;
            bool salirPlaylist = true;
            int count = 0;


            while (true)
            {
                Console.Clear();
                int dec = 0;
                int decPlaylist = 0;
                Console.WriteLine("1- Agregar cancion");
                Console.WriteLine("2- Listar todas las canciones");
                Console.WriteLine("3- Editar cancion");
                Console.WriteLine("4- Borrar cancion");
                Console.WriteLine("5- Buscar");
                Console.WriteLine("6- Menu Playlist");
                Console.WriteLine("7- Salir");
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


                        Canciones.Add(AgregarCancion(IdCanciones)); //Se crea un objeto Cancion con sus respectivos parametros

                        IdCanciones++;


                        break;

                    case 2:


                        ListarCanciones(Canciones);


                        break;

                    case 3:

                        EditarCanciones(Canciones);

                        break;

                    case 4:

                        EliminarCanciones(Canciones);

                        break;

                    case 5:

                        BuscarCanciones(Canciones);

                        break;

                    case 6:
                        while (salirPlaylist) {
                            Console.Clear();
                            Console.WriteLine("1- Agregar lista de canciones");
                            Console.WriteLine("2- Listar todas las listas de canciones");
                            Console.WriteLine("3- Editar playlist");
                            Console.WriteLine("4- Borrar playlist");
                            Console.WriteLine("5- Buscar cancion en playlist");
                            Console.WriteLine("6- Salir");

                            Console.WriteLine(" ");

                            decPlaylist = Int32.Parse(Console.ReadLine());

                            switch (decPlaylist)
                            {
                                case 1:
                                    Playlist.Add(AgregarPlaylist(IdPlaylist));
                                    cantCanciones++;
                                    IdPlaylist++;
                                    break;

                                case 2:

                                    Console.Clear();
                                    foreach (Playlist p in Playlist)
                                    {
                                        Console.WriteLine("ID: " + p.ID);
                                        Console.WriteLine("Nombre: " + p.nombre);
                                        Console.WriteLine("Logo: " + p.logo);
                                        p.CantidadCanciones();
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ");
                                    }
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    int des = 0;
                                    Console.Clear();
                                    Console.WriteLine("Introduzca el ID de la lista a editar");
                                    int IDedit = Int32.Parse(Console.ReadLine());
                                   
                                    foreach (Playlist o in Playlist) {
                                        if(o.ID == IDedit)
                                        {
                                            Console.Clear();
                                            bool force = true;
                                            Console.WriteLine("1- Editar nombre");
                                            Console.WriteLine("2- Editar logo");
                                            Console.WriteLine("3- Agregar cancion");
                                            Console.WriteLine("4- Listar canciones");
                                            Console.WriteLine("5- Borrar cancione");
                                            Console.WriteLine("6- Atras");
                                            des = Int32.Parse(Console.ReadLine());
                                            switch (des)
                                            {
                                                case 1:
                                                    string vNom;
                                                    Console.WriteLine("Ingrese el nuevo nombre");
                                                    vNom = Console.ReadLine();
                                                    foreach (Playlist p in Playlist)
                                                    {
                                                        if (p.ID == IDedit)
                                                        {
                                                            p.nombre = vNom;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    string vLogo;
                                                    Console.WriteLine("Ingrese el nuevo logo");
                                                    vLogo = Console.ReadLine();
                                                    foreach (Playlist p in Playlist)
                                                    {
                                                        if (p.ID == IDedit)
                                                        {
                                                            p.logo = vLogo;
                                                        }
                                                    }
                                                    break;
                                                case 3:
                                                    
                                                    string vNombreC;
                                                    Console.WriteLine("Ingrese el nombre de la cancion a agregar:");
                                                    vNombreC = Console.ReadLine();
                                                    foreach (Playlist p in Playlist)
                                                    {
                                                        if (p.ID == IDedit) {
                                                            foreach (Cancion c in Canciones)
                                                            {
                                                                if (c.Nombre == vNombreC)
                                                                {
                                                                    count++;
                                                                    p.AgregarCancion(c);
                                                                }
                                                            }
                                                        }
                                                        
                                                    }
                                                    if (count <= 0) {
                                                        Console.WriteLine("Esa cancion no existe");
                                                    }
                                                    Console.ReadLine();
                                                    break;
                                                case 4:
                                                    foreach (Playlist p in Playlist)
                                                    {
                                                        if (p.ID == IDedit)
                                                        {
                                                            p.ImprimirCanciones();
                                                        }
                                                    }
                                                    Console.ReadLine();
                                                    break;
                                                case 5:
                                                    Console.WriteLine("Que cancion desea remover?");
                                                    string canRemover;
                                                    canRemover = Console.ReadLine();
                                                    foreach (Playlist p in Playlist)
                                                    {
                                                        if (p.ID == IDedit) {
                                                            foreach (Cancion c in Canciones)
                                                            {
                                                                if (canRemover == c.Nombre) {
                                                                    p.RemoverCancion(c);
                                                                    count--;
                                                                    Console.WriteLine("Cancion removida exitosamente");
                                                                    Console.ReadLine();
                                                                    force = false;
                                                                }
                                                            }
                                                        }
                                                        
                                                    }
                                                    if (force) {
                                                        Console.WriteLine("No se encontro la cancion que desea remover");
                                                    }
                                                    break;
                                                case 6:
                                                    break;
                                                default:
                                                    Console.WriteLine("Esa no es una opcion");
                                                    break;
                                                
                                            }

                                            break;
                                        }
                                    }
                                    break;
                                case 4:
                                    int playremove;
                                    bool force1 = false;
                                    Console.WriteLine("Ingrese el ID de la Playlist que desea borrar");
                                    playremove = Int32.Parse(Console.ReadLine());
                                    for (int i = 0; i < Playlist.Count; i++) {
                                        if (Playlist[i].ID == playremove) {
                                            Playlist.RemoveAt(i);
                                            Console.WriteLine("Playlist eliminada correctamente");
                                            force1 = false;
                                        }
                                    }
                                    if (force1) {
                                        Console.WriteLine("No se encontro la Playlist que desea eliminiar");
                                    }
                                    break;
                                case 5:
                                    int idFound = 0;
                                    string fSong;
                                    Console.WriteLine("Ingrese el ID de la Playlist en la cual quiere buscar");
                                    idFound = Int32.Parse(Console.ReadLine());
                                    foreach (Playlist p in Playlist)
                                    {
                                        if (p.ID == idFound) {
                                            Console.WriteLine("Ingrese el nombre de la cancion a borrar");
                                            fSong = Console.ReadLine();
                                            p.PrintSpecific(fSong);
                                        }
                                    }
                                    Console.ReadLine();
                                    break;
                                case 6:
                                    salirPlaylist = false;
                                    break;
                            }

                        }
                        
                        break;

                    case 7:
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

        static Cancion AgregarCancion(int IdCanciones)
        {

            string nombre, artista, album, genero, calidad, formato;
            double duracion;

            Console.WriteLine("Introduzca el nombre");
            nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Introduzca el artista");
            artista = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Introduzca el album");

            album = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Introduzca el genero");
            genero = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Introduzca la duracion");
            duracion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Introduzca la calidad");
            calidad = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine("Introduzca el formato");
            formato = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Clear();
            Console.WriteLine("Cancion agregada exitosamente");
            Console.WriteLine(" ");
            Console.ReadKey();

            Cancion cancion = new Cancion(IdCanciones, nombre, artista, album, genero, duracion, calidad, formato);
            return cancion;
        }

        static void ListarCanciones(IList<Cancion> Canciones)
        {
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
        }

        static void EditarCanciones(IList<Cancion> Canciones)
        {
            int id, dec1 = 0;

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

                    foreach (Cancion c in Canciones)
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
        }

        static void EliminarCanciones(IList<Cancion> Canciones)
        {
            int vElim;
            bool vConf = false;
            Console.WriteLine("Ingrese el ID de la cancion a elminar");
            vElim = int.Parse(Console.ReadLine());

            for (int i = 0; i < Canciones.Count; i++)
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
        }

        static void BuscarCanciones(IList<Cancion> Canciones)
        {
            int found = 0;
            Console.WriteLine("Buscar:\n");
            Console.WriteLine("\t1- Por Artista");
            Console.WriteLine("\t2- Por Genero");
            Console.WriteLine("\t3- Por Nombre");


            int des = Int32.Parse(Console.ReadLine());

            switch (des)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del artista");
                    string vArtista = Console.ReadLine();
                    foreach (Cancion k in Canciones) //Se imprimen las canciones
                    {
                        if (k.Artista == vArtista)
                        {
                            Console.WriteLine("ID: " + k.ID);
                            Console.WriteLine("Nombre: " + k.Nombre);
                            Console.WriteLine("Artistsa: " + k.Artista);
                            Console.WriteLine("Album: " + k.Album);
                            Console.WriteLine("Genero: " + k.Genero);
                            Console.WriteLine("Duracion: " + k.Duracion);
                            Console.WriteLine("Calidad: " + k.Calidad);
                            Console.WriteLine("Formato: " + k.Formato + "\n");
                            found++;
                        }
                    }
                    if (found <= 0) {
                        Console.WriteLine("No se encontro ninguna cancion de ese artista");
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
                            found++;

                        }
                        if (found <= 0)
                        {
                            Console.WriteLine("No se encontro ninguna cancion de ese genero");
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
                            found++;

                        }
                        if (found <= 0)
                        {
                            Console.WriteLine("No se encontro ninguna cancion con ese nombre");
                        }
                    }
                    break;

            }

            Console.ReadLine();
        }

        static Playlist AgregarPlaylist(int IdPlaylist) {
            

            string nombre, logo;
            Console.Clear();
            Console.WriteLine("Ingrese el nombre de la Playlist: ");
            nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese el logo:");
            logo = Console.ReadLine();
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("Playlist agregada exitosamente");
            Console.ReadLine();
            Console.Clear();
            Playlist playlist = new Playlist(nombre, logo, IdPlaylist);
            return playlist;
            
        }
    }
}
