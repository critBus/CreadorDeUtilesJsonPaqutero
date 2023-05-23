

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
	
public class BDManager_SQlite:I_BD_AdminPosgres{
		public string urlBD;
		public BDManager_SQlite():
				this(null)
		{
		}
		public BDManager_SQlite(string url){
		if (url==null){
			this.urlBD="BDManager.sqlite";
		}else{
			this.urlBD=url;
		}
			
		this.BD =BDConexion.getConexionSQL_LITE(this.urlBD);
				this.BD.sq().idKeyDefault="Id";
				this.__Upd =new BDUpdates(this.BD);
				this.usarUpdater=false;
		}
		public override  I_BD_AdminPosgres no_cl(){
			this.BD.no_cl();
			return this;
		}
		public override I_BD_AdminPosgres crearTablaPeliculas_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Peliculas_PG.TABLA_PELICULAS
							,Peliculas_PG.COLUMNA_NOMBREING,500,TipoDeClasificacionSQL.NOT_NULL
							,Peliculas_PG.COLUMNA_NOMBRE,500
							,Peliculas_PG.COLUMNA_SUBGENERO,500
							,Peliculas_PG.COLUMNA_DURACION,500
							,Peliculas_PG.COLUMNA_ANNO,TipoDeDatoSQL.INTEGER
							,Peliculas_PG.COLUMNA_ORIGEN,500
							,Peliculas_PG.COLUMNA_SINOPSIS,TipoDeDatoSQL.TEXT
							,Peliculas_PG.COLUMNA_SAGA,500
							,Peliculas_PG.COLUMNA_FOTOPELICULA,2500
							,Peliculas_PG.COLUMNA_DEFINICION,500
							,Peliculas_PG.COLUMNA_IDIOMA,500
							,Peliculas_PG.COLUMNA_FORMATO,500
							,Peliculas_PG.COLUMNA_GENERO,500
							,Peliculas_PG.COLUMNA_FILM_AFFINITY,TipoDeDatoSQL.BOOLEAN
							,Peliculas_PG.COLUMNA_IMDB,TipoDeDatoSQL.BOOLEAN
							,Peliculas_PG.COLUMNA_REVIEWED,TipoDeDatoSQL.BOOLEAN,TipoDeClasificacionSQL.NOT_NULL
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaPeliculas_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Peliculas_PG.TABLA_PELICULAS
							,Peliculas_PG.COLUMNA_NOMBREING,500,TipoDeClasificacionSQL.NOT_NULL
							,Peliculas_PG.COLUMNA_NOMBRE,500
							,Peliculas_PG.COLUMNA_SUBGENERO,500
							,Peliculas_PG.COLUMNA_DURACION,500
							,Peliculas_PG.COLUMNA_ANNO,TipoDeDatoSQL.INTEGER
							,Peliculas_PG.COLUMNA_ORIGEN,500
							,Peliculas_PG.COLUMNA_SINOPSIS,TipoDeDatoSQL.TEXT
							,Peliculas_PG.COLUMNA_SAGA,500
							,Peliculas_PG.COLUMNA_FOTOPELICULA,2500
							,Peliculas_PG.COLUMNA_DEFINICION,500
							,Peliculas_PG.COLUMNA_IDIOMA,500
							,Peliculas_PG.COLUMNA_FORMATO,500
							,Peliculas_PG.COLUMNA_GENERO,500
							,Peliculas_PG.COLUMNA_FILM_AFFINITY,TipoDeDatoSQL.BOOLEAN
							,Peliculas_PG.COLUMNA_IMDB,TipoDeDatoSQL.BOOLEAN
							,Peliculas_PG.COLUMNA_REVIEWED,TipoDeDatoSQL.BOOLEAN,TipoDeClasificacionSQL.NOT_NULL
							);
			return this;
		}
		public override Peliculas_PG getPeliculas_PG_Args(Object[] listaDeArgumentos){
			return new Peliculas_PG(to_String(listaDeArgumentos[1])
					,to_String(listaDeArgumentos[2])
					,to_String(listaDeArgumentos[3])
					,to_String(listaDeArgumentos[4])
					,toInt(listaDeArgumentos[5])
					,to_String(listaDeArgumentos[6])
					,to_String(listaDeArgumentos[7])
					,to_String(listaDeArgumentos[8])
					,to_String(listaDeArgumentos[9])
					,to_String(listaDeArgumentos[10])
					,to_String(listaDeArgumentos[11])
					,to_String(listaDeArgumentos[12])
					,to_String(listaDeArgumentos[13])
					,toBool(listaDeArgumentos[14])
					,toBool(listaDeArgumentos[15])
					,toBool(listaDeArgumentos[16])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Peliculas_PG(Peliculas_PG peliculas){
			Object[] lista = {new Object[]{Peliculas_PG.COLUMNA_NOMBREING,peliculas.nombreing}
				,new Object[]{Peliculas_PG.COLUMNA_NOMBRE,peliculas.nombre}
				,new Object[]{Peliculas_PG.COLUMNA_SUBGENERO,peliculas.subgenero}
				,new Object[]{Peliculas_PG.COLUMNA_DURACION,peliculas.duracion}
				,new Object[]{Peliculas_PG.COLUMNA_ANNO,peliculas.anno}
				,new Object[]{Peliculas_PG.COLUMNA_ORIGEN,peliculas.origen}
				,new Object[]{Peliculas_PG.COLUMNA_SINOPSIS,peliculas.sinopsis}
				,new Object[]{Peliculas_PG.COLUMNA_SAGA,peliculas.saga}
				,new Object[]{Peliculas_PG.COLUMNA_FOTOPELICULA,peliculas.fotopelicula}
				,new Object[]{Peliculas_PG.COLUMNA_DEFINICION,peliculas.definicion}
				,new Object[]{Peliculas_PG.COLUMNA_IDIOMA,peliculas.idioma}
				,new Object[]{Peliculas_PG.COLUMNA_FORMATO,peliculas.formato}
				,new Object[]{Peliculas_PG.COLUMNA_GENERO,peliculas.genero}
				,new Object[]{Peliculas_PG.COLUMNA_FILM_AFFINITY,peliculas.film_affinity}
				,new Object[]{Peliculas_PG.COLUMNA_IMDB,peliculas.imdb}
				,new Object[]{Peliculas_PG.COLUMNA_REVIEWED,peliculas.reviewed}
				};
			return lista;
			}
		public override Peliculas_PG getPeliculas_PG_id(int? id){
			Object[] O = this.BD.select_forID(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getPeliculas_PG_Args(O);
			}
		public override Peliculas_PG insertarPeliculas_PG(Peliculas_PG peliculas){
			if (peliculas.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_ID,
							new string[]{Peliculas_PG.COLUMNA_NOMBREING,Peliculas_PG.COLUMNA_NOMBRE,Peliculas_PG.COLUMNA_SUBGENERO,Peliculas_PG.COLUMNA_DURACION,Peliculas_PG.COLUMNA_ANNO,Peliculas_PG.COLUMNA_ORIGEN,Peliculas_PG.COLUMNA_SINOPSIS,Peliculas_PG.COLUMNA_SAGA,Peliculas_PG.COLUMNA_FOTOPELICULA,Peliculas_PG.COLUMNA_DEFINICION,Peliculas_PG.COLUMNA_IDIOMA,Peliculas_PG.COLUMNA_FORMATO,Peliculas_PG.COLUMNA_GENERO,Peliculas_PG.COLUMNA_FILM_AFFINITY,Peliculas_PG.COLUMNA_IMDB,Peliculas_PG.COLUMNA_REVIEWED}
						,peliculas.nombreing
						,peliculas.nombre
						,peliculas.subgenero
						,peliculas.duracion
						,peliculas.anno
						,peliculas.origen
						,peliculas.sinopsis
						,peliculas.saga
						,peliculas.fotopelicula
						,peliculas.definicion
						,peliculas.idioma
						,peliculas.formato
						,peliculas.genero
						,peliculas.film_affinity
						,peliculas.imdb
						,peliculas.reviewed
							).id;
					return this.getPeliculas_PG_id(id);
				} catch (Exception ex) {
					peliculas.idkey=this.BD.getIdCorrespondiente(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Peliculas_PG.TABLA_PELICULAS,peliculas.idkey
						,peliculas.nombreing
						,peliculas.nombre
						,peliculas.subgenero
						,peliculas.duracion
						,peliculas.anno
						,peliculas.origen
						,peliculas.sinopsis
						,peliculas.saga
						,peliculas.fotopelicula
						,peliculas.definicion
						,peliculas.idioma
						,peliculas.formato
						,peliculas.genero
						,peliculas.film_affinity
						,peliculas.imdb
						,peliculas.reviewed
							);
					return this.getPeliculas_PG_id(peliculas.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Peliculas_PG.TABLA_PELICULAS,peliculas.idkey
						,peliculas.nombreing
						,peliculas.nombre
						,peliculas.subgenero
						,peliculas.duracion
						,peliculas.anno
						,peliculas.origen
						,peliculas.sinopsis
						,peliculas.saga
						,peliculas.fotopelicula
						,peliculas.definicion
						,peliculas.idioma
						,peliculas.formato
						,peliculas.genero
						,peliculas.film_affinity
						,peliculas.imdb
						,peliculas.reviewed
						);
				return this.getPeliculas_PG_id(peliculas.idkey);
			}
		}
		public override  List<Peliculas_PG> getPeliculas_PG_All(){
				List<Peliculas_PG> lista=new List<Peliculas_PG>();
				Object [][]O=this.BD.select_Todo(Peliculas_PG.TABLA_PELICULAS);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getPeliculas_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Peliculas_PG updatePeliculas_PG(Peliculas_PG peliculas){
				this.BD.update_Id(Peliculas_PG.TABLA_PELICULAS,peliculas.idkey
							 , Peliculas_PG.COLUMNA_NOMBREING , peliculas.nombreing
							 , Peliculas_PG.COLUMNA_NOMBRE , peliculas.nombre
							 , Peliculas_PG.COLUMNA_SUBGENERO , peliculas.subgenero
							 , Peliculas_PG.COLUMNA_DURACION , peliculas.duracion
							 , Peliculas_PG.COLUMNA_ANNO , peliculas.anno
							 , Peliculas_PG.COLUMNA_ORIGEN , peliculas.origen
							 , Peliculas_PG.COLUMNA_SINOPSIS , peliculas.sinopsis
							 , Peliculas_PG.COLUMNA_SAGA , peliculas.saga
							 , Peliculas_PG.COLUMNA_FOTOPELICULA , peliculas.fotopelicula
							 , Peliculas_PG.COLUMNA_DEFINICION , peliculas.definicion
							 , Peliculas_PG.COLUMNA_IDIOMA , peliculas.idioma
							 , Peliculas_PG.COLUMNA_FORMATO , peliculas.formato
							 , Peliculas_PG.COLUMNA_GENERO , peliculas.genero
							 , Peliculas_PG.COLUMNA_FILM_AFFINITY , peliculas.film_affinity
							 , Peliculas_PG.COLUMNA_IMDB , peliculas.imdb
							 , Peliculas_PG.COLUMNA_REVIEWED , peliculas.reviewed);
				return getPeliculas_PG_id(peliculas.idkey);
		}
		public override  void deletePeliculas_PG_ForId(int? id){
				this.BD.delete_id(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_ID,id);
		}
		public override  void deletePeliculas_PG_ForId(Peliculas_PG peliculas){
				deletePeliculas_PG_ForId(peliculas.idkey);
		}
		public override  bool existePeliculas_PG_id(int? id){
			Object[] O = this.BD.select_forID(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existePeliculas_PG_Nombreing(string nombreing){
				return this.BD.existe(Peliculas_PG.TABLA_PELICULAS
						,Peliculas_PG.COLUMNA_NOMBREING,nombreing);
		}
		public override  bool existePeliculas_PG_Nombre(string nombre){
				return this.BD.existe(Peliculas_PG.TABLA_PELICULAS
						,Peliculas_PG.COLUMNA_NOMBRE,nombre);
		}
		public override  bool existePeliculas_PG_Nombre_Nombreing(string nombre,string nombreing){
				return this.BD.existe(Peliculas_PG.TABLA_PELICULAS
						,Peliculas_PG.COLUMNA_NOMBRE,nombre
						,Peliculas_PG.COLUMNA_NOMBREING,nombreing);
		}
		public override  void deletePeliculas_PG_ForId_CASCADE(int? idkey_peliculas){
			deletePeliculas_PG_ForId_CASCADE(idkey_peliculas,null);
		}
		public override  void deletePeliculas_PG_ForId_CASCADE(int? idkey_peliculas,Object modeloQueLoLlamo){
			Peliculas_PG peliculas=getPeliculas_PG_id(idkey_peliculas);
			deletePeliculas_actor_PG_For_Idkey_movie_id(idkey_peliculas);
			deletePeliculas_PG_ForId(idkey_peliculas);
		}
		public override I_BD_AdminPosgres crearTablaSeries_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Series_PG.TABLA_SERIES
							,Series_PG.COLUMNA_TIPO
							,Series_PG.COLUMNA_TITULO,1000
							,Series_PG.COLUMNA_TITULOING,1000,TipoDeClasificacionSQL.NOT_NULL
							,Series_PG.COLUMNA_ORIGEN
							,Series_PG.COLUMNA_SINOPSIS,TipoDeDatoSQL.TEXT
							,Series_PG.COLUMNA_FOTOSERIE,2500
							,Series_PG.COLUMNA_INICIAL,500
							,Series_PG.COLUMNA_ENCURSO,TipoDeDatoSQL.BOOLEAN
							,Series_PG.COLUMNA_GENERO,TipoDeClasificacionSQL.NOT_NULL
							,Series_PG.COLUMNA_FILM_AFFINITY,TipoDeDatoSQL.BOOLEAN
							,Series_PG.COLUMNA_IMDB,TipoDeDatoSQL.BOOLEAN
							,Series_PG.COLUMNA_REVIEWED,TipoDeDatoSQL.BOOLEAN,TipoDeClasificacionSQL.NOT_NULL
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaSeries_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Series_PG.TABLA_SERIES
							,Series_PG.COLUMNA_TIPO
							,Series_PG.COLUMNA_TITULO,1000
							,Series_PG.COLUMNA_TITULOING,1000,TipoDeClasificacionSQL.NOT_NULL
							,Series_PG.COLUMNA_ORIGEN
							,Series_PG.COLUMNA_SINOPSIS,TipoDeDatoSQL.TEXT
							,Series_PG.COLUMNA_FOTOSERIE,2500
							,Series_PG.COLUMNA_INICIAL,500
							,Series_PG.COLUMNA_ENCURSO,TipoDeDatoSQL.BOOLEAN
							,Series_PG.COLUMNA_GENERO,TipoDeClasificacionSQL.NOT_NULL
							,Series_PG.COLUMNA_FILM_AFFINITY,TipoDeDatoSQL.BOOLEAN
							,Series_PG.COLUMNA_IMDB,TipoDeDatoSQL.BOOLEAN
							,Series_PG.COLUMNA_REVIEWED,TipoDeDatoSQL.BOOLEAN,TipoDeClasificacionSQL.NOT_NULL
							);
			return this;
		}
		public override Series_PG getSeries_PG_Args(Object[] listaDeArgumentos){
			return new Series_PG(to_String(listaDeArgumentos[1])
					,to_String(listaDeArgumentos[2])
					,to_String(listaDeArgumentos[3])
					,to_String(listaDeArgumentos[4])
					,to_String(listaDeArgumentos[5])
					,to_String(listaDeArgumentos[6])
					,to_String(listaDeArgumentos[7])
					,toBool(listaDeArgumentos[8])
					,to_String(listaDeArgumentos[9])
					,toBool(listaDeArgumentos[10])
					,toBool(listaDeArgumentos[11])
					,toBool(listaDeArgumentos[12])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Series_PG(Series_PG series){
			Object[] lista = {new Object[]{Series_PG.COLUMNA_TIPO,series.tipo}
				,new Object[]{Series_PG.COLUMNA_TITULO,series.titulo}
				,new Object[]{Series_PG.COLUMNA_TITULOING,series.tituloing}
				,new Object[]{Series_PG.COLUMNA_ORIGEN,series.origen}
				,new Object[]{Series_PG.COLUMNA_SINOPSIS,series.sinopsis}
				,new Object[]{Series_PG.COLUMNA_FOTOSERIE,series.fotoserie}
				,new Object[]{Series_PG.COLUMNA_INICIAL,series.inicial}
				,new Object[]{Series_PG.COLUMNA_ENCURSO,series.encurso}
				,new Object[]{Series_PG.COLUMNA_GENERO,series.genero}
				,new Object[]{Series_PG.COLUMNA_FILM_AFFINITY,series.film_affinity}
				,new Object[]{Series_PG.COLUMNA_IMDB,series.imdb}
				,new Object[]{Series_PG.COLUMNA_REVIEWED,series.reviewed}
				};
			return lista;
			}
		public override Series_PG getSeries_PG_id(int? id){
			Object[] O = this.BD.select_forID(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getSeries_PG_Args(O);
			}
		public override Series_PG insertarSeries_PG(Series_PG series){
			if (series.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_ID,
							new string[]{Series_PG.COLUMNA_TIPO,Series_PG.COLUMNA_TITULO,Series_PG.COLUMNA_TITULOING,Series_PG.COLUMNA_ORIGEN,Series_PG.COLUMNA_SINOPSIS,Series_PG.COLUMNA_FOTOSERIE,Series_PG.COLUMNA_INICIAL,Series_PG.COLUMNA_ENCURSO,Series_PG.COLUMNA_GENERO,Series_PG.COLUMNA_FILM_AFFINITY,Series_PG.COLUMNA_IMDB,Series_PG.COLUMNA_REVIEWED}
						,series.tipo
						,series.titulo
						,series.tituloing
						,series.origen
						,series.sinopsis
						,series.fotoserie
						,series.inicial
						,series.encurso
						,series.genero
						,series.film_affinity
						,series.imdb
						,series.reviewed
							).id;
					return this.getSeries_PG_id(id);
				} catch (Exception ex) {
					series.idkey=this.BD.getIdCorrespondiente(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Series_PG.TABLA_SERIES,series.idkey
						,series.tipo
						,series.titulo
						,series.tituloing
						,series.origen
						,series.sinopsis
						,series.fotoserie
						,series.inicial
						,series.encurso
						,series.genero
						,series.film_affinity
						,series.imdb
						,series.reviewed
							);
					return this.getSeries_PG_id(series.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Series_PG.TABLA_SERIES,series.idkey
						,series.tipo
						,series.titulo
						,series.tituloing
						,series.origen
						,series.sinopsis
						,series.fotoserie
						,series.inicial
						,series.encurso
						,series.genero
						,series.film_affinity
						,series.imdb
						,series.reviewed
						);
				return this.getSeries_PG_id(series.idkey);
			}
		}
		public override  List<Series_PG> getSeries_PG_All(){
				List<Series_PG> lista=new List<Series_PG>();
				Object [][]O=this.BD.select_Todo(Series_PG.TABLA_SERIES);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeries_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Series_PG updateSeries_PG(Series_PG series){
				this.BD.update_Id(Series_PG.TABLA_SERIES,series.idkey
							 , Series_PG.COLUMNA_TIPO , series.tipo
							 , Series_PG.COLUMNA_TITULO , series.titulo
							 , Series_PG.COLUMNA_TITULOING , series.tituloing
							 , Series_PG.COLUMNA_ORIGEN , series.origen
							 , Series_PG.COLUMNA_SINOPSIS , series.sinopsis
							 , Series_PG.COLUMNA_FOTOSERIE , series.fotoserie
							 , Series_PG.COLUMNA_INICIAL , series.inicial
							 , Series_PG.COLUMNA_ENCURSO , series.encurso
							 , Series_PG.COLUMNA_GENERO , series.genero
							 , Series_PG.COLUMNA_FILM_AFFINITY , series.film_affinity
							 , Series_PG.COLUMNA_IMDB , series.imdb
							 , Series_PG.COLUMNA_REVIEWED , series.reviewed);
				return getSeries_PG_id(series.idkey);
		}
		public override  void deleteSeries_PG_ForId(int? id){
				this.BD.delete_id(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_ID,id);
		}
		public override  void deleteSeries_PG_ForId(Series_PG series){
				deleteSeries_PG_ForId(series.idkey);
		}
		public override  bool existeSeries_PG_id(int? id){
			Object[] O = this.BD.select_forID(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeSeries_PG_Titulo(string titulo){
				return this.BD.existe(Series_PG.TABLA_SERIES
						,Series_PG.COLUMNA_TITULO,titulo);
		}
		public override  bool existeSeries_PG_Tituloing(string tituloing){
				return this.BD.existe(Series_PG.TABLA_SERIES
						,Series_PG.COLUMNA_TITULOING,tituloing);
		}
		public override  bool existeSeries_PG_Titulo_Tituloing(string titulo,string tituloing){
				return this.BD.existe(Series_PG.TABLA_SERIES
						,Series_PG.COLUMNA_TITULO,titulo
						,Series_PG.COLUMNA_TITULOING,tituloing);
		}
		public override  void deleteSeries_PG_ForId_CASCADE(int? idkey_series){
			deleteSeries_PG_ForId_CASCADE(idkey_series,null);
		}
		public override  void deleteSeries_PG_ForId_CASCADE(int? idkey_series,Object modeloQueLoLlamo){
			Series_PG series=getSeries_PG_id(idkey_series);
			deleteSeriestemporadas_PG_For_Idkey_idserie(idkey_series);
			deleteSeries_actor_PG_For_Idkey_serial_id(idkey_series);
			deleteSeries_PG_ForId(idkey_series);
		}
		public override I_BD_AdminPosgres crearTablaActors_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Actors_PG.TABLA_ACTORS
							,Actors_PG.COLUMNA_NOMBRE,500
							,Actors_PG.COLUMNA_FOTOACTOR,2500
							,Actors_PG.COLUMNA_MOSTRAR,TipoDeDatoSQL.BOOLEAN
							,Actors_PG.COLUMNA_IMDB,TipoDeDatoSQL.BOOLEAN
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaActors_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Actors_PG.TABLA_ACTORS
							,Actors_PG.COLUMNA_NOMBRE,500
							,Actors_PG.COLUMNA_FOTOACTOR,2500
							,Actors_PG.COLUMNA_MOSTRAR,TipoDeDatoSQL.BOOLEAN
							,Actors_PG.COLUMNA_IMDB,TipoDeDatoSQL.BOOLEAN
							);
			return this;
		}
		public override Actors_PG getActors_PG_Args(Object[] listaDeArgumentos){
			return new Actors_PG(to_String(listaDeArgumentos[1])
					,to_String(listaDeArgumentos[2])
					,toBool(listaDeArgumentos[3])
					,toBool(listaDeArgumentos[4])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Actors_PG(Actors_PG actors){
			Object[] lista = {new Object[]{Actors_PG.COLUMNA_NOMBRE,actors.nombre}
				,new Object[]{Actors_PG.COLUMNA_FOTOACTOR,actors.fotoactor}
				,new Object[]{Actors_PG.COLUMNA_MOSTRAR,actors.mostrar}
				,new Object[]{Actors_PG.COLUMNA_IMDB,actors.imdb}
				};
			return lista;
			}
		public override Actors_PG getActors_PG_id(int? id){
			Object[] O = this.BD.select_forID(Actors_PG.TABLA_ACTORS,Actors_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getActors_PG_Args(O);
			}
		public override Actors_PG insertarActors_PG(Actors_PG actors){
			if (actors.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Actors_PG.TABLA_ACTORS,Actors_PG.COLUMNA_ID,
							new string[]{Actors_PG.COLUMNA_NOMBRE,Actors_PG.COLUMNA_FOTOACTOR,Actors_PG.COLUMNA_MOSTRAR,Actors_PG.COLUMNA_IMDB}
						,actors.nombre
						,actors.fotoactor
						,actors.mostrar
						,actors.imdb
							).id;
					return this.getActors_PG_id(id);
				} catch (Exception ex) {
					actors.idkey=this.BD.getIdCorrespondiente(Actors_PG.TABLA_ACTORS,Actors_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Actors_PG.TABLA_ACTORS,actors.idkey
						,actors.nombre
						,actors.fotoactor
						,actors.mostrar
						,actors.imdb
							);
					return this.getActors_PG_id(actors.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Actors_PG.TABLA_ACTORS,actors.idkey
						,actors.nombre
						,actors.fotoactor
						,actors.mostrar
						,actors.imdb
						);
				return this.getActors_PG_id(actors.idkey);
			}
		}
		public override  List<Actors_PG> getActors_PG_All(){
				List<Actors_PG> lista=new List<Actors_PG>();
				Object [][]O=this.BD.select_Todo(Actors_PG.TABLA_ACTORS);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getActors_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Actors_PG updateActors_PG(Actors_PG actors){
				this.BD.update_Id(Actors_PG.TABLA_ACTORS,actors.idkey
							 , Actors_PG.COLUMNA_NOMBRE , actors.nombre
							 , Actors_PG.COLUMNA_FOTOACTOR , actors.fotoactor
							 , Actors_PG.COLUMNA_MOSTRAR , actors.mostrar
							 , Actors_PG.COLUMNA_IMDB , actors.imdb);
				return getActors_PG_id(actors.idkey);
		}
		public override  void deleteActors_PG_ForId(int? id){
				this.BD.delete_id(Actors_PG.TABLA_ACTORS,Actors_PG.COLUMNA_ID,id);
		}
		public override  void deleteActors_PG_ForId(Actors_PG actors){
				deleteActors_PG_ForId(actors.idkey);
		}
		public override  bool existeActors_PG_id(int? id){
			Object[] O = this.BD.select_forID(Actors_PG.TABLA_ACTORS,Actors_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeActors_PG_Nombre(string nombre){
				return this.BD.existe(Actors_PG.TABLA_ACTORS
						,Actors_PG.COLUMNA_NOMBRE,nombre);
		}
		public override  void deleteActors_PG_ForId_CASCADE(int? idkey_actors){
			deleteActors_PG_ForId_CASCADE(idkey_actors,null);
		}
		public override  void deleteActors_PG_ForId_CASCADE(int? idkey_actors,Object modeloQueLoLlamo){
			Actors_PG actors=getActors_PG_id(idkey_actors);
			deleteSeries_actor_PG_For_Idkey_actor_id(idkey_actors);
			deletePeliculas_actor_PG_For_Idkey_actor_id(idkey_actors);
			deleteActors_PG_ForId(idkey_actors);
		}
		public override I_BD_AdminPosgres crearTablaSagas_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Sagas_PG.TABLA_SAGAS
							,Sagas_PG.COLUMNA_SAGA,500
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaSagas_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Sagas_PG.TABLA_SAGAS
							,Sagas_PG.COLUMNA_SAGA,500
							);
			return this;
		}
		public override Sagas_PG getSagas_PG_Args(Object[] listaDeArgumentos){
			return new Sagas_PG(to_String(listaDeArgumentos[1])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Sagas_PG(Sagas_PG sagas){
			Object[] lista = {new Object[]{Sagas_PG.COLUMNA_SAGA,sagas.saga}
				};
			return lista;
			}
		public override Sagas_PG getSagas_PG_id(int? id){
			Object[] O = this.BD.select_forID(Sagas_PG.TABLA_SAGAS,Sagas_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getSagas_PG_Args(O);
			}
		public override Sagas_PG insertarSagas_PG(Sagas_PG sagas){
			if (sagas.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Sagas_PG.TABLA_SAGAS,Sagas_PG.COLUMNA_ID,
							new string[]{Sagas_PG.COLUMNA_SAGA}
						,sagas.saga
							).id;
					return this.getSagas_PG_id(id);
				} catch (Exception ex) {
					sagas.idkey=this.BD.getIdCorrespondiente(Sagas_PG.TABLA_SAGAS,Sagas_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Sagas_PG.TABLA_SAGAS,sagas.idkey
						,sagas.saga
							);
					return this.getSagas_PG_id(sagas.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Sagas_PG.TABLA_SAGAS,sagas.idkey
						,sagas.saga
						);
				return this.getSagas_PG_id(sagas.idkey);
			}
		}
		public override  List<Sagas_PG> getSagas_PG_All(){
				List<Sagas_PG> lista=new List<Sagas_PG>();
				Object [][]O=this.BD.select_Todo(Sagas_PG.TABLA_SAGAS);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSagas_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Sagas_PG updateSagas_PG(Sagas_PG sagas){
				this.BD.update_Id(Sagas_PG.TABLA_SAGAS,sagas.idkey
							 , Sagas_PG.COLUMNA_SAGA , sagas.saga);
				return getSagas_PG_id(sagas.idkey);
		}
		public override  void deleteSagas_PG_ForId(int? id){
				this.BD.delete_id(Sagas_PG.TABLA_SAGAS,Sagas_PG.COLUMNA_ID,id);
		}
		public override  void deleteSagas_PG_ForId(Sagas_PG sagas){
				deleteSagas_PG_ForId(sagas.idkey);
		}
		public override  bool existeSagas_PG_id(int? id){
			Object[] O = this.BD.select_forID(Sagas_PG.TABLA_SAGAS,Sagas_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeSagas_PG_Saga(string saga){
				return this.BD.existe(Sagas_PG.TABLA_SAGAS
						,Sagas_PG.COLUMNA_SAGA,saga);
		}
		public override I_BD_AdminPosgres crearTablaFormatos_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Formatos_PG.TABLA_FORMATOS
							,Formatos_PG.COLUMNA_FORMATO,500
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaFormatos_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Formatos_PG.TABLA_FORMATOS
							,Formatos_PG.COLUMNA_FORMATO,500
							);
			return this;
		}
		public override Formatos_PG getFormatos_PG_Args(Object[] listaDeArgumentos){
			return new Formatos_PG(to_String(listaDeArgumentos[1])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Formatos_PG(Formatos_PG formatos){
			Object[] lista = {new Object[]{Formatos_PG.COLUMNA_FORMATO,formatos.formato}
				};
			return lista;
			}
		public override Formatos_PG getFormatos_PG_id(int? id){
			Object[] O = this.BD.select_forID(Formatos_PG.TABLA_FORMATOS,Formatos_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getFormatos_PG_Args(O);
			}
		public override Formatos_PG insertarFormatos_PG(Formatos_PG formatos){
			if (formatos.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Formatos_PG.TABLA_FORMATOS,Formatos_PG.COLUMNA_ID,
							new string[]{Formatos_PG.COLUMNA_FORMATO}
						,formatos.formato
							).id;
					return this.getFormatos_PG_id(id);
				} catch (Exception ex) {
					formatos.idkey=this.BD.getIdCorrespondiente(Formatos_PG.TABLA_FORMATOS,Formatos_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Formatos_PG.TABLA_FORMATOS,formatos.idkey
						,formatos.formato
							);
					return this.getFormatos_PG_id(formatos.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Formatos_PG.TABLA_FORMATOS,formatos.idkey
						,formatos.formato
						);
				return this.getFormatos_PG_id(formatos.idkey);
			}
		}
		public override  List<Formatos_PG> getFormatos_PG_All(){
				List<Formatos_PG> lista=new List<Formatos_PG>();
				Object [][]O=this.BD.select_Todo(Formatos_PG.TABLA_FORMATOS);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getFormatos_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Formatos_PG updateFormatos_PG(Formatos_PG formatos){
				this.BD.update_Id(Formatos_PG.TABLA_FORMATOS,formatos.idkey
							 , Formatos_PG.COLUMNA_FORMATO , formatos.formato);
				return getFormatos_PG_id(formatos.idkey);
		}
		public override  void deleteFormatos_PG_ForId(int? id){
				this.BD.delete_id(Formatos_PG.TABLA_FORMATOS,Formatos_PG.COLUMNA_ID,id);
		}
		public override  void deleteFormatos_PG_ForId(Formatos_PG formatos){
				deleteFormatos_PG_ForId(formatos.idkey);
		}
		public override  bool existeFormatos_PG_id(int? id){
			Object[] O = this.BD.select_forID(Formatos_PG.TABLA_FORMATOS,Formatos_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeFormatos_PG_Formato(string formato){
				return this.BD.existe(Formatos_PG.TABLA_FORMATOS
						,Formatos_PG.COLUMNA_FORMATO,formato);
		}
		public override I_BD_AdminPosgres crearTablaGeneros_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Generos_PG.TABLA_GENEROS
							,Generos_PG.COLUMNA_GENERO,500
							,Generos_PG.COLUMNA_FOTOGENERO,2500
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaGeneros_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Generos_PG.TABLA_GENEROS
							,Generos_PG.COLUMNA_GENERO,500
							,Generos_PG.COLUMNA_FOTOGENERO,2500
							);
			return this;
		}
		public override Generos_PG getGeneros_PG_Args(Object[] listaDeArgumentos){
			return new Generos_PG(to_String(listaDeArgumentos[1])
					,to_String(listaDeArgumentos[2])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Generos_PG(Generos_PG generos){
			Object[] lista = {new Object[]{Generos_PG.COLUMNA_GENERO,generos.genero}
				,new Object[]{Generos_PG.COLUMNA_FOTOGENERO,generos.fotogenero}
				};
			return lista;
			}
		public override Generos_PG getGeneros_PG_id(int? id){
			Object[] O = this.BD.select_forID(Generos_PG.TABLA_GENEROS,Generos_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getGeneros_PG_Args(O);
			}
		public override Generos_PG insertarGeneros_PG(Generos_PG generos){
			if (generos.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Generos_PG.TABLA_GENEROS,Generos_PG.COLUMNA_ID,
							new string[]{Generos_PG.COLUMNA_GENERO,Generos_PG.COLUMNA_FOTOGENERO}
						,generos.genero
						,generos.fotogenero
							).id;
					return this.getGeneros_PG_id(id);
				} catch (Exception ex) {
					generos.idkey=this.BD.getIdCorrespondiente(Generos_PG.TABLA_GENEROS,Generos_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Generos_PG.TABLA_GENEROS,generos.idkey
						,generos.genero
						,generos.fotogenero
							);
					return this.getGeneros_PG_id(generos.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Generos_PG.TABLA_GENEROS,generos.idkey
						,generos.genero
						,generos.fotogenero
						);
				return this.getGeneros_PG_id(generos.idkey);
			}
		}
		public override  List<Generos_PG> getGeneros_PG_All(){
				List<Generos_PG> lista=new List<Generos_PG>();
				Object [][]O=this.BD.select_Todo(Generos_PG.TABLA_GENEROS);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getGeneros_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Generos_PG updateGeneros_PG(Generos_PG generos){
				this.BD.update_Id(Generos_PG.TABLA_GENEROS,generos.idkey
							 , Generos_PG.COLUMNA_GENERO , generos.genero
							 , Generos_PG.COLUMNA_FOTOGENERO , generos.fotogenero);
				return getGeneros_PG_id(generos.idkey);
		}
		public override  void deleteGeneros_PG_ForId(int? id){
				this.BD.delete_id(Generos_PG.TABLA_GENEROS,Generos_PG.COLUMNA_ID,id);
		}
		public override  void deleteGeneros_PG_ForId(Generos_PG generos){
				deleteGeneros_PG_ForId(generos.idkey);
		}
		public override  bool existeGeneros_PG_id(int? id){
			Object[] O = this.BD.select_forID(Generos_PG.TABLA_GENEROS,Generos_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeGeneros_PG_Genero(string genero){
				return this.BD.existe(Generos_PG.TABLA_GENEROS
						,Generos_PG.COLUMNA_GENERO,genero);
		}
		public override I_BD_AdminPosgres crearTablaSeriestemporadas_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS
							,Seriestemporadas_PG.COLUMNA_TEMPORADA,500
							,Seriestemporadas_PG.COLUMNA_CAPITULOS,500
							,Seriestemporadas_PG.COLUMNA_DEFINICION,500
							,Seriestemporadas_PG.COLUMNA_ANNO,500
							,Seriestemporadas_PG.COLUMNA_IDIOMA,500
							,Seriestemporadas_PG.COLUMNA_FORMATO,500
							,Seriestemporadas_PG.COLUMNA_IDSERIE,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaSeriestemporadas_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS
							,Seriestemporadas_PG.COLUMNA_TEMPORADA,500
							,Seriestemporadas_PG.COLUMNA_CAPITULOS,500
							,Seriestemporadas_PG.COLUMNA_DEFINICION,500
							,Seriestemporadas_PG.COLUMNA_ANNO,500
							,Seriestemporadas_PG.COLUMNA_IDIOMA,500
							,Seriestemporadas_PG.COLUMNA_FORMATO,500
							,Seriestemporadas_PG.COLUMNA_IDSERIE,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override Seriestemporadas_PG getSeriestemporadas_PG_Args(Object[] listaDeArgumentos){
			return new Seriestemporadas_PG(to_String(listaDeArgumentos[1])
					,to_String(listaDeArgumentos[2])
					,to_String(listaDeArgumentos[3])
					,to_String(listaDeArgumentos[4])
					,to_String(listaDeArgumentos[5])
					,to_String(listaDeArgumentos[6])
					,toInt(listaDeArgumentos[7])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Seriestemporadas_PG(Seriestemporadas_PG seriestemporadas){
			Object[] lista = {new Object[]{Seriestemporadas_PG.COLUMNA_TEMPORADA,seriestemporadas.temporada}
				,new Object[]{Seriestemporadas_PG.COLUMNA_CAPITULOS,seriestemporadas.capitulos}
				,new Object[]{Seriestemporadas_PG.COLUMNA_DEFINICION,seriestemporadas.definicion}
				,new Object[]{Seriestemporadas_PG.COLUMNA_ANNO,seriestemporadas.anno}
				,new Object[]{Seriestemporadas_PG.COLUMNA_IDIOMA,seriestemporadas.idioma}
				,new Object[]{Seriestemporadas_PG.COLUMNA_FORMATO,seriestemporadas.formato}
				,new Object[]{Seriestemporadas_PG.COLUMNA_IDSERIE,seriestemporadas.idkey_idserie}
				};
			return lista;
			}
		public override Seriestemporadas_PG getSeriestemporadas_PG_id(int? id){
			Object[] O = this.BD.select_forID(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,Seriestemporadas_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getSeriestemporadas_PG_Args(O);
			}
		public override Seriestemporadas_PG insertarSeriestemporadas_PG(Seriestemporadas_PG seriestemporadas){
			if (seriestemporadas.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,Seriestemporadas_PG.COLUMNA_ID,
							new string[]{Seriestemporadas_PG.COLUMNA_TEMPORADA,Seriestemporadas_PG.COLUMNA_CAPITULOS,Seriestemporadas_PG.COLUMNA_DEFINICION,Seriestemporadas_PG.COLUMNA_ANNO,Seriestemporadas_PG.COLUMNA_IDIOMA,Seriestemporadas_PG.COLUMNA_FORMATO,Seriestemporadas_PG.COLUMNA_IDSERIE}
						,seriestemporadas.temporada
						,seriestemporadas.capitulos
						,seriestemporadas.definicion
						,seriestemporadas.anno
						,seriestemporadas.idioma
						,seriestemporadas.formato
						,seriestemporadas.idkey_idserie
							).id;
					return this.getSeriestemporadas_PG_id(id);
				} catch (Exception ex) {
					seriestemporadas.idkey=this.BD.getIdCorrespondiente(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,Seriestemporadas_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,seriestemporadas.idkey
						,seriestemporadas.temporada
						,seriestemporadas.capitulos
						,seriestemporadas.definicion
						,seriestemporadas.anno
						,seriestemporadas.idioma
						,seriestemporadas.formato
						,seriestemporadas.idkey_idserie
							);
					return this.getSeriestemporadas_PG_id(seriestemporadas.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,seriestemporadas.idkey
						,seriestemporadas.temporada
						,seriestemporadas.capitulos
						,seriestemporadas.definicion
						,seriestemporadas.anno
						,seriestemporadas.idioma
						,seriestemporadas.formato
						,seriestemporadas.idkey_idserie
						);
				return this.getSeriestemporadas_PG_id(seriestemporadas.idkey);
			}
		}
		public override  List<Seriestemporadas_PG> getSeriestemporadas_PG_All(){
				List<Seriestemporadas_PG> lista=new List<Seriestemporadas_PG>();
				Object [][]O=this.BD.select_Todo(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeriestemporadas_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Seriestemporadas_PG updateSeriestemporadas_PG(Seriestemporadas_PG seriestemporadas){
				this.BD.update_Id(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,seriestemporadas.idkey
							 , Seriestemporadas_PG.COLUMNA_TEMPORADA , seriestemporadas.temporada
							 , Seriestemporadas_PG.COLUMNA_CAPITULOS , seriestemporadas.capitulos
							 , Seriestemporadas_PG.COLUMNA_DEFINICION , seriestemporadas.definicion
							 , Seriestemporadas_PG.COLUMNA_ANNO , seriestemporadas.anno
							 , Seriestemporadas_PG.COLUMNA_IDIOMA , seriestemporadas.idioma
							 , Seriestemporadas_PG.COLUMNA_FORMATO , seriestemporadas.formato
							 , Seriestemporadas_PG.COLUMNA_IDSERIE , seriestemporadas.idkey_idserie);
				return getSeriestemporadas_PG_id(seriestemporadas.idkey);
		}
		public override  void deleteSeriestemporadas_PG_ForId(int? id){
				this.BD.delete_id(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,Seriestemporadas_PG.COLUMNA_ID,id);
		}
		public override  void deleteSeriestemporadas_PG_ForId(Seriestemporadas_PG seriestemporadas){
				deleteSeriestemporadas_PG_ForId(seriestemporadas.idkey);
		}
		public override  bool existeSeriestemporadas_PG_id(int? id){
			Object[] O = this.BD.select_forID(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,Seriestemporadas_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override I_BD_AdminPosgres crearTablaAutors_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Autors_PG.TABLA_AUTORS
							,Autors_PG.COLUMNA_NOMBRE,500
							,Autors_PG.COLUMNA_FOTO,2500
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaAutors_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Autors_PG.TABLA_AUTORS
							,Autors_PG.COLUMNA_NOMBRE,500
							,Autors_PG.COLUMNA_FOTO,2500
							);
			return this;
		}
		public override Autors_PG getAutors_PG_Args(Object[] listaDeArgumentos){
			return new Autors_PG(to_String(listaDeArgumentos[1])
					,to_String(listaDeArgumentos[2])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Autors_PG(Autors_PG autors){
			Object[] lista = {new Object[]{Autors_PG.COLUMNA_NOMBRE,autors.nombre}
				,new Object[]{Autors_PG.COLUMNA_FOTO,autors.foto}
				};
			return lista;
			}
		public override Autors_PG getAutors_PG_id(int? id){
			Object[] O = this.BD.select_forID(Autors_PG.TABLA_AUTORS,Autors_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getAutors_PG_Args(O);
			}
		public override Autors_PG insertarAutors_PG(Autors_PG autors){
			if (autors.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Autors_PG.TABLA_AUTORS,Autors_PG.COLUMNA_ID,
							new string[]{Autors_PG.COLUMNA_NOMBRE,Autors_PG.COLUMNA_FOTO}
						,autors.nombre
						,autors.foto
							).id;
					return this.getAutors_PG_id(id);
				} catch (Exception ex) {
					autors.idkey=this.BD.getIdCorrespondiente(Autors_PG.TABLA_AUTORS,Autors_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Autors_PG.TABLA_AUTORS,autors.idkey
						,autors.nombre
						,autors.foto
							);
					return this.getAutors_PG_id(autors.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Autors_PG.TABLA_AUTORS,autors.idkey
						,autors.nombre
						,autors.foto
						);
				return this.getAutors_PG_id(autors.idkey);
			}
		}
		public override  List<Autors_PG> getAutors_PG_All(){
				List<Autors_PG> lista=new List<Autors_PG>();
				Object [][]O=this.BD.select_Todo(Autors_PG.TABLA_AUTORS);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getAutors_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Autors_PG updateAutors_PG(Autors_PG autors){
				this.BD.update_Id(Autors_PG.TABLA_AUTORS,autors.idkey
							 , Autors_PG.COLUMNA_NOMBRE , autors.nombre
							 , Autors_PG.COLUMNA_FOTO , autors.foto);
				return getAutors_PG_id(autors.idkey);
		}
		public override  void deleteAutors_PG_ForId(int? id){
				this.BD.delete_id(Autors_PG.TABLA_AUTORS,Autors_PG.COLUMNA_ID,id);
		}
		public override  void deleteAutors_PG_ForId(Autors_PG autors){
				deleteAutors_PG_ForId(autors.idkey);
		}
		public override  bool existeAutors_PG_id(int? id){
			Object[] O = this.BD.select_forID(Autors_PG.TABLA_AUTORS,Autors_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeAutors_PG_Nombre(string nombre){
				return this.BD.existe(Autors_PG.TABLA_AUTORS
						,Autors_PG.COLUMNA_NOMBRE,nombre);
		}
		public override  void deleteAutors_PG_ForId_CASCADE(int? idkey_autors){
			deleteAutors_PG_ForId_CASCADE(idkey_autors,null);
		}
		public override  void deleteAutors_PG_ForId_CASCADE(int? idkey_autors,Object modeloQueLoLlamo){
			Autors_PG autors=getAutors_PG_id(idkey_autors);
			if(modeloQueLoLlamo!=null&& modeloQueLoLlamo is Albums_PG){
				deleteAlbums_PG_For_Idkey_idautor(idkey_autors);
			}else{
				deleteAlbums_PG_For_Idkey_idautor_CASCADE(idkey_autors,autors);
			}
			deleteAutors_PG_ForId(idkey_autors);
		}
		public override I_BD_AdminPosgres crearTablaAlbums_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Albums_PG.TABLA_ALBUMS
							,Albums_PG.COLUMNA_TITULO,500
							,Albums_PG.COLUMNA_ANNO,TipoDeDatoSQL.INTEGER
							,Albums_PG.COLUMNA_FOTO,2500
							,Albums_PG.COLUMNA_IDAUTORNAVIGATIONID,TipoDeDatoSQL.INTEGER
							,Albums_PG.COLUMNA_FOTOBACK,2500
							,Albums_PG.COLUMNA_IDAUTOR,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaAlbums_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Albums_PG.TABLA_ALBUMS
							,Albums_PG.COLUMNA_TITULO,500
							,Albums_PG.COLUMNA_ANNO,TipoDeDatoSQL.INTEGER
							,Albums_PG.COLUMNA_FOTO,2500
							,Albums_PG.COLUMNA_IDAUTORNAVIGATIONID,TipoDeDatoSQL.INTEGER
							,Albums_PG.COLUMNA_FOTOBACK,2500
							,Albums_PG.COLUMNA_IDAUTOR,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override Albums_PG getAlbums_PG_Args(Object[] listaDeArgumentos){
			return new Albums_PG(to_String(listaDeArgumentos[1])
					,toInt(listaDeArgumentos[2])
					,to_String(listaDeArgumentos[3])
					,toInt(listaDeArgumentos[4])
					,to_String(listaDeArgumentos[5])
					,toInt(listaDeArgumentos[6])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Albums_PG(Albums_PG albums){
			Object[] lista = {new Object[]{Albums_PG.COLUMNA_TITULO,albums.titulo}
				,new Object[]{Albums_PG.COLUMNA_ANNO,albums.anno}
				,new Object[]{Albums_PG.COLUMNA_FOTO,albums.foto}
				,new Object[]{Albums_PG.COLUMNA_IDAUTORNAVIGATIONID,albums.idautornavigationid}
				,new Object[]{Albums_PG.COLUMNA_FOTOBACK,albums.fotoback}
				,new Object[]{Albums_PG.COLUMNA_IDAUTOR,albums.idkey_idautor}
				};
			return lista;
			}
		public override Albums_PG getAlbums_PG_id(int? id){
			Object[] O = this.BD.select_forID(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getAlbums_PG_Args(O);
			}
		public override Albums_PG insertarAlbums_PG(Albums_PG albums){
			if (albums.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_ID,
							new string[]{Albums_PG.COLUMNA_TITULO,Albums_PG.COLUMNA_ANNO,Albums_PG.COLUMNA_FOTO,Albums_PG.COLUMNA_IDAUTORNAVIGATIONID,Albums_PG.COLUMNA_FOTOBACK,Albums_PG.COLUMNA_IDAUTOR}
						,albums.titulo
						,albums.anno
						,albums.foto
						,albums.idautornavigationid
						,albums.fotoback
						,albums.idkey_idautor
							).id;
					return this.getAlbums_PG_id(id);
				} catch (Exception ex) {
					albums.idkey=this.BD.getIdCorrespondiente(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Albums_PG.TABLA_ALBUMS,albums.idkey
						,albums.titulo
						,albums.anno
						,albums.foto
						,albums.idautornavigationid
						,albums.fotoback
						,albums.idkey_idautor
							);
					return this.getAlbums_PG_id(albums.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Albums_PG.TABLA_ALBUMS,albums.idkey
						,albums.titulo
						,albums.anno
						,albums.foto
						,albums.idautornavigationid
						,albums.fotoback
						,albums.idkey_idautor
						);
				return this.getAlbums_PG_id(albums.idkey);
			}
		}
		public override  List<Albums_PG> getAlbums_PG_All(){
				List<Albums_PG> lista=new List<Albums_PG>();
				Object [][]O=this.BD.select_Todo(Albums_PG.TABLA_ALBUMS);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getAlbums_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Albums_PG updateAlbums_PG(Albums_PG albums){
				this.BD.update_Id(Albums_PG.TABLA_ALBUMS,albums.idkey
							 , Albums_PG.COLUMNA_TITULO , albums.titulo
							 , Albums_PG.COLUMNA_ANNO , albums.anno
							 , Albums_PG.COLUMNA_FOTO , albums.foto
							 , Albums_PG.COLUMNA_IDAUTORNAVIGATIONID , albums.idautornavigationid
							 , Albums_PG.COLUMNA_FOTOBACK , albums.fotoback
							 , Albums_PG.COLUMNA_IDAUTOR , albums.idkey_idautor);
				return getAlbums_PG_id(albums.idkey);
		}
		public override  void deleteAlbums_PG_ForId(int? id){
				this.BD.delete_id(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_ID,id);
		}
		public override  void deleteAlbums_PG_ForId(Albums_PG albums){
				deleteAlbums_PG_ForId(albums.idkey);
		}
		public override  bool existeAlbums_PG_id(int? id){
			Object[] O = this.BD.select_forID(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeAlbums_PG_Titulo(string titulo){
				return this.BD.existe(Albums_PG.TABLA_ALBUMS
						,Albums_PG.COLUMNA_TITULO,titulo);
		}
		public override  bool existeAlbums_PG_Titulo_Idkey_idautor(string titulo,int? idkey_idautor){
				return this.BD.existe(Albums_PG.TABLA_ALBUMS
						,Albums_PG.COLUMNA_TITULO,titulo
						,Albums_PG.COLUMNA_IDAUTOR,idkey_idautor);
		}
		public override  void deleteAlbums_PG_ForId_CASCADE(int? idkey_albums){
			deleteAlbums_PG_ForId_CASCADE(idkey_albums,null);
		}
		public override  void deleteAlbums_PG_ForId_CASCADE(int? idkey_albums,Object modeloQueLoLlamo){
			Albums_PG albums=getAlbums_PG_id(idkey_albums);
			deleteCancionalbums_PG_For_Idkey_idalbum(idkey_albums);
			deleteAlbums_PG_ForId(idkey_albums);
		}
		public override I_BD_AdminPosgres crearTablaCancionalbums_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Cancionalbums_PG.TABLA_CANCIONALBUMS
							,Cancionalbums_PG.COLUMNA_TITULO,500
							,Cancionalbums_PG.COLUMNA_IDALBUM,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaCancionalbums_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Cancionalbums_PG.TABLA_CANCIONALBUMS
							,Cancionalbums_PG.COLUMNA_TITULO,500
							,Cancionalbums_PG.COLUMNA_IDALBUM,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override Cancionalbums_PG getCancionalbums_PG_Args(Object[] listaDeArgumentos){
			return new Cancionalbums_PG(to_String(listaDeArgumentos[1])
					,toInt(listaDeArgumentos[2])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Cancionalbums_PG(Cancionalbums_PG cancionalbums){
			Object[] lista = {new Object[]{Cancionalbums_PG.COLUMNA_TITULO,cancionalbums.titulo}
				,new Object[]{Cancionalbums_PG.COLUMNA_IDALBUM,cancionalbums.idkey_idalbum}
				};
			return lista;
			}
		public override Cancionalbums_PG getCancionalbums_PG_id(int? id){
			Object[] O = this.BD.select_forID(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getCancionalbums_PG_Args(O);
			}
		public override Cancionalbums_PG insertarCancionalbums_PG(Cancionalbums_PG cancionalbums){
			if (cancionalbums.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_ID,
							new string[]{Cancionalbums_PG.COLUMNA_TITULO,Cancionalbums_PG.COLUMNA_IDALBUM}
						,cancionalbums.titulo
						,cancionalbums.idkey_idalbum
							).id;
					return this.getCancionalbums_PG_id(id);
				} catch (Exception ex) {
					cancionalbums.idkey=this.BD.getIdCorrespondiente(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Cancionalbums_PG.TABLA_CANCIONALBUMS,cancionalbums.idkey
						,cancionalbums.titulo
						,cancionalbums.idkey_idalbum
							);
					return this.getCancionalbums_PG_id(cancionalbums.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Cancionalbums_PG.TABLA_CANCIONALBUMS,cancionalbums.idkey
						,cancionalbums.titulo
						,cancionalbums.idkey_idalbum
						);
				return this.getCancionalbums_PG_id(cancionalbums.idkey);
			}
		}
		public override  List<Cancionalbums_PG> getCancionalbums_PG_All(){
				List<Cancionalbums_PG> lista=new List<Cancionalbums_PG>();
				Object [][]O=this.BD.select_Todo(Cancionalbums_PG.TABLA_CANCIONALBUMS);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getCancionalbums_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Cancionalbums_PG updateCancionalbums_PG(Cancionalbums_PG cancionalbums){
				this.BD.update_Id(Cancionalbums_PG.TABLA_CANCIONALBUMS,cancionalbums.idkey
							 , Cancionalbums_PG.COLUMNA_TITULO , cancionalbums.titulo
							 , Cancionalbums_PG.COLUMNA_IDALBUM , cancionalbums.idkey_idalbum);
				return getCancionalbums_PG_id(cancionalbums.idkey);
		}
		public override  void deleteCancionalbums_PG_ForId(int? id){
				this.BD.delete_id(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_ID,id);
		}
		public override  void deleteCancionalbums_PG_ForId(Cancionalbums_PG cancionalbums){
				deleteCancionalbums_PG_ForId(cancionalbums.idkey);
		}
		public override  bool existeCancionalbums_PG_id(int? id){
			Object[] O = this.BD.select_forID(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeCancionalbums_PG_Titulo(string titulo){
				return this.BD.existe(Cancionalbums_PG.TABLA_CANCIONALBUMS
						,Cancionalbums_PG.COLUMNA_TITULO,titulo);
		}
		public override  bool existeCancionalbums_PG_Titulo_Idkey_idalbum(string titulo,int? idkey_idalbum){
				return this.BD.existe(Cancionalbums_PG.TABLA_CANCIONALBUMS
						,Cancionalbums_PG.COLUMNA_TITULO,titulo
						,Cancionalbums_PG.COLUMNA_IDALBUM,idkey_idalbum);
		}
		public override I_BD_AdminPosgres crearTablaDvd_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Dvd_PG.TABLA_DVD
							,Dvd_PG.COLUMNA_TITULO,500
							,Dvd_PG.COLUMNA_AUTOR,500
							,Dvd_PG.COLUMNA_ANNO,TipoDeDatoSQL.INTEGER
							,Dvd_PG.COLUMNA_FOTO,2500
							,Dvd_PG.COLUMNA_FOTOBACK,2500
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaDvd_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Dvd_PG.TABLA_DVD
							,Dvd_PG.COLUMNA_TITULO,500
							,Dvd_PG.COLUMNA_AUTOR,500
							,Dvd_PG.COLUMNA_ANNO,TipoDeDatoSQL.INTEGER
							,Dvd_PG.COLUMNA_FOTO,2500
							,Dvd_PG.COLUMNA_FOTOBACK,2500
							);
			return this;
		}
		public override Dvd_PG getDvd_PG_Args(Object[] listaDeArgumentos){
			return new Dvd_PG(to_String(listaDeArgumentos[1])
					,to_String(listaDeArgumentos[2])
					,toInt(listaDeArgumentos[3])
					,to_String(listaDeArgumentos[4])
					,to_String(listaDeArgumentos[5])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Dvd_PG(Dvd_PG dvd){
			Object[] lista = {new Object[]{Dvd_PG.COLUMNA_TITULO,dvd.titulo}
				,new Object[]{Dvd_PG.COLUMNA_AUTOR,dvd.autor}
				,new Object[]{Dvd_PG.COLUMNA_ANNO,dvd.anno}
				,new Object[]{Dvd_PG.COLUMNA_FOTO,dvd.foto}
				,new Object[]{Dvd_PG.COLUMNA_FOTOBACK,dvd.fotoback}
				};
			return lista;
			}
		public override Dvd_PG getDvd_PG_id(int? id){
			Object[] O = this.BD.select_forID(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getDvd_PG_Args(O);
			}
		public override Dvd_PG insertarDvd_PG(Dvd_PG dvd){
			if (dvd.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_ID,
							new string[]{Dvd_PG.COLUMNA_TITULO,Dvd_PG.COLUMNA_AUTOR,Dvd_PG.COLUMNA_ANNO,Dvd_PG.COLUMNA_FOTO,Dvd_PG.COLUMNA_FOTOBACK}
						,dvd.titulo
						,dvd.autor
						,dvd.anno
						,dvd.foto
						,dvd.fotoback
							).id;
					return this.getDvd_PG_id(id);
				} catch (Exception ex) {
					dvd.idkey=this.BD.getIdCorrespondiente(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Dvd_PG.TABLA_DVD,dvd.idkey
						,dvd.titulo
						,dvd.autor
						,dvd.anno
						,dvd.foto
						,dvd.fotoback
							);
					return this.getDvd_PG_id(dvd.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Dvd_PG.TABLA_DVD,dvd.idkey
						,dvd.titulo
						,dvd.autor
						,dvd.anno
						,dvd.foto
						,dvd.fotoback
						);
				return this.getDvd_PG_id(dvd.idkey);
			}
		}
		public override  List<Dvd_PG> getDvd_PG_All(){
				List<Dvd_PG> lista=new List<Dvd_PG>();
				Object [][]O=this.BD.select_Todo(Dvd_PG.TABLA_DVD);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getDvd_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Dvd_PG updateDvd_PG(Dvd_PG dvd){
				this.BD.update_Id(Dvd_PG.TABLA_DVD,dvd.idkey
							 , Dvd_PG.COLUMNA_TITULO , dvd.titulo
							 , Dvd_PG.COLUMNA_AUTOR , dvd.autor
							 , Dvd_PG.COLUMNA_ANNO , dvd.anno
							 , Dvd_PG.COLUMNA_FOTO , dvd.foto
							 , Dvd_PG.COLUMNA_FOTOBACK , dvd.fotoback);
				return getDvd_PG_id(dvd.idkey);
		}
		public override  void deleteDvd_PG_ForId(int? id){
				this.BD.delete_id(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_ID,id);
		}
		public override  void deleteDvd_PG_ForId(Dvd_PG dvd){
				deleteDvd_PG_ForId(dvd.idkey);
		}
		public override  bool existeDvd_PG_id(int? id){
			Object[] O = this.BD.select_forID(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeDvd_PG_Titulo(string titulo){
				return this.BD.existe(Dvd_PG.TABLA_DVD
						,Dvd_PG.COLUMNA_TITULO,titulo);
		}
		public override  bool existeDvd_PG_Titulo_Autor(string titulo,string autor){
				return this.BD.existe(Dvd_PG.TABLA_DVD
						,Dvd_PG.COLUMNA_TITULO,titulo
						,Dvd_PG.COLUMNA_AUTOR,autor);
		}
		public override  void deleteDvd_PG_ForId_CASCADE(int? idkey_dvd){
			deleteDvd_PG_ForId_CASCADE(idkey_dvd,null);
		}
		public override  void deleteDvd_PG_ForId_CASCADE(int? idkey_dvd,Object modeloQueLoLlamo){
			Dvd_PG dvd=getDvd_PG_id(idkey_dvd);
			deleteCanciondvd_PG_For_Idkey_iddvd(idkey_dvd);
			deleteDvd_PG_ForId(idkey_dvd);
		}
		public override I_BD_AdminPosgres crearTablaCanciondvd_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Canciondvd_PG.TABLA_CANCIONDVD
							,Canciondvd_PG.COLUMNA_NOMBRE,500
							,Canciondvd_PG.COLUMNA_IDDVD,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaCanciondvd_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Canciondvd_PG.TABLA_CANCIONDVD
							,Canciondvd_PG.COLUMNA_NOMBRE,500
							,Canciondvd_PG.COLUMNA_IDDVD,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override Canciondvd_PG getCanciondvd_PG_Args(Object[] listaDeArgumentos){
			return new Canciondvd_PG(to_String(listaDeArgumentos[1])
					,toInt(listaDeArgumentos[2])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Canciondvd_PG(Canciondvd_PG canciondvd){
			Object[] lista = {new Object[]{Canciondvd_PG.COLUMNA_NOMBRE,canciondvd.nombre}
				,new Object[]{Canciondvd_PG.COLUMNA_IDDVD,canciondvd.idkey_iddvd}
				};
			return lista;
			}
		public override Canciondvd_PG getCanciondvd_PG_id(int? id){
			Object[] O = this.BD.select_forID(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getCanciondvd_PG_Args(O);
			}
		public override Canciondvd_PG insertarCanciondvd_PG(Canciondvd_PG canciondvd){
			if (canciondvd.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_ID,
							new string[]{Canciondvd_PG.COLUMNA_NOMBRE,Canciondvd_PG.COLUMNA_IDDVD}
						,canciondvd.nombre
						,canciondvd.idkey_iddvd
							).id;
					return this.getCanciondvd_PG_id(id);
				} catch (Exception ex) {
					canciondvd.idkey=this.BD.getIdCorrespondiente(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Canciondvd_PG.TABLA_CANCIONDVD,canciondvd.idkey
						,canciondvd.nombre
						,canciondvd.idkey_iddvd
							);
					return this.getCanciondvd_PG_id(canciondvd.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Canciondvd_PG.TABLA_CANCIONDVD,canciondvd.idkey
						,canciondvd.nombre
						,canciondvd.idkey_iddvd
						);
				return this.getCanciondvd_PG_id(canciondvd.idkey);
			}
		}
		public override  List<Canciondvd_PG> getCanciondvd_PG_All(){
				List<Canciondvd_PG> lista=new List<Canciondvd_PG>();
				Object [][]O=this.BD.select_Todo(Canciondvd_PG.TABLA_CANCIONDVD);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getCanciondvd_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Canciondvd_PG updateCanciondvd_PG(Canciondvd_PG canciondvd){
				this.BD.update_Id(Canciondvd_PG.TABLA_CANCIONDVD,canciondvd.idkey
							 , Canciondvd_PG.COLUMNA_NOMBRE , canciondvd.nombre
							 , Canciondvd_PG.COLUMNA_IDDVD , canciondvd.idkey_iddvd);
				return getCanciondvd_PG_id(canciondvd.idkey);
		}
		public override  void deleteCanciondvd_PG_ForId(int? id){
				this.BD.delete_id(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_ID,id);
		}
		public override  void deleteCanciondvd_PG_ForId(Canciondvd_PG canciondvd){
				deleteCanciondvd_PG_ForId(canciondvd.idkey);
		}
		public override  bool existeCanciondvd_PG_id(int? id){
			Object[] O = this.BD.select_forID(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  bool existeCanciondvd_PG_Nombre(string nombre){
				return this.BD.existe(Canciondvd_PG.TABLA_CANCIONDVD
						,Canciondvd_PG.COLUMNA_NOMBRE,nombre);
		}
		public override  bool existeCanciondvd_PG_Nombre_Idkey_iddvd(string nombre,int? idkey_iddvd){
				return this.BD.existe(Canciondvd_PG.TABLA_CANCIONDVD
						,Canciondvd_PG.COLUMNA_NOMBRE,nombre
						,Canciondvd_PG.COLUMNA_IDDVD,idkey_iddvd);
		}
		public override I_BD_AdminPosgres crearTablaSeries_actor_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Series_actor_PG.TABLA_SERIES_ACTOR
							,Series_actor_PG.COLUMNA_SERIAL_ID,TipoDeDatoSQL.INTEGER
							,Series_actor_PG.COLUMNA_ACTOR_ID,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaSeries_actor_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Series_actor_PG.TABLA_SERIES_ACTOR
							,Series_actor_PG.COLUMNA_SERIAL_ID,TipoDeDatoSQL.INTEGER
							,Series_actor_PG.COLUMNA_ACTOR_ID,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override Series_actor_PG getSeries_actor_PG_Args(Object[] listaDeArgumentos){
			return new Series_actor_PG(toInt(listaDeArgumentos[1])
					,toInt(listaDeArgumentos[2])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Series_actor_PG(Series_actor_PG series_actor){
			Object[] lista = {new Object[]{Series_actor_PG.COLUMNA_SERIAL_ID,series_actor.idkey_serial_id}
				,new Object[]{Series_actor_PG.COLUMNA_ACTOR_ID,series_actor.idkey_actor_id}
				};
			return lista;
			}
		public override Series_actor_PG getSeries_actor_PG_id(int? id){
			Object[] O = this.BD.select_forID(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getSeries_actor_PG_Args(O);
			}
		public override Series_actor_PG insertarSeries_actor_PG(Series_actor_PG series_actor){
			if (series_actor.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_ID,
							new string[]{Series_actor_PG.COLUMNA_SERIAL_ID,Series_actor_PG.COLUMNA_ACTOR_ID}
						,series_actor.idkey_serial_id
						,series_actor.idkey_actor_id
							).id;
					return this.getSeries_actor_PG_id(id);
				} catch (Exception ex) {
					series_actor.idkey=this.BD.getIdCorrespondiente(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Series_actor_PG.TABLA_SERIES_ACTOR,series_actor.idkey
						,series_actor.idkey_serial_id
						,series_actor.idkey_actor_id
							);
					return this.getSeries_actor_PG_id(series_actor.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Series_actor_PG.TABLA_SERIES_ACTOR,series_actor.idkey
						,series_actor.idkey_serial_id
						,series_actor.idkey_actor_id
						);
				return this.getSeries_actor_PG_id(series_actor.idkey);
			}
		}
		public override  List<Series_actor_PG> getSeries_actor_PG_All(){
				List<Series_actor_PG> lista=new List<Series_actor_PG>();
				Object [][]O=this.BD.select_Todo(Series_actor_PG.TABLA_SERIES_ACTOR);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeries_actor_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Series_actor_PG updateSeries_actor_PG(Series_actor_PG series_actor){
				this.BD.update_Id(Series_actor_PG.TABLA_SERIES_ACTOR,series_actor.idkey
							 , Series_actor_PG.COLUMNA_SERIAL_ID , series_actor.idkey_serial_id
							 , Series_actor_PG.COLUMNA_ACTOR_ID , series_actor.idkey_actor_id);
				return getSeries_actor_PG_id(series_actor.idkey);
		}
		public override  void deleteSeries_actor_PG_ForId(int? id){
				this.BD.delete_id(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_ID,id);
		}
		public override  void deleteSeries_actor_PG_ForId(Series_actor_PG series_actor){
				deleteSeries_actor_PG_ForId(series_actor.idkey);
		}
		public override  bool existeSeries_actor_PG_id(int? id){
			Object[] O = this.BD.select_forID(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override I_BD_AdminPosgres crearTablaPeliculas_actor_PG(){
			 this.BD.crearTablaYBorrarSiExiste(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR
							,Peliculas_actor_PG.COLUMNA_MOVIE_ID,TipoDeDatoSQL.INTEGER
							,Peliculas_actor_PG.COLUMNA_ACTOR_ID,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override I_BD_AdminPosgres crearTablaPeliculas_actor_PGSiNoExiste(){
			 this.BD.crearTablaSiNoExiste(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR
							,Peliculas_actor_PG.COLUMNA_MOVIE_ID,TipoDeDatoSQL.INTEGER
							,Peliculas_actor_PG.COLUMNA_ACTOR_ID,TipoDeDatoSQL.INTEGER
							);
			return this;
		}
		public override Peliculas_actor_PG getPeliculas_actor_PG_Args(Object[] listaDeArgumentos){
			return new Peliculas_actor_PG(toInt(listaDeArgumentos[1])
					,toInt(listaDeArgumentos[2])
					,toInt(listaDeArgumentos[0])
					,this
					);
			}
		public override  Object[] __content_Peliculas_actor_PG(Peliculas_actor_PG peliculas_actor){
			Object[] lista = {new Object[]{Peliculas_actor_PG.COLUMNA_MOVIE_ID,peliculas_actor.idkey_movie_id}
				,new Object[]{Peliculas_actor_PG.COLUMNA_ACTOR_ID,peliculas_actor.idkey_actor_id}
				};
			return lista;
			}
		public override Peliculas_actor_PG getPeliculas_actor_PG_id(int? id){
			Object[] O = this.BD.select_forID(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_ID, id);
			if (O == null){
				return null;}
			return this.getPeliculas_actor_PG_Args(O);
			}
		public override Peliculas_actor_PG insertarPeliculas_actor_PG(Peliculas_actor_PG peliculas_actor){
			if (peliculas_actor.idkey==-1){
				try{
					int id=this.BD.insertar_ConIdAutomatico(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_ID,
							new string[]{Peliculas_actor_PG.COLUMNA_MOVIE_ID,Peliculas_actor_PG.COLUMNA_ACTOR_ID}
						,peliculas_actor.idkey_movie_id
						,peliculas_actor.idkey_actor_id
							).id;
					return this.getPeliculas_actor_PG_id(id);
				} catch (Exception ex) {
					peliculas_actor.idkey=this.BD.getIdCorrespondiente(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_ID);
					this.BD.insertar_SinIdAutomatico(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,peliculas_actor.idkey
						,peliculas_actor.idkey_movie_id
						,peliculas_actor.idkey_actor_id
							);
					return this.getPeliculas_actor_PG_id(peliculas_actor.idkey);
				}
			}else{
				this.BD.insertar_SinIdAutomatico(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,peliculas_actor.idkey
						,peliculas_actor.idkey_movie_id
						,peliculas_actor.idkey_actor_id
						);
				return this.getPeliculas_actor_PG_id(peliculas_actor.idkey);
			}
		}
		public override  List<Peliculas_actor_PG> getPeliculas_actor_PG_All(){
				List<Peliculas_actor_PG> lista=new List<Peliculas_actor_PG>();
				Object [][]O=this.BD.select_Todo(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getPeliculas_actor_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Peliculas_actor_PG updatePeliculas_actor_PG(Peliculas_actor_PG peliculas_actor){
				this.BD.update_Id(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,peliculas_actor.idkey
							 , Peliculas_actor_PG.COLUMNA_MOVIE_ID , peliculas_actor.idkey_movie_id
							 , Peliculas_actor_PG.COLUMNA_ACTOR_ID , peliculas_actor.idkey_actor_id);
				return getPeliculas_actor_PG_id(peliculas_actor.idkey);
		}
		public override  void deletePeliculas_actor_PG_ForId(int? id){
				this.BD.delete_id(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_ID,id);
		}
		public override  void deletePeliculas_actor_PG_ForId(Peliculas_actor_PG peliculas_actor){
				deletePeliculas_actor_PG_ForId(peliculas_actor.idkey);
		}
		public override  bool existePeliculas_actor_PG_id(int? id){
			Object[] O = this.BD.select_forID(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_ID, id);
			return O != null;
			}
		public override  void crearTodasLasTablas(){
			crearTablaPeliculas_PG();
			crearTablaSeries_PG();
			crearTablaActors_PG();
			crearTablaSagas_PG();
			crearTablaFormatos_PG();
			crearTablaGeneros_PG();
			crearTablaSeriestemporadas_PG();
			crearTablaAutors_PG();
			crearTablaAlbums_PG();
			crearTablaCancionalbums_PG();
			crearTablaDvd_PG();
			crearTablaCanciondvd_PG();
			crearTablaSeries_actor_PG();
			crearTablaPeliculas_actor_PG();
		}
		public override  void crearTodasLasTablasSiNoExisten(){
			crearTablaPeliculas_PGSiNoExiste();
			crearTablaSeries_PGSiNoExiste();
			crearTablaActors_PGSiNoExiste();
			crearTablaSagas_PGSiNoExiste();
			crearTablaFormatos_PGSiNoExiste();
			crearTablaGeneros_PGSiNoExiste();
			crearTablaSeriestemporadas_PGSiNoExiste();
			crearTablaAutors_PGSiNoExiste();
			crearTablaAlbums_PGSiNoExiste();
			crearTablaCancionalbums_PGSiNoExiste();
			crearTablaDvd_PGSiNoExiste();
			crearTablaCanciondvd_PGSiNoExiste();
			crearTablaSeries_actor_PGSiNoExiste();
			crearTablaPeliculas_actor_PGSiNoExiste();
		}
		public override  List<Peliculas_PG> getPeliculas_PG_All_Nombreing(string nombreing){
				List<Peliculas_PG> lista=new List<Peliculas_PG>();
				Object [][]O=this.BD.select_Where(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_NOMBREING,nombreing);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getPeliculas_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Peliculas_PG getPeliculas_PG_For_Nombreing(string nombreing){
				Object []O=this.BD.select_Where_FirstRow(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_NOMBREING,nombreing);
				if (O!=null){
					return getPeliculas_PG_Args(O);
				}
				return null;
		}
		public override  List<Peliculas_PG> getPeliculas_PG_All_Nombre(string nombre){
				List<Peliculas_PG> lista=new List<Peliculas_PG>();
				Object [][]O=this.BD.select_Where(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_NOMBRE,nombre);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getPeliculas_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Peliculas_PG getPeliculas_PG_For_Nombre(string nombre){
				Object []O=this.BD.select_Where_FirstRow(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_NOMBRE,nombre);
				if (O!=null){
					return getPeliculas_PG_Args(O);
				}
				return null;
		}
		public override  List<Peliculas_PG> getPeliculas_PG_All_Genero(string genero){
				List<Peliculas_PG> lista=new List<Peliculas_PG>();
				Object [][]O=this.BD.select_Where(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_GENERO,genero);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getPeliculas_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Peliculas_PG> getPeliculas_PG_All_Nombre_Nombreing(string nombre,string nombreing){
				List<Peliculas_PG> lista=new List<Peliculas_PG>();
				Object [][]O=this.BD.select_Where(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_NOMBRE,nombre,Peliculas_PG.COLUMNA_NOMBREING,nombreing);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getPeliculas_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Peliculas_PG getPeliculas_PG_For_Nombre_Nombreing(string nombre,string nombreing){
				List<Peliculas_PG> lista=new List<Peliculas_PG>();
				Object []O=this.BD.select_Where_FirstRow(Peliculas_PG.TABLA_PELICULAS,Peliculas_PG.COLUMNA_NOMBRE,nombre,Peliculas_PG.COLUMNA_NOMBREING,nombreing);
				if (O!=null){
					return getPeliculas_PG_Args(O);
				}
				return null;
		}
		public override  List<Series_PG> getSeries_PG_All_Titulo(string titulo){
				List<Series_PG> lista=new List<Series_PG>();
				Object [][]O=this.BD.select_Where(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_TITULO,titulo);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeries_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Series_PG getSeries_PG_For_Titulo(string titulo){
				Object []O=this.BD.select_Where_FirstRow(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_TITULO,titulo);
				if (O!=null){
					return getSeries_PG_Args(O);
				}
				return null;
		}
		public override  List<Series_PG> getSeries_PG_All_Tituloing(string tituloing){
				List<Series_PG> lista=new List<Series_PG>();
				Object [][]O=this.BD.select_Where(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_TITULOING,tituloing);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeries_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Series_PG getSeries_PG_For_Tituloing(string tituloing){
				Object []O=this.BD.select_Where_FirstRow(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_TITULOING,tituloing);
				if (O!=null){
					return getSeries_PG_Args(O);
				}
				return null;
		}
		public override  List<Series_PG> getSeries_PG_All_Genero(string genero){
				List<Series_PG> lista=new List<Series_PG>();
				Object [][]O=this.BD.select_Where(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_GENERO,genero);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeries_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Series_PG> getSeries_PG_All_Titulo_Tituloing(string titulo,string tituloing){
				List<Series_PG> lista=new List<Series_PG>();
				Object [][]O=this.BD.select_Where(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_TITULO,titulo,Series_PG.COLUMNA_TITULOING,tituloing);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeries_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Series_PG getSeries_PG_For_Titulo_Tituloing(string titulo,string tituloing){
				List<Series_PG> lista=new List<Series_PG>();
				Object []O=this.BD.select_Where_FirstRow(Series_PG.TABLA_SERIES,Series_PG.COLUMNA_TITULO,titulo,Series_PG.COLUMNA_TITULOING,tituloing);
				if (O!=null){
					return getSeries_PG_Args(O);
				}
				return null;
		}
		public override  List<Actors_PG> getActors_PG_All_Nombre(string nombre){
				List<Actors_PG> lista=new List<Actors_PG>();
				Object [][]O=this.BD.select_Where(Actors_PG.TABLA_ACTORS,Actors_PG.COLUMNA_NOMBRE,nombre);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getActors_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Actors_PG getActors_PG_For_Nombre(string nombre){
				Object []O=this.BD.select_Where_FirstRow(Actors_PG.TABLA_ACTORS,Actors_PG.COLUMNA_NOMBRE,nombre);
				if (O!=null){
					return getActors_PG_Args(O);
				}
				return null;
		}
		public override  List<Sagas_PG> getSagas_PG_All_Saga(string saga){
				List<Sagas_PG> lista=new List<Sagas_PG>();
				Object [][]O=this.BD.select_Where(Sagas_PG.TABLA_SAGAS,Sagas_PG.COLUMNA_SAGA,saga);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSagas_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Sagas_PG getSagas_PG_For_Saga(string saga){
				Object []O=this.BD.select_Where_FirstRow(Sagas_PG.TABLA_SAGAS,Sagas_PG.COLUMNA_SAGA,saga);
				if (O!=null){
					return getSagas_PG_Args(O);
				}
				return null;
		}
		public override  List<Formatos_PG> getFormatos_PG_All_Formato(string formato){
				List<Formatos_PG> lista=new List<Formatos_PG>();
				Object [][]O=this.BD.select_Where(Formatos_PG.TABLA_FORMATOS,Formatos_PG.COLUMNA_FORMATO,formato);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getFormatos_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Formatos_PG getFormatos_PG_For_Formato(string formato){
				Object []O=this.BD.select_Where_FirstRow(Formatos_PG.TABLA_FORMATOS,Formatos_PG.COLUMNA_FORMATO,formato);
				if (O!=null){
					return getFormatos_PG_Args(O);
				}
				return null;
		}
		public override  List<Generos_PG> getGeneros_PG_All_Genero(string genero){
				List<Generos_PG> lista=new List<Generos_PG>();
				Object [][]O=this.BD.select_Where(Generos_PG.TABLA_GENEROS,Generos_PG.COLUMNA_GENERO,genero);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getGeneros_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Generos_PG getGeneros_PG_For_Genero(string genero){
				Object []O=this.BD.select_Where_FirstRow(Generos_PG.TABLA_GENEROS,Generos_PG.COLUMNA_GENERO,genero);
				if (O!=null){
					return getGeneros_PG_Args(O);
				}
				return null;
		}
		public override  List<Seriestemporadas_PG> getSeriestemporadas_PG_All_Idkey_idserie(int? idkey_idserie){
				List<Seriestemporadas_PG> lista=new List<Seriestemporadas_PG>();
				Object [][]O=this.BD.select_Where(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,Seriestemporadas_PG.COLUMNA_IDSERIE,idkey_idserie);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeriestemporadas_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Seriestemporadas_PG> getSeriestemporadas_PG_All_Idkey_idserie(Series_PG series){
				return getSeriestemporadas_PG_All_Idkey_idserie(series.idkey);
		}
		public override  void deleteSeriestemporadas_PG_For_Idkey_idserie(int? idkey_idserie){
				this.BD.delete(Seriestemporadas_PG.TABLA_SERIESTEMPORADAS,Seriestemporadas_PG.COLUMNA_IDSERIE,idkey_idserie);
		}
		public override  void deleteSeriestemporadas_PG_For_Idkey_idserie(Series_PG series){
				deleteSeriestemporadas_PG_For_Idkey_idserie(series.idkey);
		}
		public override  List<Autors_PG> getAutors_PG_All_Nombre(string nombre){
				List<Autors_PG> lista=new List<Autors_PG>();
				Object [][]O=this.BD.select_Where(Autors_PG.TABLA_AUTORS,Autors_PG.COLUMNA_NOMBRE,nombre);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getAutors_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Autors_PG getAutors_PG_For_Nombre(string nombre){
				Object []O=this.BD.select_Where_FirstRow(Autors_PG.TABLA_AUTORS,Autors_PG.COLUMNA_NOMBRE,nombre);
				if (O!=null){
					return getAutors_PG_Args(O);
				}
				return null;
		}
		public override  List<Albums_PG> getAlbums_PG_All_Titulo(string titulo){
				List<Albums_PG> lista=new List<Albums_PG>();
				Object [][]O=this.BD.select_Where(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_TITULO,titulo);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getAlbums_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Albums_PG getAlbums_PG_For_Titulo(string titulo){
				Object []O=this.BD.select_Where_FirstRow(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_TITULO,titulo);
				if (O!=null){
					return getAlbums_PG_Args(O);
				}
				return null;
		}
		public override  List<Albums_PG> getAlbums_PG_All_Idkey_idautor(int? idkey_idautor){
				List<Albums_PG> lista=new List<Albums_PG>();
				Object [][]O=this.BD.select_Where(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_IDAUTOR,idkey_idautor);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getAlbums_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Albums_PG> getAlbums_PG_All_Idkey_idautor(Autors_PG autors){
				return getAlbums_PG_All_Idkey_idautor(autors.idkey);
		}
		public override  void deleteAlbums_PG_For_Idkey_idautor(int? idkey_idautor){
				this.BD.delete(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_IDAUTOR,idkey_idautor);
		}
		public override  void deleteAlbums_PG_For_Idkey_idautor(Autors_PG autors){
				deleteAlbums_PG_For_Idkey_idautor(autors.idkey);
		}
		public override  void deleteAlbums_PG_For_Idkey_idautor_CASCADE(int? idkey_idautor){
			deleteAlbums_PG_For_Idkey_idautor_CASCADE(idkey_idautor,null);
		}
		public override  void deleteAlbums_PG_For_Idkey_idautor_CASCADE(int? idkey_idautor,Object modeloQueLoLlamo){
			List<Albums_PG> l=getAlbums_PG_All_Idkey_idautor(idkey_idautor);
			for(int i=0;i<l.Count;i++){
				Albums_PG albums=l[i];
				deleteCancionalbums_PG_For_Idkey_idalbum(albums.idkey);
			}
			deleteAlbums_PG_For_Idkey_idautor(idkey_idautor);
		}
		public override  List<Albums_PG> getAlbums_PG_All_Titulo_Idkey_idautor(string titulo,int? idkey_idautor){
				List<Albums_PG> lista=new List<Albums_PG>();
				Object [][]O=this.BD.select_Where(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_TITULO,titulo,Albums_PG.COLUMNA_IDAUTOR,idkey_idautor);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getAlbums_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Albums_PG> getAlbums_PG_All_Titulo_Idkey_idautor(string titulo,Autors_PG autors){
				return getAlbums_PG_All_Titulo_Idkey_idautor(titulo,autors.idkey);
		}
		public override Albums_PG getAlbums_PG_For_Titulo_Idkey_idautor(string titulo,int? idkey_idautor){
				List<Albums_PG> lista=new List<Albums_PG>();
				Object []O=this.BD.select_Where_FirstRow(Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_TITULO,titulo,Albums_PG.COLUMNA_IDAUTOR,idkey_idautor);
				if (O!=null){
					return getAlbums_PG_Args(O);
				}
				return null;
		}
		public override Albums_PG getAlbums_PG_For_Titulo_Idkey_idautor(string titulo,Autors_PG autors){
				return getAlbums_PG_For_Titulo_Idkey_idautor(titulo,autors.idkey);
		}
		public override  List<Cancionalbums_PG> getCancionalbums_PG_All_Titulo(string titulo){
				List<Cancionalbums_PG> lista=new List<Cancionalbums_PG>();
				Object [][]O=this.BD.select_Where(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_TITULO,titulo);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getCancionalbums_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Cancionalbums_PG getCancionalbums_PG_For_Titulo(string titulo){
				Object []O=this.BD.select_Where_FirstRow(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_TITULO,titulo);
				if (O!=null){
					return getCancionalbums_PG_Args(O);
				}
				return null;
		}
		public override  List<Cancionalbums_PG> getCancionalbums_PG_All_Idkey_idalbum(int? idkey_idalbum){
				List<Cancionalbums_PG> lista=new List<Cancionalbums_PG>();
				Object [][]O=this.BD.select_Where(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_IDALBUM,idkey_idalbum);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getCancionalbums_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Cancionalbums_PG> getCancionalbums_PG_All_Idkey_idalbum(Albums_PG albums){
				return getCancionalbums_PG_All_Idkey_idalbum(albums.idkey);
		}
		public override  void deleteCancionalbums_PG_For_Idkey_idalbum(int? idkey_idalbum){
				this.BD.delete(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_IDALBUM,idkey_idalbum);
		}
		public override  void deleteCancionalbums_PG_For_Idkey_idalbum(Albums_PG albums){
				deleteCancionalbums_PG_For_Idkey_idalbum(albums.idkey);
		}
		public override  List<Cancionalbums_PG> getCancionalbums_PG_All_Titulo_Idkey_idalbum(string titulo,int? idkey_idalbum){
				List<Cancionalbums_PG> lista=new List<Cancionalbums_PG>();
				Object [][]O=this.BD.select_Where(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_TITULO,titulo,Cancionalbums_PG.COLUMNA_IDALBUM,idkey_idalbum);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getCancionalbums_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Cancionalbums_PG> getCancionalbums_PG_All_Titulo_Idkey_idalbum(string titulo,Albums_PG albums){
				return getCancionalbums_PG_All_Titulo_Idkey_idalbum(titulo,albums.idkey);
		}
		public override Cancionalbums_PG getCancionalbums_PG_For_Titulo_Idkey_idalbum(string titulo,int? idkey_idalbum){
				List<Cancionalbums_PG> lista=new List<Cancionalbums_PG>();
				Object []O=this.BD.select_Where_FirstRow(Cancionalbums_PG.TABLA_CANCIONALBUMS,Cancionalbums_PG.COLUMNA_TITULO,titulo,Cancionalbums_PG.COLUMNA_IDALBUM,idkey_idalbum);
				if (O!=null){
					return getCancionalbums_PG_Args(O);
				}
				return null;
		}
		public override Cancionalbums_PG getCancionalbums_PG_For_Titulo_Idkey_idalbum(string titulo,Albums_PG albums){
				return getCancionalbums_PG_For_Titulo_Idkey_idalbum(titulo,albums.idkey);
		}
		public override  List<Dvd_PG> getDvd_PG_All_Titulo(string titulo){
				List<Dvd_PG> lista=new List<Dvd_PG>();
				Object [][]O=this.BD.select_Where(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_TITULO,titulo);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getDvd_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Dvd_PG getDvd_PG_For_Titulo(string titulo){
				Object []O=this.BD.select_Where_FirstRow(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_TITULO,titulo);
				if (O!=null){
					return getDvd_PG_Args(O);
				}
				return null;
		}
		public override  List<Dvd_PG> getDvd_PG_All_Autor(string autor){
				List<Dvd_PG> lista=new List<Dvd_PG>();
				Object [][]O=this.BD.select_Where(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_AUTOR,autor);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getDvd_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Dvd_PG> getDvd_PG_All_Titulo_Autor(string titulo,string autor){
				List<Dvd_PG> lista=new List<Dvd_PG>();
				Object [][]O=this.BD.select_Where(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_TITULO,titulo,Dvd_PG.COLUMNA_AUTOR,autor);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getDvd_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Dvd_PG getDvd_PG_For_Titulo_Autor(string titulo,string autor){
				List<Dvd_PG> lista=new List<Dvd_PG>();
				Object []O=this.BD.select_Where_FirstRow(Dvd_PG.TABLA_DVD,Dvd_PG.COLUMNA_TITULO,titulo,Dvd_PG.COLUMNA_AUTOR,autor);
				if (O!=null){
					return getDvd_PG_Args(O);
				}
				return null;
		}
		public override  List<Canciondvd_PG> getCanciondvd_PG_All_Nombre(string nombre){
				List<Canciondvd_PG> lista=new List<Canciondvd_PG>();
				Object [][]O=this.BD.select_Where(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_NOMBRE,nombre);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getCanciondvd_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override Canciondvd_PG getCanciondvd_PG_For_Nombre(string nombre){
				Object []O=this.BD.select_Where_FirstRow(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_NOMBRE,nombre);
				if (O!=null){
					return getCanciondvd_PG_Args(O);
				}
				return null;
		}
		public override  List<Canciondvd_PG> getCanciondvd_PG_All_Idkey_iddvd(int? idkey_iddvd){
				List<Canciondvd_PG> lista=new List<Canciondvd_PG>();
				Object [][]O=this.BD.select_Where(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_IDDVD,idkey_iddvd);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getCanciondvd_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Canciondvd_PG> getCanciondvd_PG_All_Idkey_iddvd(Dvd_PG dvd){
				return getCanciondvd_PG_All_Idkey_iddvd(dvd.idkey);
		}
		public override  void deleteCanciondvd_PG_For_Idkey_iddvd(int? idkey_iddvd){
				this.BD.delete(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_IDDVD,idkey_iddvd);
		}
		public override  void deleteCanciondvd_PG_For_Idkey_iddvd(Dvd_PG dvd){
				deleteCanciondvd_PG_For_Idkey_iddvd(dvd.idkey);
		}
		public override  List<Canciondvd_PG> getCanciondvd_PG_All_Nombre_Idkey_iddvd(string nombre,int? idkey_iddvd){
				List<Canciondvd_PG> lista=new List<Canciondvd_PG>();
				Object [][]O=this.BD.select_Where(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_NOMBRE,nombre,Canciondvd_PG.COLUMNA_IDDVD,idkey_iddvd);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getCanciondvd_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Canciondvd_PG> getCanciondvd_PG_All_Nombre_Idkey_iddvd(string nombre,Dvd_PG dvd){
				return getCanciondvd_PG_All_Nombre_Idkey_iddvd(nombre,dvd.idkey);
		}
		public override Canciondvd_PG getCanciondvd_PG_For_Nombre_Idkey_iddvd(string nombre,int? idkey_iddvd){
				List<Canciondvd_PG> lista=new List<Canciondvd_PG>();
				Object []O=this.BD.select_Where_FirstRow(Canciondvd_PG.TABLA_CANCIONDVD,Canciondvd_PG.COLUMNA_NOMBRE,nombre,Canciondvd_PG.COLUMNA_IDDVD,idkey_iddvd);
				if (O!=null){
					return getCanciondvd_PG_Args(O);
				}
				return null;
		}
		public override Canciondvd_PG getCanciondvd_PG_For_Nombre_Idkey_iddvd(string nombre,Dvd_PG dvd){
				return getCanciondvd_PG_For_Nombre_Idkey_iddvd(nombre,dvd.idkey);
		}
		public override  List<Series_actor_PG> getSeries_actor_PG_All_Idkey_serial_id(int? idkey_serial_id){
				List<Series_actor_PG> lista=new List<Series_actor_PG>();
				Object [][]O=this.BD.select_Where(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_SERIAL_ID,idkey_serial_id);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeries_actor_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Series_actor_PG> getSeries_actor_PG_All_Idkey_serial_id(Series_PG series){
				return getSeries_actor_PG_All_Idkey_serial_id(series.idkey);
		}
		public override  void deleteSeries_actor_PG_For_Idkey_serial_id(int? idkey_serial_id){
				this.BD.delete(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_SERIAL_ID,idkey_serial_id);
		}
		public override  void deleteSeries_actor_PG_For_Idkey_serial_id(Series_PG series){
				deleteSeries_actor_PG_For_Idkey_serial_id(series.idkey);
		}
		public override  List<Series_actor_PG> getSeries_actor_PG_All_Idkey_actor_id(int? idkey_actor_id){
				List<Series_actor_PG> lista=new List<Series_actor_PG>();
				Object [][]O=this.BD.select_Where(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_ACTOR_ID,idkey_actor_id);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getSeries_actor_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Series_actor_PG> getSeries_actor_PG_All_Idkey_actor_id(Actors_PG actors){
				return getSeries_actor_PG_All_Idkey_actor_id(actors.idkey);
		}
		public override  void deleteSeries_actor_PG_For_Idkey_actor_id(int? idkey_actor_id){
				this.BD.delete(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_ACTOR_ID,idkey_actor_id);
		}
		public override  void deleteSeries_actor_PG_For_Idkey_actor_id(Actors_PG actors){
				deleteSeries_actor_PG_For_Idkey_actor_id(actors.idkey);
		}
		public override  List<Peliculas_actor_PG> getPeliculas_actor_PG_All_Idkey_movie_id(int? idkey_movie_id){
				List<Peliculas_actor_PG> lista=new List<Peliculas_actor_PG>();
				Object [][]O=this.BD.select_Where(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_MOVIE_ID,idkey_movie_id);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getPeliculas_actor_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Peliculas_actor_PG> getPeliculas_actor_PG_All_Idkey_movie_id(Peliculas_PG peliculas){
				return getPeliculas_actor_PG_All_Idkey_movie_id(peliculas.idkey);
		}
		public override  void deletePeliculas_actor_PG_For_Idkey_movie_id(int? idkey_movie_id){
				this.BD.delete(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_MOVIE_ID,idkey_movie_id);
		}
		public override  void deletePeliculas_actor_PG_For_Idkey_movie_id(Peliculas_PG peliculas){
				deletePeliculas_actor_PG_For_Idkey_movie_id(peliculas.idkey);
		}
		public override  List<Peliculas_actor_PG> getPeliculas_actor_PG_All_Idkey_actor_id(int? idkey_actor_id){
				List<Peliculas_actor_PG> lista=new List<Peliculas_actor_PG>();
				Object [][]O=this.BD.select_Where(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_ACTOR_ID,idkey_actor_id);
				if (O!=null){
					for(int i=0;i<O.Length;i++){
						lista.Add(getPeliculas_actor_PG_Args(O[i]));
					}
				}
				return lista;
		}
		public override  List<Peliculas_actor_PG> getPeliculas_actor_PG_All_Idkey_actor_id(Actors_PG actors){
				return getPeliculas_actor_PG_All_Idkey_actor_id(actors.idkey);
		}
		public override  void deletePeliculas_actor_PG_For_Idkey_actor_id(int? idkey_actor_id){
				this.BD.delete(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_ACTOR_ID,idkey_actor_id);
		}
		public override  void deletePeliculas_actor_PG_For_Idkey_actor_id(Actors_PG actors){
				deletePeliculas_actor_PG_For_Idkey_actor_id(actors.idkey);
		}
	public override  List<Series_PG> getSeries_PG_All_Idkey_actors(int? idkey_actors){
		Object [][]O=this.BD.select_Where_Inner_Join_TodoDeTabla(Series_PG.TABLA_SERIES
			,new Object[]{
				new Object[]{
					new Object[]{Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_SERIAL_ID},
					new Object[]{Series_PG.TABLA_SERIES}
				},
				new Object[]{
					new Object[]{Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_ACTOR_ID},
					new Object[]{Actors_PG.TABLA_ACTORS}
				}
			}
			
			,new Object[]{Actors_PG.TABLA_ACTORS},idkey_actors);
		List<Series_PG> lista=new List<Series_PG>();
		if (O!=null){
			for(int i=0;i<O.Length;i++){
				lista.Add(getSeries_PG_Args(O[i]));
			}
		}
		return lista;
	}

	public override  List<Actors_PG> getActors_PG_All_Idkey_series(int? idkey_series){
		Object [][]O=this.BD.select_Where_Inner_Join_TodoDeTabla(Actors_PG.TABLA_ACTORS
			,new Object[]{
				new Object[]{
					new Object[]{Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_SERIAL_ID},
					new Object[]{Series_PG.TABLA_SERIES}
				},
				new Object[]{
					new Object[]{Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_ACTOR_ID},
					new Object[]{Actors_PG.TABLA_ACTORS}
				}
			}
			
			,new Object[]{Series_PG.TABLA_SERIES},idkey_series);
		List<Actors_PG> lista=new List<Actors_PG>();
		if (O!=null){
			for(int i=0;i<O.Length;i++){
				lista.Add(getActors_PG_Args(O[i]));
			}
		}
		return lista;
	}
		public override Series_actor_PG getSeries_actor_PG(int? idkey_serial_id,int? idkey_actor_id){
				List<Series_actor_PG> lista=new List<Series_actor_PG>();
				Object []O=this.BD.select_Where_FirstRow(Series_actor_PG.TABLA_SERIES_ACTOR,Series_actor_PG.COLUMNA_SERIAL_ID,idkey_serial_id,Series_actor_PG.COLUMNA_ACTOR_ID,idkey_actor_id);
				if (O!=null){
					return getSeries_actor_PG_Args(O);
				}
				return null;
		}
		public override Series_actor_PG getSeries_actor_PG(Series_PG series,Actors_PG actors){
				return getSeries_actor_PG(series.idkey,actors.idkey);
		}
		public override  bool existeSeries_actor_PG(int? idkey_serial_id,int? idkey_actor_id){
				return this.BD.existe(Series_actor_PG.TABLA_SERIES_ACTOR
						,Series_actor_PG.COLUMNA_SERIAL_ID,idkey_serial_id
						,Series_actor_PG.COLUMNA_ACTOR_ID,idkey_actor_id);
		}
	public override  List<Peliculas_PG> getPeliculas_PG_All_Idkey_actors(int? idkey_actors){
		Object [][]O=this.BD.select_Where_Inner_Join_TodoDeTabla(Peliculas_PG.TABLA_PELICULAS
			,new Object[]{
				new Object[]{
					new Object[]{Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_MOVIE_ID},
					new Object[]{Peliculas_PG.TABLA_PELICULAS}
				},
				new Object[]{
					new Object[]{Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_ACTOR_ID},
					new Object[]{Actors_PG.TABLA_ACTORS}
				}
			}
			
			,new Object[]{Actors_PG.TABLA_ACTORS},idkey_actors);
		List<Peliculas_PG> lista=new List<Peliculas_PG>();
		if (O!=null){
			for(int i=0;i<O.Length;i++){
				lista.Add(getPeliculas_PG_Args(O[i]));
			}
		}
		return lista;
	}

	public override  List<Actors_PG> getActors_PG_All_Idkey_peliculas(int? idkey_peliculas){
		Object [][]O=this.BD.select_Where_Inner_Join_TodoDeTabla(Actors_PG.TABLA_ACTORS
			,new Object[]{
				new Object[]{
					new Object[]{Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_MOVIE_ID},
					new Object[]{Peliculas_PG.TABLA_PELICULAS}
				},
				new Object[]{
					new Object[]{Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_ACTOR_ID},
					new Object[]{Actors_PG.TABLA_ACTORS}
				}
			}
			
			,new Object[]{Peliculas_PG.TABLA_PELICULAS},idkey_peliculas);
		List<Actors_PG> lista=new List<Actors_PG>();
		if (O!=null){
			for(int i=0;i<O.Length;i++){
				lista.Add(getActors_PG_Args(O[i]));
			}
		}
		return lista;
	}
		public override Peliculas_actor_PG getPeliculas_actor_PG(int? idkey_movie_id,int? idkey_actor_id){
				List<Peliculas_actor_PG> lista=new List<Peliculas_actor_PG>();
				Object []O=this.BD.select_Where_FirstRow(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR,Peliculas_actor_PG.COLUMNA_MOVIE_ID,idkey_movie_id,Peliculas_actor_PG.COLUMNA_ACTOR_ID,idkey_actor_id);
				if (O!=null){
					return getPeliculas_actor_PG_Args(O);
				}
				return null;
		}
		public override Peliculas_actor_PG getPeliculas_actor_PG(Peliculas_PG peliculas,Actors_PG actors){
				return getPeliculas_actor_PG(peliculas.idkey,actors.idkey);
		}
		public override  bool existePeliculas_actor_PG(int? idkey_movie_id,int? idkey_actor_id){
				return this.BD.existe(Peliculas_actor_PG.TABLA_PELICULAS_ACTOR
						,Peliculas_actor_PG.COLUMNA_MOVIE_ID,idkey_movie_id
						,Peliculas_actor_PG.COLUMNA_ACTOR_ID,idkey_actor_id);
		}
	public override Albums_PG getAlbums_PG_For_Titulo_Nombre(string titulo,string nombre){
		Object []O=this.BD.select_Where_Inner_Join_TodoDeTabla_FirstRow(Albums_PG.TABLA_ALBUMS
			,new Object[]{
				new Object[]{
					new Object[]{Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_IDAUTOR},
					new Object[]{Autors_PG.TABLA_AUTORS}
				}
			}
			
			,new Object[]{Albums_PG.TABLA_ALBUMS,Albums_PG.COLUMNA_TITULO},titulo
			,new Object[]{Autors_PG.TABLA_AUTORS,Autors_PG.COLUMNA_NOMBRE},nombre);
		if (O!=null){
			return getAlbums_PG_Args(O);
		}
		return null;
	}
	}
}
