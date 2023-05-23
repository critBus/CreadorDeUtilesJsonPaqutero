

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Albums_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_ALBUMS="albums";
		public static readonly string COLUMNA_TITULO="Titulo";
		public static readonly string COLUMNA_ANNO="Anno";
		public static readonly string COLUMNA_FOTO="Foto";
		public static readonly string COLUMNA_IDAUTORNAVIGATIONID="IdAutorNavigationId";
		public static readonly string COLUMNA_FOTOBACK="FotoBack";
		public static readonly string COLUMNA_IDAUTOR="IdAutor";
		public static readonly string COLUMNA_ID="Id";
		
		public string titulo;
		public int? anno;
		public string foto;
		public int? idautornavigationid;
		public string fotoback;
		public int? idkey_idautor;
		
		public Albums_PG(string titulo,int? anno,string foto,int? idautornavigationid,string fotoback,int? idkey_idautor,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.titulo=titulo;
			this.anno=anno;
			this.foto=foto;
			this.idautornavigationid=idautornavigationid;
			this.fotoback=fotoback;
			this.idkey_idautor=idkey_idautor;
		}
		public Albums_PG(I_BD_AdminPosgres apibd,string titulo,int? anno,string foto,int? idautornavigationid,string fotoback,int? idkey_idautor):this(titulo,anno,foto,idautornavigationid,fotoback,idkey_idautor,-1,apibd){
		}
		public Albums_PG(I_BD_AdminPosgres apibd,string titulo,int? anno,string foto,int? idautornavigationid,string fotoback,Autors_PG idautor):this(titulo,anno,foto,idautornavigationid,fotoback,idautor.idkey,-1,apibd){
		}
		public Albums_PG(Albums_PG v)
			:this(v.titulo,v.anno,v.foto,v.idautornavigationid,v.fotoback,v.idkey_idautor,v.idkey,v.apibd){
		}
		public Autors_PG getIdautor(){
			return this.apibd.getAutors_PG_id(this.idkey_idautor);
		}
		public List<Cancionalbums_PG> getListaDe_Cancionalbums_PG(){
			return this.apibd.getCancionalbums_PG_All_Idkey_idalbum(this.idkey);
		}
		public Cancionalbums_PG addCancionalbums_PG(Cancionalbums_PG cancionalbums){
			if (this.idkey==-1){
				this.idkey=this.apibd.insertarAlbums_PG(this).idkey;
				cancionalbums.idkey_idalbum=this.idkey;
			}
			if (cancionalbums.idkey==-1){
				cancionalbums=this.apibd.insertarCancionalbums_PG(cancionalbums);
			}
			return cancionalbums;
		}
		public Albums_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarAlbums_PG(this);
			}
			return this.apibd.updateAlbums_PG(this);
		}
		public Albums_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Albums_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Albums_PG cn(I_BD_AdminPosgres bd){
			Albums_PG n= new Albums_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Albums_PG si(){
			if (this.apibd.existeAlbums_PG_id(this.idkey)){
				return this.apibd.updateAlbums_PG(this);
			}
			return this.apibd.insertarAlbums_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteAlbums_PG_ForId_CASCADE(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Albums_PG s = this;
			return textoInicial+"Albums_PG: idkey="+ s.idkey
				+" titulo="+s.titulo
				+" anno="+s.anno
				+" foto="+s.foto
				+" idautornavigationid="+s.idautornavigationid
				+" fotoback="+s.fotoback
				+" idkey_idautor="+s.idkey_idautor
			;
		}
		public string getStr(){ return getStr("");}
}
}
