using System;
using System.Collections.Generic;

namespace veterinaria.Entities
{
	
	public class Cliente
	{
		private int codigo;
		private string nombre;
		
		public virtual int Codigo{
			get{return codigo;}
			set{codigo = value;}
		}	
		public virtual string Nombre{
			get{return nombre;}
			set{nombre = value;}
		}
	}
}

