using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreadorDeUtilesJsonPaqutero.Utiles
{
    public abstract class WorkerJS<E> : Worker<E> where E : DatosWorkedJS
    {
        //public WorkerJS(E input) : base(input)
        //{
        //}

        protected virtual void OnProgress(E d)
        {
            d.incremento();
            OnProgress(d, d.getProgresoEntidad());
        }
    }
}
