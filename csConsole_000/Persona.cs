using System;
namespace csConsole_000
{
	public class Persona
	{
		public Persona( string name, int age, DateTime birthDate )
		{
			this.Nombre = name;
			this.Edad = age;
			this.Cumpleanos = birthDate;
		}

		private string Nombre;
		private int Edad;
		private DateTime Cumpleanos;

		public string PositionInTheCompany { get; set; }

		public string getNombre()
        {
			return this.Nombre;
        }

		public int getEdad()
        {
			return this.Edad;
        }

		public DateTime getCumpleanos()
        {
			return this.Cumpleanos;
        }



	}
}

