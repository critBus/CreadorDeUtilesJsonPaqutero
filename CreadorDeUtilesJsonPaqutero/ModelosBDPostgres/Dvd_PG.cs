

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Dvd_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_DVD="dvd";
		public static readonly string COLUMNA_TITULO="Titulo";
		public static readonly string COLUMNA_AUTOR="Autor";
		public static readonly string COLUMNA_ANNO="Anno";
		public static readonly string COLUMNA_FOTO="Foto";
		public static readonly string COLUMNA_FOTOBACK="FotoBack";
		public static readonly string COLUMNA_ID="Id";
		
		public string titulo;
		public string autor;
		public int? anno;
		public string foto;
		public string fotoback;
		
		public Dvd_PG(string titulo,string autor,int? anno,string foto,string fotoback,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.titulo=titulo;
			this.autor=autor;
			this.anno=anno;
			this.foto=foto;
			this.fotoback=fotoback;
		}
		public Dvd_PG(I_BD_AdminPosgres apibd,string titulo,string autor,int? anno,string foto,string fotoback):this(titulo,autor,anno,foto,fotoback,-1,apibd){
		}
		public Dvd_PG(Dvd_PG v)
			:this(v.titulo,v.autor,v.anno,v.foto,v.fotoback,v.idkey,v.apibd){
		}
		public List<Canciondvd_PG> getListaDe_Canciondvd_PG(){
			return this.apibd.getCanciondvd_PG_All_Idkey_iddvd(this.idkey);
		}
		public Canciondvd_PG addCanciondvd_PG(Canciondvd_PG canciondvd){
			if (this.idkey==-1){
				this.idkey=this.apibd.insertarDvd_PG(this).idkey;
				canciondvd.idkey_iddvd=this.idkey;
			}
			if (canciondvd.idkey==-1){
				canciondvd=this.apibd.insertarCanciondvd_PG(canciondvd);
			}
			return canciondvd;
		}
		public Dvd_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarDvd_PG(this);
			}
			return this.apibd.updateDvd_PG(this);
		}
		public Dvd_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Dvd_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Dvd_PG cn(I_BD_AdminPosgres bd){
			Dvd_PG n= new Dvd_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Dvd_PG si(){
			if (this.apibd.existeDvd_PG_id(this.idkey)){
				return this.apibd.updateDvd_PG(this);
			}
			return this.apibd.insertarDvd_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteDvd_PG_ForId_CASCADE(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Dvd_PG s = this;
			return textoInicial+"Dvd_PG: idkey="+ s.idkey
				+" titulo="+s.titulo
				+" autor="+s.autor
				+" anno="+s.anno
				+" foto="+s.foto
				+" fotoback="+s.fotoback
			;
		}
		public string getStr(){ return getStr("");}
}
}
