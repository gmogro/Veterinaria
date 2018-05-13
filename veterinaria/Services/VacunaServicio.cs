using System.Collections.Generic;
using System;
using veterinaria.Entities;
using veterinaria.Repository;
using NHibernate;

namespace veterinaria.Services
	
{
	public class VacunaServicio
	{
		private VacunaRepositorio repo;
		
		public VacunaServicio()
		{
			
			repo = new VacunaRepositorio();
		}
		
		public void setSession(ISession sesion){
			repo.setSession(sesion);
		}
		
		public void agregarVacuna (Vacuna vac){
			repo.agregarVacuna(vac);
		}
		
		public void eliminarVacuna(int id){
			repo.eliminarVacuna(id);
		}
		
		public void actualizarVacuna(Vacuna vac){
			repo.actualizarVacuna(vac);
		}
		
		public IList<Vacuna>  listarTodos(){
			return repo.listarTodos();
		}
		
		public Vacuna VacunaPorId(int id){
			return repo.VacunaPorID(id);
		}
	}
}