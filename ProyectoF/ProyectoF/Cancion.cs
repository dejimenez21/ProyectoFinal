using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoF
{
    class Cancion
    {
        private int ID;
        private string Nombre;
        private string Artista;
        private string Album;
        private string Genero;
        private double Duracion;
        private string Calidad;
        private string Formato;

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
