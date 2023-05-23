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
    class CreadorDeDatosJS_Peliculas:CreadorDeDatos
    {

        public CreadorDeDatosJS_Peliculas(EventosWorker<DatosWorkedJS> evento) : base(evento) { }
        protected override void accion()
        {
            string separacion = getSeparacionln(0, separacion0);
            string separacion1 = getSeparacionln(1, separacion0);
            string separacion2 = getSeparacionln(2, separacion0);
            string separacion3 = getSeparacionln(3, separacion0);
            string separacion4 = getSeparacionln(4, separacion0);

            


            DatosWorkedJS dw = new DatosWorkedJS();

            

            cwl("creando str...");
            List<Peliculas_PG> lp = cnf.bd.getPeliculas_PG_All();
            dw.cantidadTotal = lp.Count;
            OnStarting(dw);

            dw.resultado = separacion + "const " + cnf.variableMapPeliculas + "=new Map();";
            foreach (Peliculas_PG p in lp)
            {
                //if (dw.indiceActual == 10)
                //{
                //    break;
                //}

                if (stopRequested) {
                    break;
                }
                dw.resultado += separacion + cnf.variableMapPeliculas + ".set(\"" + p.idkey + "\",";
                dw.resultado += getStrPelicula(p, 0);
                dw.resultado += ");";

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

        //
        //public string crearMapPeliculas(int separacion0)
        //{
        //    string separacion = getSeparacionln(0, separacion0);
        //    string separacion1 = getSeparacionln(1, separacion0);
        //    string separacion2 = getSeparacionln(2, separacion0);
        //    string separacion3 = getSeparacionln(3, separacion0);
        //    string separacion4 = getSeparacionln(4, separacion0);

        //    string r = separacion + "const " + cnf.variableMapPeliculas + "=new Map();";
        //    DatosWorkedJS dw = new DatosWorkedJS();
        //    Starting += v => {
        //        cwl("creando str...");
        //        List<Peliculas_PG> lp = cnf.bd.getPeliculas_PG_All();
        //        dw.cantidadTotal = lp.Count;
        //        foreach (Peliculas_PG p in lp)
        //        {
        //            r += separacion + cnf.variableMapPeliculas + ".set(\"" + p.idkey + "\",";
        //            r += getStrPelicula(p, 0);
        //            r += ");";

        //            w_mapPeliculas.
        //        }
        //    };







        //    return r;
        //}

    }
}
