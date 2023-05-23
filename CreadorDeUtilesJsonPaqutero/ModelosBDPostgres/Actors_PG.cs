

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Actors_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_ACTORS="actors";
		public static readonly string COLUMNA_NOMBRE="Nombre";
		public static readonly string COLUMNA_FOTOACTOR="FotoActor";
		public static readonly string COLUMNA_MOSTRAR="Mostrar";
		public static readonly string COLUMNA_IMDB="imdb";
		public static readonly string COLUMNA_ID="Id";
		
		public string nombre;
		public string fotoactor;
		public bool? mostrar;
		public bool? imdb;
		
		public Actors_PG(string nombre,string fotoactor,bool? mostrar,bool? imdb,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.nombre=nombre;
			this.fotoactor=fotoactor;
			this.mostrar=mostrar;
			this.imdb=imdb;
		}
		public Actors_PG(I_BD_AdminPosgres apibd,string nombre,string fotoactor,bool? mostrar,bool? imdb):this(nombre,fotoactor,mostrar,imdb,-1,apibd){
		}
		public Actors_PG(Actors_PG v)
			:this(v.nombre,v.fotoactor,v.mostrar,v.imdb,v.idkey,v.apibd){
		}
		public List<Series_PG> getseries_actor(){
			return this.apibd.getSeries_PG_All_Idkey_actors(this.idkey);
		}
		public Series_PG addSeries_actor_PG(Series_PG series){
			if (this.idkey==-1){
				this.idkey=this.apibd.insertarActors_PG(this).idkey;
			}
			if (series.idkey==-1){
				series=this.apibd.insertarSeries_PG(series);
			}
			if (!this.apibd.existeSeries_actor_PG(series.idkey,this.idkey)){
				Series_actor_PG series_actor=new Series_actor_PG(this.apibd,series,this);
				this.apibd.insertarSeries_actor_PG(series_actor);
				return series;
			}
			return series;
		}
		public void removeSeries_actor_PG(Series_PG series){
			if (this.idkey!=-1&&series.idkey!=-1&&this.apibd.existeSeries_actor_PG(series.idkey,this.idkey)){
				Series_actor_PG series_actor=this.apibd.getSeries_actor_PG(series.idkey,this.idkey);
				series_actor.d();
			}
		}
		public List<Peliculas_PG> getpeliculas_actor(){
			return this.apibd.getPeliculas_PG_All_Idkey_actors(this.idkey);
		}
		public Peliculas_PG addPeliculas_actor_PG(Peliculas_PG peliculas){
			if (this.idkey==-1){
				this.idkey=this.apibd.insertarActors_PG(this).idkey;
			}
			if (peliculas.idkey==-1){
				peliculas=this.apibd.insertarPeliculas_PG(peliculas);
			}
			if (!this.apibd.existePeliculas_actor_PG(peliculas.idkey,this.idkey)){
				Peliculas_actor_PG peliculas_actor=new Peliculas_actor_PG(this.apibd,peliculas,this);
				this.apibd.insertarPeliculas_actor_PG(peliculas_actor);
				return peliculas;
			}
			return peliculas;
		}
		public void removePeliculas_actor_PG(Peliculas_PG peliculas){
			if (this.idkey!=-1&&peliculas.idkey!=-1&&this.apibd.existePeliculas_actor_PG(peliculas.idkey,this.idkey)){
				Peliculas_actor_PG peliculas_actor=this.apibd.getPeliculas_actor_PG(peliculas.idkey,this.idkey);
				peliculas_actor.d();
			}
		}
		public Actors_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarActors_PG(this);
			}
			return this.apibd.updateActors_PG(this);
		}
		public Actors_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Actors_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Actors_PG cn(I_BD_AdminPosgres bd){
			Actors_PG n= new Actors_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Actors_PG si(){
			if (this.apibd.existeActors_PG_id(this.idkey)){
				return this.apibd.updateActors_PG(this);
			}
			return this.apibd.insertarActors_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteActors_PG_ForId_CASCADE(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Actors_PG s = this;
			return textoInicial+"Actors_PG: idkey="+ s.idkey
				+" nombre="+s.nombre
				+" fotoactor="+s.fotoactor
				+" mostrar="+s.mostrar
				+" imdb="+s.imdb
			;
		}
		public string getStr(){ return getStr("");}
}
}
