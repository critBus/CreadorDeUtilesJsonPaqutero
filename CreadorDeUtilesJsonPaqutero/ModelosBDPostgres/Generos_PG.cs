

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Generos_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_GENEROS="generos";
		public static readonly string COLUMNA_GENERO="Genero";
		public static readonly string COLUMNA_FOTOGENERO="FotoGenero";
		public static readonly string COLUMNA_ID="Id";
		
		public string genero;
		public string fotogenero;
		
		public Generos_PG(string genero,string fotogenero,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.genero=genero;
			this.fotogenero=fotogenero;
		}
		public Generos_PG(I_BD_AdminPosgres apibd,string genero,string fotogenero):this(genero,fotogenero,-1,apibd){
		}
		public Generos_PG(Generos_PG v)
			:this(v.genero,v.fotogenero,v.idkey,v.apibd){
		}
		public Generos_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarGeneros_PG(this);
			}
			return this.apibd.updateGeneros_PG(this);
		}
		public Generos_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Generos_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Generos_PG cn(I_BD_AdminPosgres bd){
			Generos_PG n= new Generos_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Generos_PG si(){
			if (this.apibd.existeGeneros_PG_id(this.idkey)){
				return this.apibd.updateGeneros_PG(this);
			}
			return this.apibd.insertarGeneros_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteGeneros_PG_ForId(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Generos_PG s = this;
			return textoInicial+"Generos_PG: idkey="+ s.idkey
				+" genero="+s.genero
				+" fotogenero="+s.fotogenero
			;
		}
		public string getStr(){ return getStr("");}
}
}
