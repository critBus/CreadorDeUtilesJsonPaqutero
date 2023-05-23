

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Autors_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_AUTORS="autors";
		public static readonly string COLUMNA_NOMBRE="Nombre";
		public static readonly string COLUMNA_FOTO="Foto";
		public static readonly string COLUMNA_ID="Id";
		
		public string nombre;
		public string foto;
		
		public Autors_PG(string nombre,string foto,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.nombre=nombre;
			this.foto=foto;
		}
		public Autors_PG(I_BD_AdminPosgres apibd,string nombre,string foto):this(nombre,foto,-1,apibd){
		}
		public Autors_PG(Autors_PG v)
			:this(v.nombre,v.foto,v.idkey,v.apibd){
		}
		public List<Albums_PG> getListaDe_Albums_PG(){
			return this.apibd.getAlbums_PG_All_Idkey_idautor(this.idkey);
		}
		public Albums_PG addAlbums_PG(Albums_PG albums){
			if (this.idkey==-1){
				this.idkey=this.apibd.insertarAutors_PG(this).idkey;
				albums.idkey_idautor=this.idkey;
			}
			if (albums.idkey==-1){
				albums=this.apibd.insertarAlbums_PG(albums);
			}
			return albums;
		}
		public List<Dvd_PG> getListaDe_Dvd_PG(){
			return this.apibd.getDvd_PG_All_Autor(this.nombre);
		}
		public Dvd_PG addListaDeDVDs(Dvd_PG dvd){
			if (this.idkey==-1){
				this.idkey=this.apibd.insertarAutors_PG(this).idkey;
				dvd.autor=this.nombre;
			}
			if (dvd.idkey==-1){
				dvd=this.apibd.insertarDvd_PG(dvd);
			}
			return dvd;
		}
		public Autors_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarAutors_PG(this);
			}
			return this.apibd.updateAutors_PG(this);
		}
		public Autors_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Autors_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Autors_PG cn(I_BD_AdminPosgres bd){
			Autors_PG n= new Autors_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Autors_PG si(){
			if (this.apibd.existeAutors_PG_id(this.idkey)){
				return this.apibd.updateAutors_PG(this);
			}
			return this.apibd.insertarAutors_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteAutors_PG_ForId_CASCADE(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Autors_PG s = this;
			return textoInicial+"Autors_PG: idkey="+ s.idkey
				+" nombre="+s.nombre
				+" foto="+s.foto
			;
		}
		public string getStr(){ return getStr("");}
}
}
