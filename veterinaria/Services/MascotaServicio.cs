using System;
using veterinaria.Entities;
using veterinaria.Repository;
using NHibernate;
using System.Collections.Generic;

namespace veterinaria.Services 
	
{
	public class MascotaServicio
	{
		private MascotaRepositorio repo;
		
		public MascotaServicio()
		{
			repo = new MascotaRepositorio();
		}
		
		public void setSession(ISession sesion){
			repo.setSession(sesion);
		}
		
		public void agregarMascota (Mascota mas){
			repo.agregarMascota(mas);
		}
		
		public void eliminarMascota(int id){
			repo.eliminarMascota(id);
		}
		
		public void actualizarMascota(Mascota mas){
			repo.actualizarMascota(mas);
		}
		
		public IList<Mascota>  listarTodos(){
			return repo.listarTodos();
		}
		
		public Mascota MascotaPorId(int id){
			return repo.MascotaPorID(id);
		}
	}
}

