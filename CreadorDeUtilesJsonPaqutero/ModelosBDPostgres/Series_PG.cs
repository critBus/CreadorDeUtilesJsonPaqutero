

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Series_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_SERIES="series";
		public static readonly string COLUMNA_TIPO="Tipo";
		public static readonly string COLUMNA_TITULO="Titulo";
		public static readonly string COLUMNA_TITULOING="TituloIng";
		public static readonly string COLUMNA_ORIGEN="Origen";
		public static readonly string COLUMNA_SINOPSIS="Sinopsis";
		public static readonly string COLUMNA_FOTOSERIE="FotoSerie";
		public static readonly string COLUMNA_INICIAL="Inicial";
		public static readonly string COLUMNA_ENCURSO="EnCurso";
		public static readonly string COLUMNA_GENERO="Genero";
		public static readonly string COLUMNA_FILM_AFFINITY="film_affinity";
		public static readonly string COLUMNA_IMDB="imdb";
		public static readonly string COLUMNA_REVIEWED="reviewed";
		public static readonly string COLUMNA_ID="Id";
		
		public string tipo;
		public string titulo;
		public string tituloing;
		public string origen;
		public string sinopsis;
		public string fotoserie;
		public string inicial;
		public bool? encurso;
		public string genero;
		public bool? film_affinity;
		public bool? imdb;
		public bool? reviewed;
		
		public Series_PG(string tipo,string titulo,string tituloing,string origen,string sinopsis,string fotoserie,string inicial,bool? encurso,string genero,bool? film_affinity,bool? imdb,bool? reviewed,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.tipo=tipo;
			this.titulo=titulo;
			this.tituloing=tituloing;
			this.origen=origen;
			this.sinopsis=sinopsis;
			this.fotoserie=fotoserie;
			this.inicial=inicial;
			this.encurso=encurso;
			this.genero=genero;
			this.film_affinity=film_affinity;
			this.imdb=imdb;
			this.reviewed=reviewed;
		}
		public Series_PG(I_BD_AdminPosgres apibd,string tipo,string titulo,string tituloing,string origen,string sinopsis,string fotoserie,string inicial,bool? encurso,string genero,bool? film_affinity,bool? imdb,bool? reviewed):this(tipo,titulo,tituloing,origen,sinopsis,fotoserie,inicial,encurso,genero,film_affinity,imdb,reviewed,-1,apibd){
		}
		public Series_PG(Series_PG v)
			:this(v.tipo,v.titulo,v.tituloing,v.origen,v.sinopsis,v.fotoserie,v.inicial,v.encurso,v.genero,v.film_affinity,v.imdb,v.reviewed,v.idkey,v.apibd){
		}
		public List<Seriestemporadas_PG> getListaDe_Seriestemporadas_PG(){
			return this.apibd.getSeriestemporadas_PG_All_Idkey_idserie(this.idkey);
		}
		public Seriestemporadas_PG addSeriestemporadas_PG(Seriestemporadas_PG seriestemporadas){
			if (this.idkey==-1){
				this.idkey=this.apibd.insertarSeries_PG(this).idkey;
				seriestemporadas.idkey_idserie=this.idkey;
			}
			if (seriestemporadas.idkey==-1){
				seriestemporadas=this.apibd.insertarSeriestemporadas_PG(seriestemporadas);
			}
			return seriestemporadas;
		}
		public List<Actors_PG> getseries_actor(){
			return this.apibd.getActors_PG_All_Idkey_series(this.idkey);
		}
		public Actors_PG addSeries_actor_PG(Actors_PG actors){
			if (this.idkey==-1){
				this.idkey=this.apibd.insertarSeries_PG(this).idkey;
			}
			if (actors.idkey==-1){
				actors=this.apibd.insertarActors_PG(actors);
			}
			if (!this.apibd.existeSeries_actor_PG(this.idkey,actors.idkey)){
				Series_actor_PG series_actor=new Series_actor_PG(this.apibd,this,actors);
				this.apibd.insertarSeries_actor_PG(series_actor);
				return actors;
			}
			return actors;
		}
		public void removeSeries_actor_PG(Actors_PG actors){
			if (this.idkey!=-1&&actors.idkey!=-1&&this.apibd.existeSeries_actor_PG(this.idkey,actors.idkey)){
				Series_actor_PG series_actor=this.apibd.getSeries_actor_PG(this.idkey,actors.idkey);
				series_actor.d();
			}
		}
		public Series_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarSeries_PG(this);
			}
			return this.apibd.updateSeries_PG(this);
		}
		public Series_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Series_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Series_PG cn(I_BD_AdminPosgres bd){
			Series_PG n= new Series_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Series_PG si(){
			if (this.apibd.existeSeries_PG_id(this.idkey)){
				return this.apibd.updateSeries_PG(this);
			}
			return this.apibd.insertarSeries_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteSeries_PG_ForId_CASCADE(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Series_PG s = this;
			return textoInicial+"Series_PG: idkey="+ s.idkey
				+" tipo="+s.tipo
				+" titulo="+s.titulo
				+" tituloing="+s.tituloing
				+" origen="+s.origen
				+" sinopsis="+s.sinopsis
				+" fotoserie="+s.fotoserie
				+" inicial="+s.inicial
				+" encurso="+s.encurso
				+" genero="+s.genero
				+" film_affinity="+s.film_affinity
				+" imdb="+s.imdb
				+" reviewed="+s.reviewed
			;
		}
		public string getStr(){ return getStr("");}
}
}
