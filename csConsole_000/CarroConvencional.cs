using System;
namespace csConsole_000
{
	public class CarroConvencional: IAutomovil
	{
		public CarroConvencional()
		{
		}

        public void acelerar()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Acelerando ... ");
        }

        public void frenar()
        {
            Console.WriteLine("Frenando ... ");
        }

        public void girarDerecha()
        {
            Console.WriteLine("Girando a la derecha ... ");
        }

        public void girarIzquierda()
        {
            Console.WriteLine("Girando a la izquierda ... ");
        }
    }
}

