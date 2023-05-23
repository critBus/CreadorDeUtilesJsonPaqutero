

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Cancionalbums_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_CANCIONALBUMS="cancionalbums";
		public static readonly string COLUMNA_TITULO="Titulo";
		public static readonly string COLUMNA_IDALBUM="IdAlbum";
		public static readonly string COLUMNA_ID="Id";
		
		public string titulo;
		public int? idkey_idalbum;
		
		public Cancionalbums_PG(string titulo,int? idkey_idalbum,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.titulo=titulo;
			this.idkey_idalbum=idkey_idalbum;
		}
		public Cancionalbums_PG(I_BD_AdminPosgres apibd,string titulo,int? idkey_idalbum):this(titulo,idkey_idalbum,-1,apibd){
		}
		public Cancionalbums_PG(I_BD_AdminPosgres apibd,string titulo,Albums_PG idalbum):this(titulo,idalbum.idkey,-1,apibd){
		}
		public Cancionalbums_PG(Cancionalbums_PG v)
			:this(v.titulo,v.idkey_idalbum,v.idkey,v.apibd){
		}
		public Albums_PG getIdalbum(){
			return this.apibd.getAlbums_PG_id(this.idkey_idalbum);
		}
		public Cancionalbums_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarCancionalbums_PG(this);
			}
			return this.apibd.updateCancionalbums_PG(this);
		}
		public Cancionalbums_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Cancionalbums_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Cancionalbums_PG cn(I_BD_AdminPosgres bd){
			Cancionalbums_PG n= new Cancionalbums_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Cancionalbums_PG si(){
			if (this.apibd.existeCancionalbums_PG_id(this.idkey)){
				return this.apibd.updateCancionalbums_PG(this);
			}
			return this.apibd.insertarCancionalbums_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteCancionalbums_PG_ForId(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Cancionalbums_PG s = this;
			return textoInicial+"Cancionalbums_PG: idkey="+ s.idkey
				+" titulo="+s.titulo
				+" idkey_idalbum="+s.idkey_idalbum
			;
		}
		public string getStr(){ return getStr("");}
}
}
