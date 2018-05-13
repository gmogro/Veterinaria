using System;
using System.Collections.Generic; 
using NHibernate; 
using veterinaria.Entities;
namespace veterinaria.Repository
{
	public class VacunaRepositorio 
	{
		ISession sesion;
		
		public VacunaRepositorio()
		{
		}
		
		public void setSession(ISession sesion){
			this.sesion = sesion;
		}
		
		public ISession getSessionFactory(){
			return this.sesion;
		}
		
		public void agregarVacuna (Vacuna vac){
			getSessionFactory().SaveOrUpdate(vac);
			getSessionFactory().Flush();
		}
		
		public void eliminarVacuna (int id){
			IQuery query = getSessionFactory().CreateQuery("delete from Clientes where codigo = :id");
			query.SetParameter("id",id);
			query.ExecuteUpdate();
			getSessionFactory().Flush();
		}
		
		public void actualizarVacuna (Vacuna vac){
			getSessionFactory().SaveOrUpdate(vac);
			getSessionFactory().Flush();
		}
		
		public IList<Vacuna>  listarTodos(){
			IList<Vacuna> lista1 = getSessionFactory().CreateQuery("from Clientes c")
                .List<Vacuna>();
			
			return lista1;
		}
		
		public Vacuna VacunaPorID(int id){
			IQuery query = getSessionFactory().CreateQuery("from Clientes where codigo = :id");
			query.SetParameter("id",id);
			Vacuna vacuna = query.UniqueResult<Vacuna>();
			return vacuna;
		}
	}
}

