using System;

namespace veterinaria.Entities
	
{
	public class Mascota
	{
		private int codigo;
		private string nombre;
		
		public virtual int Codigo 
		{
			set
			{
				codigo = value;
			}
			get 
			{
				return codigo;
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
		
	}
}