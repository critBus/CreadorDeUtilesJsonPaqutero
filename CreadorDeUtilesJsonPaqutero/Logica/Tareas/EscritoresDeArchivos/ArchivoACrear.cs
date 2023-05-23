using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Delimon.Win32.IO;

namespace CreadorDeUtilesJsonPaqutero.Logica.Tareas.EscritoresDeArchivos
{
    public class ArchivoACrear
    {
        public FileInfo file;
        public DirectoryInfo carpeta;
        public string extencion;
        public string nombre;
        public string contenido;

        public ArchivoACrear(string extencion, string nombre, string contenido)
        {
            this.extencion = extencion;
            this.nombre = nombre;
            this.contenido = contenido;
        }
    }
}
