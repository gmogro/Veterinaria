using System;
using System.Collections.Generic; 
using NHibernate; 
using veterinaria.Entities;

namespace veterinaria.Repository
{
	public class VisitaRepositorio
	{
		ISession sesion;
		
		public VisitaRepositorio()
		{
		}
		
		public void setSession(ISession sesion){
			this.sesion = sesion;
		}
		
		public ISession getSessionFactory(){
			return this.sesion;
		}
		
		public void agregarVisita (Visita vis){
			getSessionFactory().SaveOrUpdate(vis);
			getSessionFactory().Flush();
		}
		
		public void eliminarVisita (int id){
			IQuery query = getSessionFactory().CreateQuery("delete from Clientes where codigo = :id");
			query.SetParameter("id",id);
			query.ExecuteUpdate();
			getSessionFactory().Flush();
		}
		
		public void actualizarVisita (Visita vis){
			getSessionFactory().SaveOrUpdate(vis);
			getSessionFactory().Flush();
		}
		
		public IList<Visita>  listarTodos(){
			IList<Visita> lista1 = getSessionFactory().CreateQuery("from Clientes c")
                .List<Visita>();
			
			return lista1;
		}
		
		public Visita VisitaPorID(int id){
			IQuery query = getSessionFactory().CreateQuery("from Clientes where codigo = :id");
			query.SetParameter("id",id);
			Visita visita = query.UniqueResult<Visita>();
			
			return visita;
		}
	}
}

