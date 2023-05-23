using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReneUtiles;
using ReneUtiles.Clases;
using CreadorDeUtilesJsonPaqutero.Logica;

namespace CreadorDeUtilesJsonPaqutero.Utiles
{
    class EventosConsola<E>:EventosWorker<E> where E : DatosWorkedJS
    {
        protected string nombre;

        public EventosConsola(string nombre)
        {
            this.nombre = nombre;
            addStarting(v=>cwl("Va comenzar con "+nombre));
            addProgress(
                (v, p) => cwl(nombre+" "+v.indiceActual+"\t\t/"+v.cantidadTotal+"\t\t"+p+"%")//+((double)v.indiceActual/ (double)v.cantidadTotal)*100)
                );
            addCompleted(
                (v, t) => cwl("termino con "+nombre+" en "+ getTiempoStr(t))
                );
            addError(
                (v, ex) => {
                    cwl("dio el error el "+nombre);
                    cwl(ex.Source);
                    cwl(ex.Message);
                    cwl(ex.StackTrace);
                }
                );

        }
        private string getTiempoStr(TimeSpan t) {
            return t.ToString();
        }
    }
}
