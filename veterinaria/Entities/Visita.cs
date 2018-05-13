using System;

namespace veterinaria.Entities
{
	public class Visita 
	{
		private int codigo;
		private string fecha;
		private string descripcion;
		private string enfermedad;
		//private int cod_mas;
		
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
		
		public virtual string Fecha
		{
			set
			{
				fecha = value;
			}
			
			get
			{
				return fecha;
			}
		}
		
		public virtual string Descripcion
		{
			set
			{
				descripcion = value;
			}
			get
			{
				return descripcion;
			}
		}
		
		public virtual string Enfermedad
		{
			set
			{
				enfermedad = value;
			}
			get
			{
				return enfermedad;
			}
		}
	}
}

