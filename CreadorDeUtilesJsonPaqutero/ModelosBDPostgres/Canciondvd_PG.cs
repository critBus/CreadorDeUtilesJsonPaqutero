

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
public class Canciondvd_PG:ModeloDeApiBD<I_BD_AdminPosgres> {
		public static readonly string TABLA_CANCIONDVD="canciondvd";
		public static readonly string COLUMNA_NOMBRE="Nombre";
		public static readonly string COLUMNA_IDDVD="IdDvd";
		public static readonly string COLUMNA_ID="Id";
		
		public string nombre;
		public int? idkey_iddvd;
		
		public Canciondvd_PG(string nombre,int? idkey_iddvd,int? idkey,I_BD_AdminPosgres apibd):base(idkey,apibd){
			this.nombre=nombre;
			this.idkey_iddvd=idkey_iddvd;
		}
		public Canciondvd_PG(I_BD_AdminPosgres apibd,string nombre,int? idkey_iddvd):this(nombre,idkey_iddvd,-1,apibd){
		}
		public Canciondvd_PG(I_BD_AdminPosgres apibd,string nombre,Dvd_PG iddvd):this(nombre,iddvd.idkey,-1,apibd){
		}
		public Canciondvd_PG(Canciondvd_PG v)
			:this(v.nombre,v.idkey_iddvd,v.idkey,v.apibd){
		}
		public Dvd_PG getIddvd(){
			return this.apibd.getDvd_PG_id(this.idkey_iddvd);
		}
		public Canciondvd_PG s(){
			if (this.idkey==-1){
				return this.apibd.insertarCanciondvd_PG(this);
			}
			return this.apibd.updateCanciondvd_PG(this);
		}
		public Canciondvd_PG sn(I_BD_AdminPosgres bd){
			int? idAnterior=this.idkey;
			this.idkey=-1;
			I_BD_AdminPosgres bdAnterior=this.apibd;
			this.apibd=bd;
			Canciondvd_PG n=s();
			this.idkey=idAnterior;
			this.apibd=bdAnterior;
			return n;
		}
		public Canciondvd_PG cn(I_BD_AdminPosgres bd){
			Canciondvd_PG n= new Canciondvd_PG(this);
			n.idkey=-1;
			n.apibd=bd;
			return n;
		}
		public Canciondvd_PG si(){
			if (this.apibd.existeCanciondvd_PG_id(this.idkey)){
				return this.apibd.updateCanciondvd_PG(this);
			}
			return this.apibd.insertarCanciondvd_PG(this);
		}
		public void d(){
			if (this.idkey!=-1){
				this.apibd.deleteCanciondvd_PG_ForId(this.idkey);
			}
		}
		public string getStr(String textoInicial){
			Canciondvd_PG s = this;
			return textoInicial+"Canciondvd_PG: idkey="+ s.idkey
				+" nombre="+s.nombre
				+" idkey_iddvd="+s.idkey_iddvd
			;
		}
		public string getStr(){ return getStr("");}
}
}
