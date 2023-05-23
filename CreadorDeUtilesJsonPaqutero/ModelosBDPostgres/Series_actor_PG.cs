

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Series_actor_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_SERIES_ACTOR="series_actor";
		public static readonly string COLUMNA_SERIAL_ID="serial_id";
		public static readonly string COLUMNA_ACTOR_ID="actor_id";
		public static readonly string COLUMNA_ID="id";
		
		public int? idkey_serial_id;
		public int? idkey_actor_id;
		
		public Series_actor_PG(int? idkey_serial_id,int? idkey_actor_id,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.idkey_serial_id=idkey_serial_id;
			this.idkey_actor_id=idkey_actor_id;
		}
		public Series_actor_PG(I_BD_AdminPosgres apibd,int? idkey_serial_id,int? idkey_actor_id):this(idkey_serial_id,idkey_actor_id,-1,apibd){
		}
		public Series_actor_PG(I_BD_AdminPosgres apibd,Series_PG serial_id,Actors_PG actor_id):this(serial_id.idkey,actor_id.idkey,-1,apibd){
		}
		public Series_actor_PG(Series_actor_PG v)
			:this(v.idkey_serial_id,v.idkey_actor_id,v.idkey,v.apibd){
		}
		public Series_PG getSerial_id(){
			return this.apibd.getSeries_PG_id(this.idkey_serial_id);
		}
		public Actors_PG getActor_id(){
			return this.apibd.getActors_PG_id(this.idkey_actor_id);
		}
		public Series_actor_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarSeries_actor_PG(this);
			}
			return this.apibd.updateSeries_actor_PG(this);
		}
		public Series_actor_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Series_actor_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Series_actor_PG cn(I_BD_AdminPosgres bd){
			Series_actor_PG n= new Series_actor_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Series_actor_PG si(){
			if (this.apibd.existeSeries_actor_PG_id(this.idkey)){
				return this.apibd.updateSeries_actor_PG(this);
			}
			return this.apibd.insertarSeries_actor_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteSeries_actor_PG_ForId(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Series_actor_PG s = this;
			return textoInicial+"Series_actor_PG: idkey="+ s.idkey
				+" idkey_serial_id="+s.idkey_serial_id
				+" idkey_actor_id="+s.idkey_actor_id
			;
		}
		public string getStr(){ return getStr("");}
}
}
