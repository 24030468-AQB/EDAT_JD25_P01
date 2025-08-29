internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Complejidad de algoritmos\n");
        //Console.WriteLine("Complejidad Big O(1)");

        //var nombres = new List<String>() /*{ " Ileny", "Alondra","Juan","Alejandro","Karla" }*/;

        //var primero = (List<String> arreglo) => arreglo != null && arreglo.Count > 0 ? 

        //            arreglo[0] : "lista vacia";

        //Console.WriteLine(primero(nombres));


        Console.WriteLine("Complejidad Big O(n)");

        var numeros = new List<int>() {45,22,53,500,2000,10000,0,1 };

        var NumeroMayor = (List<int> arreglo) => 
        {
            if(arreglo == null || arreglo.Count == 0)
            {
                return 0;
            }
            
            
                int mayor = arreglo[0];
                for(int i = 0; i < arreglo.Count; i++) 
                {
                    if (arreglo[i] > mayor )
                    {
                        mayor = arreglo[i];
                    }
                }

            return mayor;
        };

        int may = NumeroMayor(numeros);
        Console.WriteLine("El numero mayor es: " + may);

        Console.ReadKey();
    }
}