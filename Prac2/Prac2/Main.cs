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

			int opc = Convert.ToInt32(Console.ReadLine());
			switch (opc) {

			case 1:
				{	
					
				}break;
			
			default : Console.WriteLine("No válido");
				break;


			}
		}

	}
}
