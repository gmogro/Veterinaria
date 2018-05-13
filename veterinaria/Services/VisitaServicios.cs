using System.Collections.Generic;
using System;
using veterinaria.Repository;
using veterinaria.Entities;

using NHibernate;

namespace veterinaria.Services
{
	public class VisitaServicio
	{
		private VisitaRepositorio repo;
		
		public VisitaServicio()
		{
			
			repo = new VisitaRepositorio();
		}
		
		public void setSession(ISession sesion){
			repo.setSession(sesion);
		}
		
		public void agregarVisita (Visita vis){
			repo.agregarVisita(vis);
		}
		
		public void eliminarVisita(int id){
			repo.eliminarVisita(id);
		}
		
		public void actualizarVisita(Visita vis){
			repo.actualizarVisita(vis);
		}
		
		public IList<Visita>  listarTodos(){
			return repo.listarTodos();
		}
		
		public Visita VisitaPorId(int id){
			return repo.VisitaPorID(id);
		}
	}
}
