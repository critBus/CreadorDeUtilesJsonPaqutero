

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Sagas_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_SAGAS="sagas";
		public static readonly string COLUMNA_SAGA="Saga";
		public static readonly string COLUMNA_ID="Id";
		
		public string saga;
		
		public Sagas_PG(string saga,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.saga=saga;
		}
		public Sagas_PG(I_BD_AdminPosgres apibd,string saga):this(saga,-1,apibd){
		}
		public Sagas_PG(Sagas_PG v)
			:this(v.saga,v.idkey,v.apibd){
		}
		public Sagas_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarSagas_PG(this);
			}
			return this.apibd.updateSagas_PG(this);
		}
		public Sagas_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Sagas_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Sagas_PG cn(I_BD_AdminPosgres bd){
			Sagas_PG n= new Sagas_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Sagas_PG si(){
			if (this.apibd.existeSagas_PG_id(this.idkey)){
				return this.apibd.updateSagas_PG(this);
			}
			return this.apibd.insertarSagas_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteSagas_PG_ForId(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Sagas_PG s = this;
			return textoInicial+"Sagas_PG: idkey="+ s.idkey
				+" saga="+s.saga
			;
		}
		public string getStr(){ return getStr("");}
}
}
