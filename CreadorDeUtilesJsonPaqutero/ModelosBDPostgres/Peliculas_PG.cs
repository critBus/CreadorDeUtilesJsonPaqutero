

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Peliculas_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_PELICULAS="peliculas";
		public static readonly string COLUMNA_NOMBREING="NombreIng";
		public static readonly string COLUMNA_NOMBRE="Nombre";
		public static readonly string COLUMNA_SUBGENERO="Subgenero";
		public static readonly string COLUMNA_DURACION="Duracion";
		public static readonly string COLUMNA_ANNO="Anno";
		public static readonly string COLUMNA_ORIGEN="Origen";
		public static readonly string COLUMNA_SINOPSIS="Sinopsis";
		public static readonly string COLUMNA_SAGA="Saga";
		public static readonly string COLUMNA_FOTOPELICULA="FotoPelicula";
		public static readonly string COLUMNA_DEFINICION="Definicion";
		public static readonly string COLUMNA_IDIOMA="Idioma";
		public static readonly string COLUMNA_FORMATO="Formato";
		public static readonly string COLUMNA_GENERO="Genero";
		public static readonly string COLUMNA_FILM_AFFINITY="film_affinity";
		public static readonly string COLUMNA_IMDB="imdb";
		public static readonly string COLUMNA_REVIEWED="reviewed";
		public static readonly string COLUMNA_ID="Id";
		
		public string nombreing;
		public string nombre;
		public string subgenero;
		public string duracion;
		public int? anno;
		public string origen;
		public string sinopsis;
		public string saga;
		public string fotopelicula;
		public string definicion;
		public string idioma;
		public string formato;
		public string genero;
		public bool? film_affinity;
		public bool? imdb;
		public bool? reviewed;
		
		public Peliculas_PG(string nombreing,string nombre,string subgenero,string duracion,int? anno,string origen,string sinopsis,string saga,string fotopelicula,string definicion,string idioma,string formato,string genero,bool? film_affinity,bool? imdb,bool? reviewed,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.nombreing=nombreing;
			this.nombre=nombre;
			this.subgenero=subgenero;
			this.duracion=duracion;
			this.anno=anno;
			this.origen=origen;
			this.sinopsis=sinopsis;
			this.saga=saga;
			this.fotopelicula=fotopelicula;
			this.definicion=definicion;
			this.idioma=idioma;
			this.formato=formato;
			this.genero=genero;
			this.film_affinity=film_affinity;
			this.imdb=imdb;
			this.reviewed=reviewed;
		}
		public Peliculas_PG(I_BD_AdminPosgres apibd,string nombreing,string nombre,string subgenero,string duracion,int? anno,string origen,string sinopsis,string saga,string fotopelicula,string definicion,string idioma,string formato,string genero,bool? film_affinity,bool? imdb,bool? reviewed):this(nombreing,nombre,subgenero,duracion,anno,origen,sinopsis,saga,fotopelicula,definicion,idioma,formato,genero,film_affinity,imdb,reviewed,-1,apibd){
		}
		public Peliculas_PG(Peliculas_PG v)
			:this(v.nombreing,v.nombre,v.subgenero,v.duracion,v.anno,v.origen,v.sinopsis,v.saga,v.fotopelicula,v.definicion,v.idioma,v.formato,v.genero,v.film_affinity,v.imdb,v.reviewed,v.idkey,v.apibd){
		}
		public List<Actors_PG> getpeliculas_actor(){
			return this.apibd.getActors_PG_All_Idkey_peliculas(this.idkey);
		}
		public Actors_PG addPeliculas_actor_PG(Actors_PG actors){
			if (this.idkey==-1){
				this.idkey=this.apibd.insertarPeliculas_PG(this).idkey;
			}
			if (actors.idkey==-1){
				actors=this.apibd.insertarActors_PG(actors);
			}
			if (!this.apibd.existePeliculas_actor_PG(this.idkey,actors.idkey)){
				Peliculas_actor_PG peliculas_actor=new Peliculas_actor_PG(this.apibd,this,actors);
				this.apibd.insertarPeliculas_actor_PG(peliculas_actor);
				return actors;
			}
			return actors;
		}
		public void removePeliculas_actor_PG(Actors_PG actors){
			if (this.idkey!=-1&&actors.idkey!=-1&&this.apibd.existePeliculas_actor_PG(this.idkey,actors.idkey)){
				Peliculas_actor_PG peliculas_actor=this.apibd.getPeliculas_actor_PG(this.idkey,actors.idkey);
				peliculas_actor.d();
			}
		}
		public Peliculas_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarPeliculas_PG(this);
			}
			return this.apibd.updatePeliculas_PG(this);
		}
		public Peliculas_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Peliculas_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Peliculas_PG cn(I_BD_AdminPosgres bd){
			Peliculas_PG n= new Peliculas_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Peliculas_PG si(){
			if (this.apibd.existePeliculas_PG_id(this.idkey)){
				return this.apibd.updatePeliculas_PG(this);
			}
			return this.apibd.insertarPeliculas_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deletePeliculas_PG_ForId_CASCADE(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Peliculas_PG s = this;
			return textoInicial+"Peliculas_PG: idkey="+ s.idkey
				+" nombreing="+s.nombreing
				+" nombre="+s.nombre
				+" subgenero="+s.subgenero
				+" duracion="+s.duracion
				+" anno="+s.anno
				+" origen="+s.origen
				+" sinopsis="+s.sinopsis
				+" saga="+s.saga
				+" fotopelicula="+s.fotopelicula
				+" definicion="+s.definicion
				+" idioma="+s.idioma
				+" formato="+s.formato
				+" genero="+s.genero
				+" film_affinity="+s.film_affinity
				+" imdb="+s.imdb
				+" reviewed="+s.reviewed
			;
		}
		public string getStr(){ return getStr("");}
}
}
