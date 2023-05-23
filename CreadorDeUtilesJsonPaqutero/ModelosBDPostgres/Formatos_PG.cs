

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Formatos_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_FORMATOS="formatos";
		public static readonly string COLUMNA_FORMATO="Formato";
		public static readonly string COLUMNA_ID="Id";
		
		public string formato;
		
		public Formatos_PG(string formato,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.formato=formato;
		}
		public Formatos_PG(I_BD_AdminPosgres apibd,string formato):this(formato,-1,apibd){
		}
		public Formatos_PG(Formatos_PG v)
			:this(v.formato,v.idkey,v.apibd){
		}
		public Formatos_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarFormatos_PG(this);
			}
			return this.apibd.updateFormatos_PG(this);
		}
		public Formatos_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Formatos_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Formatos_PG cn(I_BD_AdminPosgres bd){
			Formatos_PG n= new Formatos_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Formatos_PG si(){
			if (this.apibd.existeFormatos_PG_id(this.idkey)){
				return this.apibd.updateFormatos_PG(this);
			}
			return this.apibd.insertarFormatos_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteFormatos_PG_ForId(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Formatos_PG s = this;
			return textoInicial+"Formatos_PG: idkey="+ s.idkey
				+" formato="+s.formato
			;
		}
		public string getStr(){ return getStr("");}
}
}
