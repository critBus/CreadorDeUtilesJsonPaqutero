using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReneUtiles;
using ReneUtiles.Clases;

using BDManagerPaquete;
using Delimon.Win32.IO;
namespace CreadorDeUtilesJsonPaqutero.Logica
{
    public class ConfiguracionCreadorDatosJS
    {
        public BDManager_Admin bd;
        public string variableMapPeliculas;
        public string variableMapIndiceInverso_SinActores;
        public string variableMapIndiceAlfabetico;
        public string variableMapIndiceInverso_ConActores;

        public string variableMapActores;
        public ConfiguracionCreadorDatosJS()
        {
            bd = new BDManager_Admin("cinema");
            bd.no_cl();
            variableMapPeliculas = "mapPeliculas";
            variableMapActores = "mapActores";
            variableMapIndiceInverso_SinActores = "mapPeliculasInverso_SinActores";
            variableMapIndiceInverso_ConActores = "mapPeliculasInverso_ConActores";
            variableMapIndiceAlfabetico = "mapPeliculas_IndiceAlfabetico";
        }
    }
}
