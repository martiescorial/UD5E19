using System;

namespace UD5E19
{
    class Program
    {
        static void Main(string[] args)
        {
			
			string texto = "Introduce un tamaño";
			int[] num = new int[int.Parse(texto)];

			
			fillNumPrim(num, 1, 100);

			mostrarArray(num);

			
			int primoMayor = mayor(num);
			Console.WriteLine("El numero primo más grande es el " + primoMayor);
		}

		public static void fillNumPrim(int[] array, int a, int b)
		{

			int i = 0;

			
			while (i < array.Length)
			{
				Random aleatorio = new Random();
				int num = (aleatorio.Next() * (a - b) + b);
				if (esPrimo(num))
				{
					array[i] = num;
					i++;
				}
			}
		}
		private static bool esPrimo(int num)
		{

			
			if (num <= 1)
			{
				return false;
			}
			else
			{

				       
				int prueba;
				int contador = 0;
				
				prueba = (int)Math.Sqrt(num);
				
				for (; prueba > 1; prueba--)
				{
					if (num % prueba == 0)
					{
						contador += 1;
					}
				}
				return contador < 1;
			}
		}

		public static void mostrarArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine("En el indice " + i + " esta el valor " + array[i]);
			}
		}

		public static int mayor(int[] array)
		{
			int mayor = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > mayor)
				{
					mayor = array[i];
				}
			}

			return mayor;
		}

}
}
