using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using OfficeOpenXml;



namespace ProyectoF
{
    static class DataManager
    {
        const string pathExcel = "ReporteExcel.xlsx";
        const string pathContador = "ID.dat";
        const string pathCanciones = "Canciones.json";   //Aqui pueden cambiar donde se encuentra el archivo-
        const string pathListas = "Listas.json";         //De normal, ambos archivos se encucentran en la carpeta Bin, por lo que no es necesario usar un path-
                                                         //Solo escribir el nombre del archivo.
        
        public static void RecuperarCanciones(out List<Cancion> Canciones)
        {
            string archivoCanciones = File.ReadAllText(pathCanciones);

            if (archivoCanciones.Length!=0)
                Canciones = JsonConvert.DeserializeObject<List<Cancion>>(archivoCanciones);
            else
                Canciones = new List<Cancion>();
            
        }

        public static void RecuperarPlaylists(out List<Playlist> playlists)
        {
            string archivoListas = File.ReadAllText(pathListas);

            if (archivoListas.Length != 0)
                playlists = JsonConvert.DeserializeObject<List<Playlist>>(archivoListas);
            else
                playlists = new List<Playlist>();

        }

        public static void RecuperarID(out int IdCanciones, out int IdPlaylist)
        {
            string[] contador_ID = File.ReadAllLines(pathContador);

            if (contador_ID.Length == 2)
            {
                    IdCanciones = Convert.ToInt32(contador_ID[0]);
                    IdPlaylist = Convert.ToInt32(contador_ID[1]);
            }
            else
            {
                IdCanciones = 1;
                IdPlaylist = 1;
            }

        }

        public static void Grabar(List<Cancion> canciones, List<Playlist> listas, int IdCanciones, int IdListas)
        {
            //Guarda las canciones
            string strCanciones = JsonConvert.SerializeObject(canciones);
            File.WriteAllText(pathCanciones, strCanciones);

            //Guarda las listas
            string strListas = JsonConvert.SerializeObject(listas);
            File.WriteAllText(pathListas, strListas);

            //Guarda los IDs
            string[] contador_ID=new string[2];
            contador_ID[0] = IdCanciones.ToString();
            contador_ID[1] = IdListas.ToString();
            File.WriteAllLines(pathContador, contador_ID);
            
        }

        public static void ReporteExcel()
        {
            File.Delete(pathExcel);
            FileInfo spreadsheetInfo = new FileInfo(pathExcel);

            ExcelPackage pck = new ExcelPackage(spreadsheetInfo);
            var ExcelWorkSheet = pck.Workbook.Worksheets.Add("Listas de Reproduccion");

            
        }

       
    }
}
