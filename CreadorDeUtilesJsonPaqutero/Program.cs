using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReneUtiles;
using ReneUtiles.Clases;

using BDManagerPaquete;
using CreadorDeUtilesJsonPaqutero.Logica;
using CreadorDeUtilesJsonPaqutero.Utiles;
using CreadorDeUtilesJsonPaqutero.Logica.Tareas;
using CreadorDeUtilesJsonPaqutero.Logica.Tareas.CreadoresStr;
using CreadorDeUtilesJsonPaqutero.Logica.Tareas.EscritoresDeArchivos;

using Delimon.Win32.IO;

namespace CreadorDeUtilesJsonPaqutero
{
    class Program:ConsolaBasica
    {
        static void Main(string[] args)
        {
            //new CreadorDatosJSON().crearArchivoConDatosPeliculas();
            crearMapPeliculas();
            cwl("termino");
            endC();
        }

        public static void crearMapPeliculas() {
            CreadorDeDatosJS_Peliculas cre = new CreadorDeDatosJS_Peliculas(
                new EventosConsola<DatosWorkedJS>("Crear Map Peliculas")
                );
            
            CreadorIndiceInverso_Peliculas creInvP = new CreadorIndiceInverso_Peliculas(
                new EventosConsola<DatosWorkedJS>("Crear Map Inverso Peliculas")
                );
            CreadorIndiceInverso_PeliculasConAutores creInvP_Au = new CreadorIndiceInverso_PeliculasConAutores(
                new EventosConsola<DatosWorkedJS>("Crear Map Inverso Peliculas Autor")
                );
            CreadorIndiceAlfabetico_Peliculas creP_Alf = new CreadorIndiceAlfabetico_Peliculas(
                new EventosConsola<DatosWorkedJS>("Crear Map Indice Alfabetico Peliculas")
                );

            string carpeta = @"C:\_COSAS\temporal\experimentos\c";
            EscribirArchivos esc = new EscribirArchivos(
                carpeta: new DirectoryInfo(carpeta)
                , eventos: new EventosConsola<DatosWorkedJS_CreadorDeArchivos>("Escribir Archivos de peliculas")
                );
            cre.addCompleted(
                (v, t) => {
                    esc.add(new ArchivoACrear(
                        nombre:"DatosPeliculasMap"
                        ,extencion:".js"
                        ,contenido:v.resultado
                        ));
                }
                );
            creInvP.addCompleted(
                (v, t) => {
                    esc.add(new ArchivoACrear(
                        nombre: "DatosPeliculasIndiceInversoSinAutoresMap"
                        , extencion: ".js"
                        , contenido: v.resultado
                        ));
                }
                );
            creInvP_Au.addCompleted(
                (v, t) => {
                    esc.add(new ArchivoACrear(
                        nombre: "DatosPeliculasIndiceInversoConAutoresMap"
                        , extencion: ".js"
                        , contenido: v.resultado
                        ));
                }
                );
            creP_Alf.addCompleted(
                (v, t) => {
                    esc.add(new ArchivoACrear(
                        nombre: "DatosPeliculasIndiceAlfabeticoMap"
                        , extencion: ".js"
                        , contenido: v.resultado
                        ));
                }
                );
            cre.addSiguiente(creInvP)
                .addSiguiente(creInvP_Au)
                .addSiguiente(creP_Alf)
                .addSiguiente(esc);
            cre.Start();
            //creInvP.addSiguiente(esc);
            //creInvP.Start();
        }
       
    }
}

