using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReneUtiles;
using ReneUtiles.Clases;

using BDManagerPaquete;
using Delimon.Win32.IO;
using CreadorDeUtilesJsonPaqutero.Utiles;
using CreadorDeUtilesJsonPaqutero.Logica;
using CreadorDeUtilesJsonPaqutero.Logica.Tareas;
namespace CreadorDeUtilesJsonPaqutero.Logica.Tareas.CreadoresStr
{
    class CreadorDeDatosJS_Actores: CreadorDeDatos
    {

        public CreadorDeDatosJS_Actores(EventosWorker<DatosWorkedJS> evento) : base(evento) { }
        protected override void accion()
        {
            string separacion = getSeparacionln(0, separacion0);
            string separacion1 = getSeparacionln(1, separacion0);
            string separacion2 = getSeparacionln(2, separacion0);
            string separacion3 = getSeparacionln(3, separacion0);
            string separacion4 = getSeparacionln(4, separacion0);

            


            DatosWorkedJS dw = new DatosWorkedJS();

            

            cwl("creando str...");
            List<Actors_PG> lp = cnf.bd.getActors_PG_All();
            dw.cantidadTotal = lp.Count;
            OnStarting(dw);
            string variable = cnf.variableMapActores;

            dw.resultado = separacion + "const " + variable + "=new Map();";
            foreach (Actors_PG p in lp)
            {
                if (dw.indiceActual == 200)
                {
                    break;
                }

                if (stopRequested) {
                    break;
                }
                if (p.mostrar??false) {
                    dw.resultado += separacion + variable + ".set(\"" + p.idkey + "\",";
                    dw.resultado += getStrActor(p, 0);
                    dw.resultado += ");";
                }
                

                OnProgress(dw);
            }

            if (stopRequested)
            {
                OnStoppedByUser(dw);
            }
            else
            {
                OnCompleted(dw);
            }






        }

        
    }
}
