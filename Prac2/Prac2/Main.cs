using System;

namespace Prac2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Menu");
			Console.WriteLine ("1. Reloj");
			Console.WriteLine ("2. Cronómetro");
			Console.Write ("Seleccione una opcion: ");
			Datos ob=new Datos();

			int opc = Convert.ToInt32(Console.ReadLine());
			switch (opc) {

			case 1:
				{	
					Console.WriteLine(ob.inicia());
				}break;
			
			case 2:
				{
					
				}break;

			
			default : Console.WriteLine("No válido");
				break;
			}
		}
	}
}
