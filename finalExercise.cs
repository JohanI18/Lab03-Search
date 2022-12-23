using System.Diagnostics;

namespace Lab03_search;
class FinalExercise
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio final");
        int[] A = new int[100];
        Random rnd = new Random();
        int aciertos = 0;
        for (int i = 0; i < 100; i++)
        {
            A[i] = rnd.Next(1, 201);
        }
        int n = A.Length;
        for (int i = 0; i < 50; i++)
        {
            int intsearch = rnd.Next(1, 201);
            if (linealSearchID(A, n, intsearch) != -1)
                aciertos++;
        }
        int fallos = 50 - aciertos;
        Console.WriteLine("El numero de busqueda con exito es de {0}", aciertos);
        Console.WriteLine("El numero de busqueda fallidas es de {0}", fallos);
        Console.WriteLine("El porcentaje de exito de búsquedas es de {0} %", (aciertos*100/50));
       Console.WriteLine("El porcentaje de fallo de búsquedas es de {0} %", (fallos*100/50));
       Array.Sort(A);
       printArray(A);
    }

    static int linealSearchID(int[] A, int n, int clave)
    {
        int i;
        for (i = 0; i < n; i++)
        {
            if (A[i] == clave)
                return i;
        }
        return -1;
    }

    public static void printArray(int[] A)
    {
        Console.Write("A = {");
        foreach (int i in A)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("}");
    }
}