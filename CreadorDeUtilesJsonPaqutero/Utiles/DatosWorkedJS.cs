using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreadorDeUtilesJsonPaqutero.Utiles
{
    public class DatosWorkedJS
    {
        public int cantidadTotal;
        public int indiceActual;

        public string resultado;

        public DatosWorkedJS() {
            this.cantidadTotal = 0;
            this.indiceActual = 1;
            this.resultado = "";
        }

        public void incremento() {
            indiceActual += 1;
        }
        public double getProgresoEntidad() {
            return ((double)indiceActual / (double)cantidadTotal) * 100;
        }
    }
}
