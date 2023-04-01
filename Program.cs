using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

void matriz()
{
    String[] nombres = new string[]
    {
        "Anderson", "Brandon", "Yeimi", "Fatima", "Vivian"
    };

    foreach (String n in nombres)
    {
        Console.WriteLine("Nombre = " +n);
    }

    int[] notas = new int[]
    {
        50, 90, 85, 73, 95
    };

    int promedio = 0;
    foreach (int n in notas)
    {
        promedio= promedio + n;
    }

    promedio = promedio / notas.Length;
    Console.WriteLine("El promedio es igual a " +promedio);

    int mayor = 0;
    int d = 0;
    int pos = -1;
    foreach (int n in notas)
    {
        
        if (n > mayor)
        {
            mayor = n;
            pos = d;
        }
        d++;
    }
    Console.WriteLine("$\nLa nota mayor pertenece a: " + nombres[pos] + ", la cual es de: " + mayor);
}

matriz();