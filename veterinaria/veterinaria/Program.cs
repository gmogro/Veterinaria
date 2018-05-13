/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 07/05/2018
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using veterinaria.Entities;
using veterinaria.Repository;
using veterinaria.Services;
using NHibernate.Cfg;
using NHibernate;
using System.Linq;

namespace veterinaria
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Configuration cfg = new Configuration(); 
			cfg.Configure("hibernate.cfg.xml");
			
			ISessionFactory sessiones = cfg.BuildSessionFactory(); 
			ISession sesion = sessiones.OpenSession();
			
			ClienteServicio servicio = new ClienteServicio();
			
			servicio.setSession(sesion);
			
			Cliente cliente = new Cliente();
			
			cliente.Nombre= "guillermo";
			
			
			servicio.agregarCliente(cliente);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}