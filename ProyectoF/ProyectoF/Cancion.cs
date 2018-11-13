using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoF
{
    class Cancion
    {
        public int ID;
        public string Nombre;
        public string Artista;
        public string Album;
        public string Genero;
        public double Duracion;
        public string Calidad;
        public string Formato;

        public Cancion(int a, string b, string c, string d, string e, double f)
        {
            ID = a;
            Nombre = b;
            Artista = c;
            Album = d;
            Genero = e;
            Duracion = f;
        }
    }   
}
