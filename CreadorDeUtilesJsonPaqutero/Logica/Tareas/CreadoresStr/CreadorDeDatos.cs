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
    public abstract class CreadorDeDatos : WorkerJS_General<DatosWorkedJS> 
    {
        public CreadorDeDatos(EventosWorker<DatosWorkedJS> evento):base() {
            this.eventos = evento;
        }

        public int separacion0;
         
        public CreadorDeDatos():base()
        {
            separacion0 = 0;
        }



        public string getSeparacionln(int indice, int separacion0)
        {
            string r = "\n";
            for (int i = 0; i < indice + separacion0; i++)
            {
                r += "\t";
            }
            return r;
        }

        public string getStrActor(Actors_PG a, int separacion0)
        {
            string separacion = getSeparacionln(0, separacion0);
            string separacion1 = getSeparacionln(1, separacion0);
            string separacion2 = getSeparacionln(2, separacion0);
            string separacion3 = getSeparacionln(3, separacion0);
            string separacion4 = getSeparacionln(4, separacion0);

            string mr = "";
            mr += separacion1 + "{";
            mr += separacion2 + "id:\"" + a.idkey + "\"";
            mr += separacion2 + ",nombre:`" + getStrCorrecto(a.nombre) + "`";
            mr += separacion2 + ",fotoactor:`" + a.fotoactor + "`";
            mr += separacion2 + ",mostrar:\"" + (a.mostrar??false).ToString().ToLower() + "\"";
            mr += separacion1 + "}";
            return mr;
        }
        public string getStrPelicula(Peliculas_PG p, int separacion0)
        {
            string separacion = getSeparacionln(0, separacion0);
            string separacion1 = getSeparacionln(1, separacion0);
            string separacion2 = getSeparacionln(2, separacion0);
            string separacion3 = getSeparacionln(3, separacion0);
            string separacion4 = getSeparacionln(4, separacion0);

            string mr = "";
            mr += separacion1 + "{";
            mr += separacion2 + "id:\"" + p.idkey + "\"";
            mr += separacion2 + ",nombre:`" + getStrCorrecto(p.nombre) + "`";
            mr += separacion2 + ",nombreing:`" + getStrCorrecto(p.nombreing) + "`";
            mr += separacion2 + ",subgenero:`" + p.subgenero + "`";
            mr += separacion2 + ",duracion:`" + p.duracion + "`";
            mr += separacion2 + ",anno:`" + p.anno + "`";
            mr += separacion2 + ",origen:`" + p.origen + "`";
            mr += separacion2 + ",sinopsis:`" + getStrCorrecto(p.sinopsis) + "`";
            mr += separacion2 + ",saga:`" + p.saga + "`";
            mr += separacion2 + ",fotopelicula:`" + p.fotopelicula + "`";
            mr += separacion2 + ",definicion:`" + p.definicion + "`";
            mr += separacion2 + ",idioma:`" + p.idioma + "`";
            mr += separacion2 + ",formato:`" + p.formato + "`";
            mr += separacion2 + ",genero:`" + p.genero + "`";
            mr += separacion2 + ",actores:[";
            List<Actors_PG> la = p.getpeliculas_actor();
            foreach (Actors_PG a in la)
            {
                //mr += getStrActor(a, 2) + ",";
                if (a.mostrar??false) {
                    mr += "\"" + a.getIdkey() + "\"" + ",";
                }
                
            }
            mr += separacion2 + "]";
            mr += separacion1 + "}";
            return mr;
        }
        //

        static Dictionary<char, char> equivalencias = new Dictionary<char, char>
    {
        {'á', 'a'},
        {'é', 'e'},
        {'í', 'i'},
        {'ó', 'o'},
        {'ú', 'u'},
        {'ü', 'u'},
        {'ñ', 'n'}
        // Puedes agregar más caracteres aquí
    };
        public static string crearClave(string texto)
        {
            // Diccionario con las letras con tilde y sus equivalentes sin tilde


            string textoFiltrado = "";

            // Recorremos cada carácter del texto original
            foreach (char c in texto)
            {
                // Si es una letra o número en minúscula, lo agregamos al texto filtrado
                if (char.IsLetterOrDigit(c) && char.IsLower(c))
                {
                    textoFiltrado += c;
                }
                // Si es una letra en mayúscula, la convertimos a minúscula y la agregamos
                else if (char.IsLetter(c) && char.IsUpper(c))
                {
                    textoFiltrado += char.ToLower(c);
                }


            }
            string textoFiltrado_R = "";
            foreach (char c in textoFiltrado)
            {
                // Si es una letra con tilde, la reemplazamos por su equivalente sin tilde y la agregamos
                if (equivalencias.ContainsKey(c))
                {
                    textoFiltrado_R += equivalencias[c];
                }
                else
                {
                    textoFiltrado_R += c;
                }
            }
            return textoFiltrado_R;
        }

        public static string getStrCorrecto(string texto) {
            return texto != null ? texto.Replace("`","") : "";
        }

    }
}

