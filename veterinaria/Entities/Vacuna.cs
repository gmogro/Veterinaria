using System;

namespace veterinaria.Entities
{
	public class Vacuna 
	{
		private int cod_vac;
		private string nombre;
		private string fechaVac;
		private string fechaproxVac;
		//private int cod_mas;
		
		public virtual int Codigo 
		{
			set
			{
				cod_vac = value;
			}
			get
			{
				return cod_vac;
			}
		}
		
		public virtual string Nombre
		{
			set
			{
				nombre = value;
			}
			get
			{
				return nombre;
			}
		}
		
		public virtual string FechaVac
		{
			set
			{
				fechaVac = value;
			}
			get 
			{
				return fechaVac;
			}
		}
		
		public virtual string FechaproxVac
		{
			set
			{
				fechaproxVac = value;
			}
			
			get 
			{
				return fechaproxVac;
			}
		}
	}
}
