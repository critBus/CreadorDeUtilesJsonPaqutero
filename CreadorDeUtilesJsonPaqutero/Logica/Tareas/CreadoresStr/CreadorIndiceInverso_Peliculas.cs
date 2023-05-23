using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDManagerPaquete;
using Delimon.Win32.IO;
using CreadorDeUtilesJsonPaqutero.Utiles;
using CreadorDeUtilesJsonPaqutero.Logica;
using CreadorDeUtilesJsonPaqutero.Logica.Tareas;
namespace CreadorDeUtilesJsonPaqutero.Logica.Tareas.CreadoresStr
{
    public class CreadorIndiceInverso_Peliculas : CreadorDeDatos
    {
        public CreadorIndiceInverso_Peliculas(EventosWorker<DatosWorkedJS> evento) : base(evento) { }
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
            dw.cantidadTotal = lp.Count*2;
            OnStarting(dw);
            dw.resultado = separacion + "const " + cnf.variableMapIndiceInverso_SinActores + "=new Map();";
            Dictionary<string, HashSet<int>> D = new Dictionary<string, HashSet<int>>();
            Action<string, Peliculas_PG> addD = (v,p) => {
                string clave = crearClave(v);
                if (!D.ContainsKey(clave)) {
                    D.Add(clave,new HashSet<int>());
                }
                D[clave].Add(p.getIdkey()??0);
            };

            foreach (Peliculas_PG p in lp)
            {
                //if (dw.indiceActual == 10)
                //{
                //    break;
                //}

                if (stopRequested)
                {
                    break;
                }
                if (p.nombre!=null&& p.nombre.Trim().Length>0) {
                    string[] palabras = split(p.nombre, " ");
                    foreach (var palabra in palabras)
                    {
                        addD(palabra,p);
                    }
                }
                if (p.nombreing != null && p.nombreing.Trim().Length > 0)
                {
                    string[] palabras = split(p.nombreing, " ");
                    foreach (var palabra in palabras)
                    {
                        addD(palabra, p);
                    }
                }
                OnProgress(dw);

            }

            foreach (var kp in D)
            {
                if (stopRequested)
                {
                    break;
                }
                dw.resultado += separacion 
                    + cnf.variableMapIndiceInverso_SinActores 
                    + ".set(\"" + kp.Key + "\",";
                dw.resultado +=  "[";
                foreach (var id in kp.Value)
                {
                    dw.resultado += "\""+id + "\",";
                }
                dw.resultado += "]);";
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
