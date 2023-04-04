using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

try
{
    void matriz()
    {
        int cantidad;
        Console.Write("Buen día. Ingrese la cantidad de nombres que quiere ingresar junto con su nota: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        if (cantidad <= 0)
        {
            Console.WriteLine("Bien, no hay datos que ingresar entonces.");
        }
        else
        {
            String[] nombres = new string[cantidad];
            int[] notas = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("\nIngresa el nombre: ");
                nombres[i] = Console.ReadLine();
                Console.Write("Ingresa la nota de " + nombres[i] + ": ");
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            int j = 0;

            foreach (String n in nombres)
            {
                Console.Write("\nNombre = " + n);
                Console.WriteLine(" | Nota = " + notas[j]);
                j++;
            }

            int promedio = 0;
            foreach (int n in notas)
            {
                promedio = promedio + n;
            }

            promedio = promedio / notas.Length;
            Console.WriteLine("\nEl promedio es igual a " + promedio);

            int mayor = 0, menor = 101;
            int d = 0, d2 = 0;
            int pos = -1, pos2 = -1;
            foreach (int n in notas)
            {

                if (n > mayor)
                {
                    mayor = n;
                    pos = d;
                }
                d++;
            }

            foreach (int n in notas)
            {

                if (n < menor)
                {
                    menor = n;
                    pos2 = d2;
                }
                d2++;
            }
            Console.WriteLine("La nota mayor pertenece a: " + nombres[pos] + ", la cual es de: " + mayor);
            Console.WriteLine("La nota menor pertenece a: " + nombres[pos2] + ", la cual es de: " + menor);
        }
    }

    matriz();

}
catch (Exception ex)
{
    Console.WriteLine("\nUps, prueba con otro número.");
    Console.Write("La excepción es: " + ex.Message);
}