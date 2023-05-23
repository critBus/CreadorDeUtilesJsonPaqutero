using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDManagerPaquete;
using Delimon.Win32.IO;
using CreadorDeUtilesJsonPaqutero.Utiles;
namespace CreadorDeUtilesJsonPaqutero.Logica.Tareas
{
    public abstract class WorkerJS_General<E> : WorkerJS<E> where E : DatosWorkedJS
    {
        public ConfiguracionCreadorDatosJS cnf;
        

        public WorkerJS_General():base()
        {
            cnf = new ConfiguracionCreadorDatosJS();
            
        }
    }
}
