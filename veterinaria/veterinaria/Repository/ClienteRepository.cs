using System;
using System.Collections.Generic; 
using NHibernate; 
using veterinaria.Entities;

namespace veterinaria.Repository
{
	public class ClienteRepository
	{
		ISession sesion;
		
		public ClienteRepository()
		{
		}
		
		public void setSession(ISession sesion){
			this.sesion = sesion;
		}
		
		public ISession getSessionFactory(){
			return sesion;
		}
		
		public void agregarCliente(Cliente cli){
			getSessionFactory().SaveOrUpdate(cli);
			getSessionFactory().Flush();
		}
		
		public void eliminarCliente(int id){
			IQuery query = getSessionFactory().CreateQuery("delete from Clientes where codigo = :id");
			query.SetParameter("id",id);
			query.ExecuteUpdate();
			getSessionFactory().Flush();
		}
		
		public void actualizarCliente(Cliente cli){
			getSessionFactory().SaveOrUpdate(cli);
			//getSessionFactory().Flush();
		}
		
		public IList<Cliente>  listarTodos(){
			IList<Cliente> lista1 = getSessionFactory().CreateQuery("from Clientes c")
                .List<Cliente>();
			
			return lista1;
		}
		
		public Cliente clientePorID(int id){
			IQuery query = getSessionFactory().CreateQuery("from Clientes where codigo = :id");
			query.SetParameter("id",id);
			Cliente cliente = query.UniqueResult<Cliente>();
			
			return cliente;
		}
	}
}
	


