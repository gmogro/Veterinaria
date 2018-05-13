using System;
using System.Collections.Generic;
using veterinaria.Repository;
using veterinaria.Entities;
using NHibernate;

namespace veterinaria.Services
{
	public class ClienteServicio 
	{
		private ClienteRepository repo;
		
		public ClienteServicio()
		{
			repo = new ClienteRepository();
		}
		
		public void setSession(ISession sesion){
			repo.setSession(sesion);
		}
		
		public void agregarCliente(Cliente art){
			repo.agregarCliente(art);
		}
		
		public void eliminarCliente(int id){
			repo.eliminarCliente(id);
		}
		
		public void actualizarCliente(Cliente art){
			repo.actualizarCliente(art);
		}
		
		public IList<Cliente>  listarTodos(){
			return repo.listarTodos();
		}
		
		public Cliente clientePorId(int id){
			return repo.clientePorID(id);
		}
	}
	
}

