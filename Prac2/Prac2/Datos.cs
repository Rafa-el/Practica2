using System;

namespace Prac2
{
	public class Datos
	{
		public Datos ()
		{
		}

		public string inicia(){
			int h=DateTime.Now.Hour;
			int m=DateTime.Now.Minute;
			int s=DateTime.Now.Second;

			return h + ":" + m + ":" + s;
		}
	}
}

