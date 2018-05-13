using System;
using System.Collections.Generic; 
using NHibernate; 
using veterinaria.Entities;

namespace veterinaria.Repository
{
	public class MascotaRepositorio
	{
		ISession sesion;
		
		public MascotaRepositorio()
		{
		}
		
		public void setSession(ISession sesion){
			this.sesion = sesion;
		}
		
		public ISession getSessionFactory(){
			return this.sesion;
		}
		
		public void agregarMascota (Mascota masc){
			getSessionFactory().SaveOrUpdate(masc);
			getSessionFactory().Flush();
		}
		
		public void eliminarMascota (int id){
			IQuery query = getSessionFactory().CreateQuery("delete from Clientes where codigo = :id");
			query.SetParameter("id",id);
			query.ExecuteUpdate();
			getSessionFactory().Flush();
		}
		
		public void actualizarMascota (Mascota masc){
			getSessionFactory().SaveOrUpdate(masc);
			//getSessionFactory().Flush();
		}
		
		public IList<Mascota>  listarTodos(){
			IList<Mascota> lista1 = getSessionFactory().CreateQuery("from Clientes c")
                .List<Mascota>();
			
			return lista1;
		}
		
		public Mascota MascotaPorID(int id){
			IQuery query = getSessionFactory().CreateQuery("from Clientes where codigo = :id");
			query.SetParameter("id",id);
			Mascota mascota = query.UniqueResult<Mascota>();
			
			return mascota;
		}
	}
}
