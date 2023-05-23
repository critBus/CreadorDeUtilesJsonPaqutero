

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Seriestemporadas_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_SERIESTEMPORADAS="seriestemporadas";
		public static readonly string COLUMNA_TEMPORADA="Temporada";
		public static readonly string COLUMNA_CAPITULOS="Capitulos";
		public static readonly string COLUMNA_DEFINICION="Definicion";
		public static readonly string COLUMNA_ANNO="Anno";
		public static readonly string COLUMNA_IDIOMA="Idioma";
		public static readonly string COLUMNA_FORMATO="Formato";
		public static readonly string COLUMNA_IDSERIE="IdSerie";
		public static readonly string COLUMNA_ID="Id";
		
		public string temporada;
		public string capitulos;
		public string definicion;
		public string anno;
		public string idioma;
		public string formato;
		public int? idkey_idserie;
		
		public Seriestemporadas_PG(string temporada,string capitulos,string definicion,string anno,string idioma,string formato,int? idkey_idserie,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.temporada=temporada;
			this.capitulos=capitulos;
			this.definicion=definicion;
			this.anno=anno;
			this.idioma=idioma;
			this.formato=formato;
			this.idkey_idserie=idkey_idserie;
		}
		public Seriestemporadas_PG(I_BD_AdminPosgres apibd,string temporada,string capitulos,string definicion,string anno,string idioma,string formato,int? idkey_idserie):this(temporada,capitulos,definicion,anno,idioma,formato,idkey_idserie,-1,apibd){
		}
		public Seriestemporadas_PG(I_BD_AdminPosgres apibd,string temporada,string capitulos,string definicion,string anno,string idioma,string formato,Series_PG idserie):this(temporada,capitulos,definicion,anno,idioma,formato,idserie.idkey,-1,apibd){
		}
		public Seriestemporadas_PG(Seriestemporadas_PG v)
			:this(v.temporada,v.capitulos,v.definicion,v.anno,v.idioma,v.formato,v.idkey_idserie,v.idkey,v.apibd){
		}
		public Series_PG getIdserie(){
			return this.apibd.getSeries_PG_id(this.idkey_idserie);
		}
		public Seriestemporadas_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarSeriestemporadas_PG(this);
			}
			return this.apibd.updateSeriestemporadas_PG(this);
		}
		public Seriestemporadas_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Seriestemporadas_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Seriestemporadas_PG cn(I_BD_AdminPosgres bd){
			Seriestemporadas_PG n= new Seriestemporadas_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Seriestemporadas_PG si(){
			if (this.apibd.existeSeriestemporadas_PG_id(this.idkey)){
				return this.apibd.updateSeriestemporadas_PG(this);
			}
			return this.apibd.insertarSeriestemporadas_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteSeriestemporadas_PG_ForId(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Seriestemporadas_PG s = this;
			return textoInicial+"Seriestemporadas_PG: idkey="+ s.idkey
				+" temporada="+s.temporada
				+" capitulos="+s.capitulos
				+" definicion="+s.definicion
				+" anno="+s.anno
				+" idioma="+s.idioma
				+" formato="+s.formato
				+" idkey_idserie="+s.idkey_idserie
			;
		}
		public string getStr(){ return getStr("");}
}
}
