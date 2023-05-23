

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Peliculas_actor_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_PELICULAS_ACTOR="peliculas_actor";
		public static readonly string COLUMNA_MOVIE_ID="movie_id";
		public static readonly string COLUMNA_ACTOR_ID="actor_id";
		public static readonly string COLUMNA_ID="id";
		
		public int? idkey_movie_id;
		public int? idkey_actor_id;
		
		public Peliculas_actor_PG(int? idkey_movie_id,int? idkey_actor_id,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.idkey_movie_id=idkey_movie_id;
			this.idkey_actor_id=idkey_actor_id;
		}
		public Peliculas_actor_PG(I_BD_AdminPosgres apibd,int? idkey_movie_id,int? idkey_actor_id):this(idkey_movie_id,idkey_actor_id,-1,apibd){
		}
		public Peliculas_actor_PG(I_BD_AdminPosgres apibd,Peliculas_PG movie_id,Actors_PG actor_id):this(movie_id.idkey,actor_id.idkey,-1,apibd){
		}
		public Peliculas_actor_PG(Peliculas_actor_PG v)
			:this(v.idkey_movie_id,v.idkey_actor_id,v.idkey,v.apibd){
		}
		public Peliculas_PG getMovie_id(){
			return this.apibd.getPeliculas_PG_id(this.idkey_movie_id);
		}
		public Actors_PG getActor_id(){
			return this.apibd.getActors_PG_id(this.idkey_actor_id);
		}
		public Peliculas_actor_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarPeliculas_actor_PG(this);
			}
			return this.apibd.updatePeliculas_actor_PG(this);
		}
		public Peliculas_actor_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Peliculas_actor_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Peliculas_actor_PG cn(I_BD_AdminPosgres bd){
			Peliculas_actor_PG n= new Peliculas_actor_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Peliculas_actor_PG si(){
			if (this.apibd.existePeliculas_actor_PG_id(this.idkey)){
				return this.apibd.updatePeliculas_actor_PG(this);
			}
			return this.apibd.insertarPeliculas_actor_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deletePeliculas_actor_PG_ForId(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Peliculas_actor_PG s = this;
			return textoInicial+"Peliculas_actor_PG: idkey="+ s.idkey
				+" idkey_movie_id="+s.idkey_movie_id
				+" idkey_actor_id="+s.idkey_actor_id
			;
		}
		public string getStr(){ return getStr("");}
}
}
