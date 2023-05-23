using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreadorDeUtilesJsonPaqutero.Logica.Tareas;
using CreadorDeUtilesJsonPaqutero.Logica;
using CreadorDeUtilesJsonPaqutero.Utiles;

using ReneUtiles;
using ReneUtiles.Clases;
using Delimon.Win32.IO;

namespace CreadorDeUtilesJsonPaqutero.Logica.Tareas.EscritoresDeArchivos
{
    public class EscribirArchivos : WorkerJS_General<DatosWorkedJS_CreadorDeArchivos>
    {
        public List<ArchivoACrear> archivosACrear;
        public DirectoryInfo carpeta;
        public EscribirArchivos(
             DirectoryInfo carpeta
            , EventosWorker<DatosWorkedJS_CreadorDeArchivos> eventos)
        {
            this.archivosACrear = new List<ArchivoACrear>();
            this.carpeta = carpeta;
            this.eventos = eventos;

            
        }

        public EscribirArchivos(
            List<ArchivoACrear> archivosACrear
            , DirectoryInfo carpeta
            , EventosWorker<DatosWorkedJS_CreadorDeArchivos> eventos)
        {
            this.archivosACrear = archivosACrear;
            this.carpeta = carpeta;
            this.eventos = eventos;

            foreach (var archivo in archivosACrear)
            {
                inicializarArchivo(archivo);
            }
        }
        private void inicializarArchivo(ArchivoACrear archivo) {
            archivo.carpeta = carpeta;
            archivo.file = new FileInfo(
                carpeta.ToString()
                + @"\" + archivo.nombre + archivo.extencion
                );
        }
        public void add(ArchivoACrear archivo) {
            inicializarArchivo(archivo);
            if (archivosACrear==null) {
                archivosACrear = new List<ArchivoACrear>();
            }
            archivosACrear.Add(archivo);
        }
        protected override void accion()
        {
            DatosWorkedJS_CreadorDeArchivos dw = new DatosWorkedJS_CreadorDeArchivos();
            dw.cantidadTotal = archivosACrear.Count;
            if (archivosACrear.Count>0) {
                dw.archivoActual = archivosACrear[0];
            }
            OnStarting(dw);
            foreach (var archivo in archivosACrear)
            {
                dw.archivoActual = archivo;
                if (stopRequested) {
                    break;
                }
                Archivos.crearTEXTO(
                    archivo.carpeta
                    , archivo.nombre
                    , archivo.extencion
                    ,archivo.contenido);

                
                OnProgress(dw);
            }
            if (stopRequested)
            {
                OnStoppedByUser(dw);
            }
            else {
                OnCompleted(dw);
            }
                
        }
    }
}
