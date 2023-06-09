

using ReneUtiles.Clases.BD;
using ReneUtiles;
using ReneUtiles.Clases;
using System;
using System.IO;
using System.Collections.Generic;
namespace BDManagerPaquete{
	
public abstract class I_BD_AdminPosgres:BasicoBD{
		public BDConexion BD;
		protected BDUpdates __Upd;
		protected bool usarUpdater;
		public abstract  I_BD_AdminPosgres no_cl();
		public abstract  I_BD_AdminPosgres crearTablaPeliculas_PG();
		public abstract  I_BD_AdminPosgres crearTablaPeliculas_PGSiNoExiste();
		public abstract  Peliculas_PG getPeliculas_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Peliculas_PG(Peliculas_PG peliculas);
		public abstract  Peliculas_PG getPeliculas_PG_id(int? id);
		public abstract  Peliculas_PG insertarPeliculas_PG(Peliculas_PG peliculas);
		public abstract   List<Peliculas_PG> getPeliculas_PG_All();
		public abstract  Peliculas_PG updatePeliculas_PG(Peliculas_PG peliculas);
		public abstract  void deletePeliculas_PG_ForId(int? id);
		public abstract  void deletePeliculas_PG_ForId(Peliculas_PG peliculas);
		public abstract  bool existePeliculas_PG_id(int? id);
		public abstract  bool existePeliculas_PG_Nombreing(string nombreing);
		public abstract  bool existePeliculas_PG_Nombre(string nombre);
		public abstract  bool existePeliculas_PG_Nombre_Nombreing(string nombre,string nombreing);
		public abstract  void deletePeliculas_PG_ForId_CASCADE(int? idkey_peliculas);
		public abstract  void deletePeliculas_PG_ForId_CASCADE(int? idkey_peliculas,Object modeloQueLoLlamo);
		public abstract  I_BD_AdminPosgres crearTablaSeries_PG();
		public abstract  I_BD_AdminPosgres crearTablaSeries_PGSiNoExiste();
		public abstract  Series_PG getSeries_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Series_PG(Series_PG series);
		public abstract  Series_PG getSeries_PG_id(int? id);
		public abstract  Series_PG insertarSeries_PG(Series_PG series);
		public abstract   List<Series_PG> getSeries_PG_All();
		public abstract  Series_PG updateSeries_PG(Series_PG series);
		public abstract  void deleteSeries_PG_ForId(int? id);
		public abstract  void deleteSeries_PG_ForId(Series_PG series);
		public abstract  bool existeSeries_PG_id(int? id);
		public abstract  bool existeSeries_PG_Titulo(string titulo);
		public abstract  bool existeSeries_PG_Tituloing(string tituloing);
		public abstract  bool existeSeries_PG_Titulo_Tituloing(string titulo,string tituloing);
		public abstract  void deleteSeries_PG_ForId_CASCADE(int? idkey_series);
		public abstract  void deleteSeries_PG_ForId_CASCADE(int? idkey_series,Object modeloQueLoLlamo);
		public abstract  I_BD_AdminPosgres crearTablaActors_PG();
		public abstract  I_BD_AdminPosgres crearTablaActors_PGSiNoExiste();
		public abstract  Actors_PG getActors_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Actors_PG(Actors_PG actors);
		public abstract  Actors_PG getActors_PG_id(int? id);
		public abstract  Actors_PG insertarActors_PG(Actors_PG actors);
		public abstract   List<Actors_PG> getActors_PG_All();
		public abstract  Actors_PG updateActors_PG(Actors_PG actors);
		public abstract  void deleteActors_PG_ForId(int? id);
		public abstract  void deleteActors_PG_ForId(Actors_PG actors);
		public abstract  bool existeActors_PG_id(int? id);
		public abstract  bool existeActors_PG_Nombre(string nombre);
		public abstract  void deleteActors_PG_ForId_CASCADE(int? idkey_actors);
		public abstract  void deleteActors_PG_ForId_CASCADE(int? idkey_actors,Object modeloQueLoLlamo);
		public abstract  I_BD_AdminPosgres crearTablaSagas_PG();
		public abstract  I_BD_AdminPosgres crearTablaSagas_PGSiNoExiste();
		public abstract  Sagas_PG getSagas_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Sagas_PG(Sagas_PG sagas);
		public abstract  Sagas_PG getSagas_PG_id(int? id);
		public abstract  Sagas_PG insertarSagas_PG(Sagas_PG sagas);
		public abstract   List<Sagas_PG> getSagas_PG_All();
		public abstract  Sagas_PG updateSagas_PG(Sagas_PG sagas);
		public abstract  void deleteSagas_PG_ForId(int? id);
		public abstract  void deleteSagas_PG_ForId(Sagas_PG sagas);
		public abstract  bool existeSagas_PG_id(int? id);
		public abstract  bool existeSagas_PG_Saga(string saga);
		public abstract  I_BD_AdminPosgres crearTablaFormatos_PG();
		public abstract  I_BD_AdminPosgres crearTablaFormatos_PGSiNoExiste();
		public abstract  Formatos_PG getFormatos_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Formatos_PG(Formatos_PG formatos);
		public abstract  Formatos_PG getFormatos_PG_id(int? id);
		public abstract  Formatos_PG insertarFormatos_PG(Formatos_PG formatos);
		public abstract   List<Formatos_PG> getFormatos_PG_All();
		public abstract  Formatos_PG updateFormatos_PG(Formatos_PG formatos);
		public abstract  void deleteFormatos_PG_ForId(int? id);
		public abstract  void deleteFormatos_PG_ForId(Formatos_PG formatos);
		public abstract  bool existeFormatos_PG_id(int? id);
		public abstract  bool existeFormatos_PG_Formato(string formato);
		public abstract  I_BD_AdminPosgres crearTablaGeneros_PG();
		public abstract  I_BD_AdminPosgres crearTablaGeneros_PGSiNoExiste();
		public abstract  Generos_PG getGeneros_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Generos_PG(Generos_PG generos);
		public abstract  Generos_PG getGeneros_PG_id(int? id);
		public abstract  Generos_PG insertarGeneros_PG(Generos_PG generos);
		public abstract   List<Generos_PG> getGeneros_PG_All();
		public abstract  Generos_PG updateGeneros_PG(Generos_PG generos);
		public abstract  void deleteGeneros_PG_ForId(int? id);
		public abstract  void deleteGeneros_PG_ForId(Generos_PG generos);
		public abstract  bool existeGeneros_PG_id(int? id);
		public abstract  bool existeGeneros_PG_Genero(string genero);
		public abstract  I_BD_AdminPosgres crearTablaSeriestemporadas_PG();
		public abstract  I_BD_AdminPosgres crearTablaSeriestemporadas_PGSiNoExiste();
		public abstract  Seriestemporadas_PG getSeriestemporadas_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Seriestemporadas_PG(Seriestemporadas_PG seriestemporadas);
		public abstract  Seriestemporadas_PG getSeriestemporadas_PG_id(int? id);
		public abstract  Seriestemporadas_PG insertarSeriestemporadas_PG(Seriestemporadas_PG seriestemporadas);
		public abstract   List<Seriestemporadas_PG> getSeriestemporadas_PG_All();
		public abstract  Seriestemporadas_PG updateSeriestemporadas_PG(Seriestemporadas_PG seriestemporadas);
		public abstract  void deleteSeriestemporadas_PG_ForId(int? id);
		public abstract  void deleteSeriestemporadas_PG_ForId(Seriestemporadas_PG seriestemporadas);
		public abstract  bool existeSeriestemporadas_PG_id(int? id);
		public abstract  I_BD_AdminPosgres crearTablaAutors_PG();
		public abstract  I_BD_AdminPosgres crearTablaAutors_PGSiNoExiste();
		public abstract  Autors_PG getAutors_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Autors_PG(Autors_PG autors);
		public abstract  Autors_PG getAutors_PG_id(int? id);
		public abstract  Autors_PG insertarAutors_PG(Autors_PG autors);
		public abstract   List<Autors_PG> getAutors_PG_All();
		public abstract  Autors_PG updateAutors_PG(Autors_PG autors);
		public abstract  void deleteAutors_PG_ForId(int? id);
		public abstract  void deleteAutors_PG_ForId(Autors_PG autors);
		public abstract  bool existeAutors_PG_id(int? id);
		public abstract  bool existeAutors_PG_Nombre(string nombre);
		public abstract  void deleteAutors_PG_ForId_CASCADE(int? idkey_autors);
		public abstract  void deleteAutors_PG_ForId_CASCADE(int? idkey_autors,Object modeloQueLoLlamo);
		public abstract  I_BD_AdminPosgres crearTablaAlbums_PG();
		public abstract  I_BD_AdminPosgres crearTablaAlbums_PGSiNoExiste();
		public abstract  Albums_PG getAlbums_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Albums_PG(Albums_PG albums);
		public abstract  Albums_PG getAlbums_PG_id(int? id);
		public abstract  Albums_PG insertarAlbums_PG(Albums_PG albums);
		public abstract   List<Albums_PG> getAlbums_PG_All();
		public abstract  Albums_PG updateAlbums_PG(Albums_PG albums);
		public abstract  void deleteAlbums_PG_ForId(int? id);
		public abstract  void deleteAlbums_PG_ForId(Albums_PG albums);
		public abstract  bool existeAlbums_PG_id(int? id);
		public abstract  bool existeAlbums_PG_Titulo(string titulo);
		public abstract  bool existeAlbums_PG_Titulo_Idkey_idautor(string titulo,int? idkey_idautor);
		public abstract  void deleteAlbums_PG_ForId_CASCADE(int? idkey_albums);
		public abstract  void deleteAlbums_PG_ForId_CASCADE(int? idkey_albums,Object modeloQueLoLlamo);
		public abstract  I_BD_AdminPosgres crearTablaCancionalbums_PG();
		public abstract  I_BD_AdminPosgres crearTablaCancionalbums_PGSiNoExiste();
		public abstract  Cancionalbums_PG getCancionalbums_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Cancionalbums_PG(Cancionalbums_PG cancionalbums);
		public abstract  Cancionalbums_PG getCancionalbums_PG_id(int? id);
		public abstract  Cancionalbums_PG insertarCancionalbums_PG(Cancionalbums_PG cancionalbums);
		public abstract   List<Cancionalbums_PG> getCancionalbums_PG_All();
		public abstract  Cancionalbums_PG updateCancionalbums_PG(Cancionalbums_PG cancionalbums);
		public abstract  void deleteCancionalbums_PG_ForId(int? id);
		public abstract  void deleteCancionalbums_PG_ForId(Cancionalbums_PG cancionalbums);
		public abstract  bool existeCancionalbums_PG_id(int? id);
		public abstract  bool existeCancionalbums_PG_Titulo(string titulo);
		public abstract  bool existeCancionalbums_PG_Titulo_Idkey_idalbum(string titulo,int? idkey_idalbum);
		public abstract  I_BD_AdminPosgres crearTablaDvd_PG();
		public abstract  I_BD_AdminPosgres crearTablaDvd_PGSiNoExiste();
		public abstract  Dvd_PG getDvd_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Dvd_PG(Dvd_PG dvd);
		public abstract  Dvd_PG getDvd_PG_id(int? id);
		public abstract  Dvd_PG insertarDvd_PG(Dvd_PG dvd);
		public abstract   List<Dvd_PG> getDvd_PG_All();
		public abstract  Dvd_PG updateDvd_PG(Dvd_PG dvd);
		public abstract  void deleteDvd_PG_ForId(int? id);
		public abstract  void deleteDvd_PG_ForId(Dvd_PG dvd);
		public abstract  bool existeDvd_PG_id(int? id);
		public abstract  bool existeDvd_PG_Titulo(string titulo);
		public abstract  bool existeDvd_PG_Titulo_Autor(string titulo,string autor);
		public abstract  void deleteDvd_PG_ForId_CASCADE(int? idkey_dvd);
		public abstract  void deleteDvd_PG_ForId_CASCADE(int? idkey_dvd,Object modeloQueLoLlamo);
		public abstract  I_BD_AdminPosgres crearTablaCanciondvd_PG();
		public abstract  I_BD_AdminPosgres crearTablaCanciondvd_PGSiNoExiste();
		public abstract  Canciondvd_PG getCanciondvd_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Canciondvd_PG(Canciondvd_PG canciondvd);
		public abstract  Canciondvd_PG getCanciondvd_PG_id(int? id);
		public abstract  Canciondvd_PG insertarCanciondvd_PG(Canciondvd_PG canciondvd);
		public abstract   List<Canciondvd_PG> getCanciondvd_PG_All();
		public abstract  Canciondvd_PG updateCanciondvd_PG(Canciondvd_PG canciondvd);
		public abstract  void deleteCanciondvd_PG_ForId(int? id);
		public abstract  void deleteCanciondvd_PG_ForId(Canciondvd_PG canciondvd);
		public abstract  bool existeCanciondvd_PG_id(int? id);
		public abstract  bool existeCanciondvd_PG_Nombre(string nombre);
		public abstract  bool existeCanciondvd_PG_Nombre_Idkey_iddvd(string nombre,int? idkey_iddvd);
		public abstract  I_BD_AdminPosgres crearTablaSeries_actor_PG();
		public abstract  I_BD_AdminPosgres crearTablaSeries_actor_PGSiNoExiste();
		public abstract  Series_actor_PG getSeries_actor_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Series_actor_PG(Series_actor_PG series_actor);
		public abstract  Series_actor_PG getSeries_actor_PG_id(int? id);
		public abstract  Series_actor_PG insertarSeries_actor_PG(Series_actor_PG series_actor);
		public abstract   List<Series_actor_PG> getSeries_actor_PG_All();
		public abstract  Series_actor_PG updateSeries_actor_PG(Series_actor_PG series_actor);
		public abstract  void deleteSeries_actor_PG_ForId(int? id);
		public abstract  void deleteSeries_actor_PG_ForId(Series_actor_PG series_actor);
		public abstract  bool existeSeries_actor_PG_id(int? id);
		public abstract  I_BD_AdminPosgres crearTablaPeliculas_actor_PG();
		public abstract  I_BD_AdminPosgres crearTablaPeliculas_actor_PGSiNoExiste();
		public abstract  Peliculas_actor_PG getPeliculas_actor_PG_Args(Object[] listaDeArgumentos);
		public abstract  Object[] __content_Peliculas_actor_PG(Peliculas_actor_PG peliculas_actor);
		public abstract  Peliculas_actor_PG getPeliculas_actor_PG_id(int? id);
		public abstract  Peliculas_actor_PG insertarPeliculas_actor_PG(Peliculas_actor_PG peliculas_actor);
		public abstract   List<Peliculas_actor_PG> getPeliculas_actor_PG_All();
		public abstract  Peliculas_actor_PG updatePeliculas_actor_PG(Peliculas_actor_PG peliculas_actor);
		public abstract  void deletePeliculas_actor_PG_ForId(int? id);
		public abstract  void deletePeliculas_actor_PG_ForId(Peliculas_actor_PG peliculas_actor);
		public abstract  bool existePeliculas_actor_PG_id(int? id);
		public abstract  void crearTodasLasTablas();
		public abstract  void crearTodasLasTablasSiNoExisten();
		public abstract  List<Peliculas_PG> getPeliculas_PG_All_Nombreing(string nombreing);
		public abstract  Peliculas_PG getPeliculas_PG_For_Nombreing(string nombreing);
		public abstract  List<Peliculas_PG> getPeliculas_PG_All_Nombre(string nombre);
		public abstract  Peliculas_PG getPeliculas_PG_For_Nombre(string nombre);
		public abstract  List<Peliculas_PG> getPeliculas_PG_All_Genero(string genero);
		public abstract  List<Peliculas_PG> getPeliculas_PG_All_Nombre_Nombreing(string nombre,string nombreing);
		public abstract  Peliculas_PG getPeliculas_PG_For_Nombre_Nombreing(string nombre,string nombreing);
		public abstract  List<Series_PG> getSeries_PG_All_Titulo(string titulo);
		public abstract  Series_PG getSeries_PG_For_Titulo(string titulo);
		public abstract  List<Series_PG> getSeries_PG_All_Tituloing(string tituloing);
		public abstract  Series_PG getSeries_PG_For_Tituloing(string tituloing);
		public abstract  List<Series_PG> getSeries_PG_All_Genero(string genero);
		public abstract  List<Series_PG> getSeries_PG_All_Titulo_Tituloing(string titulo,string tituloing);
		public abstract  Series_PG getSeries_PG_For_Titulo_Tituloing(string titulo,string tituloing);
		public abstract  List<Actors_PG> getActors_PG_All_Nombre(string nombre);
		public abstract  Actors_PG getActors_PG_For_Nombre(string nombre);
		public abstract  List<Sagas_PG> getSagas_PG_All_Saga(string saga);
		public abstract  Sagas_PG getSagas_PG_For_Saga(string saga);
		public abstract  List<Formatos_PG> getFormatos_PG_All_Formato(string formato);
		public abstract  Formatos_PG getFormatos_PG_For_Formato(string formato);
		public abstract  List<Generos_PG> getGeneros_PG_All_Genero(string genero);
		public abstract  Generos_PG getGeneros_PG_For_Genero(string genero);
		public abstract  List<Seriestemporadas_PG> getSeriestemporadas_PG_All_Idkey_idserie(int? idkey_idserie);
		public abstract  List<Seriestemporadas_PG> getSeriestemporadas_PG_All_Idkey_idserie(Series_PG series);
		public abstract  void deleteSeriestemporadas_PG_For_Idkey_idserie(int? idkey_idserie);
		public abstract  void deleteSeriestemporadas_PG_For_Idkey_idserie(Series_PG series);
		public abstract  List<Autors_PG> getAutors_PG_All_Nombre(string nombre);
		public abstract  Autors_PG getAutors_PG_For_Nombre(string nombre);
		public abstract  List<Albums_PG> getAlbums_PG_All_Titulo(string titulo);
		public abstract  Albums_PG getAlbums_PG_For_Titulo(string titulo);
		public abstract  List<Albums_PG> getAlbums_PG_All_Idkey_idautor(int? idkey_idautor);
		public abstract  List<Albums_PG> getAlbums_PG_All_Idkey_idautor(Autors_PG autors);
		public abstract  void deleteAlbums_PG_For_Idkey_idautor(int? idkey_idautor);
		public abstract  void deleteAlbums_PG_For_Idkey_idautor(Autors_PG autors);
		public abstract  void deleteAlbums_PG_For_Idkey_idautor_CASCADE(int? idkey_idautor);
		public abstract  void deleteAlbums_PG_For_Idkey_idautor_CASCADE(int? idkey_idautor,Object modeloQueLoLlamo);
		public abstract  List<Albums_PG> getAlbums_PG_All_Titulo_Idkey_idautor(string titulo,int? idkey_idautor);
		public abstract  List<Albums_PG> getAlbums_PG_All_Titulo_Idkey_idautor(string titulo,Autors_PG autors);
		public abstract  Albums_PG getAlbums_PG_For_Titulo_Idkey_idautor(string titulo,int? idkey_idautor);
		public abstract  Albums_PG getAlbums_PG_For_Titulo_Idkey_idautor(string titulo,Autors_PG autors);
		public abstract  List<Cancionalbums_PG> getCancionalbums_PG_All_Titulo(string titulo);
		public abstract  Cancionalbums_PG getCancionalbums_PG_For_Titulo(string titulo);
		public abstract  List<Cancionalbums_PG> getCancionalbums_PG_All_Idkey_idalbum(int? idkey_idalbum);
		public abstract  List<Cancionalbums_PG> getCancionalbums_PG_All_Idkey_idalbum(Albums_PG albums);
		public abstract  void deleteCancionalbums_PG_For_Idkey_idalbum(int? idkey_idalbum);
		public abstract  void deleteCancionalbums_PG_For_Idkey_idalbum(Albums_PG albums);
		public abstract  List<Cancionalbums_PG> getCancionalbums_PG_All_Titulo_Idkey_idalbum(string titulo,int? idkey_idalbum);
		public abstract  List<Cancionalbums_PG> getCancionalbums_PG_All_Titulo_Idkey_idalbum(string titulo,Albums_PG albums);
		public abstract  Cancionalbums_PG getCancionalbums_PG_For_Titulo_Idkey_idalbum(string titulo,int? idkey_idalbum);
		public abstract  Cancionalbums_PG getCancionalbums_PG_For_Titulo_Idkey_idalbum(string titulo,Albums_PG albums);
		public abstract  List<Dvd_PG> getDvd_PG_All_Titulo(string titulo);
		public abstract  Dvd_PG getDvd_PG_For_Titulo(string titulo);
		public abstract  List<Dvd_PG> getDvd_PG_All_Autor(string autor);
		public abstract  List<Dvd_PG> getDvd_PG_All_Titulo_Autor(string titulo,string autor);
		public abstract  Dvd_PG getDvd_PG_For_Titulo_Autor(string titulo,string autor);
		public abstract  List<Canciondvd_PG> getCanciondvd_PG_All_Nombre(string nombre);
		public abstract  Canciondvd_PG getCanciondvd_PG_For_Nombre(string nombre);
		public abstract  List<Canciondvd_PG> getCanciondvd_PG_All_Idkey_iddvd(int? idkey_iddvd);
		public abstract  List<Canciondvd_PG> getCanciondvd_PG_All_Idkey_iddvd(Dvd_PG dvd);
		public abstract  void deleteCanciondvd_PG_For_Idkey_iddvd(int? idkey_iddvd);
		public abstract  void deleteCanciondvd_PG_For_Idkey_iddvd(Dvd_PG dvd);
		public abstract  List<Canciondvd_PG> getCanciondvd_PG_All_Nombre_Idkey_iddvd(string nombre,int? idkey_iddvd);
		public abstract  List<Canciondvd_PG> getCanciondvd_PG_All_Nombre_Idkey_iddvd(string nombre,Dvd_PG dvd);
		public abstract  Canciondvd_PG getCanciondvd_PG_For_Nombre_Idkey_iddvd(string nombre,int? idkey_iddvd);
		public abstract  Canciondvd_PG getCanciondvd_PG_For_Nombre_Idkey_iddvd(string nombre,Dvd_PG dvd);
		public abstract  List<Series_actor_PG> getSeries_actor_PG_All_Idkey_serial_id(int? idkey_serial_id);
		public abstract  List<Series_actor_PG> getSeries_actor_PG_All_Idkey_serial_id(Series_PG series);
		public abstract  void deleteSeries_actor_PG_For_Idkey_serial_id(int? idkey_serial_id);
		public abstract  void deleteSeries_actor_PG_For_Idkey_serial_id(Series_PG series);
		public abstract  List<Series_actor_PG> getSeries_actor_PG_All_Idkey_actor_id(int? idkey_actor_id);
		public abstract  List<Series_actor_PG> getSeries_actor_PG_All_Idkey_actor_id(Actors_PG actors);
		public abstract  void deleteSeries_actor_PG_For_Idkey_actor_id(int? idkey_actor_id);
		public abstract  void deleteSeries_actor_PG_For_Idkey_actor_id(Actors_PG actors);
		public abstract  List<Peliculas_actor_PG> getPeliculas_actor_PG_All_Idkey_movie_id(int? idkey_movie_id);
		public abstract  List<Peliculas_actor_PG> getPeliculas_actor_PG_All_Idkey_movie_id(Peliculas_PG peliculas);
		public abstract  void deletePeliculas_actor_PG_For_Idkey_movie_id(int? idkey_movie_id);
		public abstract  void deletePeliculas_actor_PG_For_Idkey_movie_id(Peliculas_PG peliculas);
		public abstract  List<Peliculas_actor_PG> getPeliculas_actor_PG_All_Idkey_actor_id(int? idkey_actor_id);
		public abstract  List<Peliculas_actor_PG> getPeliculas_actor_PG_All_Idkey_actor_id(Actors_PG actors);
		public abstract  void deletePeliculas_actor_PG_For_Idkey_actor_id(int? idkey_actor_id);
		public abstract  void deletePeliculas_actor_PG_For_Idkey_actor_id(Actors_PG actors);
	public abstract  List<Series_PG> getSeries_PG_All_Idkey_actors(int? idkey_actors);

	public abstract  List<Actors_PG> getActors_PG_All_Idkey_series(int? idkey_series);
		public abstract  Series_actor_PG getSeries_actor_PG(int? idkey_serial_id,int? idkey_actor_id);
		public abstract  Series_actor_PG getSeries_actor_PG(Series_PG series,Actors_PG actors);
		public abstract  bool existeSeries_actor_PG(int? idkey_serial_id,int? idkey_actor_id);
	public abstract  List<Peliculas_PG> getPeliculas_PG_All_Idkey_actors(int? idkey_actors);

	public abstract  List<Actors_PG> getActors_PG_All_Idkey_peliculas(int? idkey_peliculas);
		public abstract  Peliculas_actor_PG getPeliculas_actor_PG(int? idkey_movie_id,int? idkey_actor_id);
		public abstract  Peliculas_actor_PG getPeliculas_actor_PG(Peliculas_PG peliculas,Actors_PG actors);
		public abstract  bool existePeliculas_actor_PG(int? idkey_movie_id,int? idkey_actor_id);
	public abstract  Albums_PG getAlbums_PG_For_Titulo_Nombre(string titulo,string nombre);
	}
}
