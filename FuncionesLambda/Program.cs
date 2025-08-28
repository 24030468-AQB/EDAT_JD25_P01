using FuncionesLambda;

internal class Program
{
    private static void Main(string[] args)
    {

            Console.WriteLine("Expresion lambda como funcion");

       // Func<int, int, int> b = (a) => a * 2;

        // int resultado = b(4);

        //Console.WriteLine(resultado);

        //Func<int, int, int>suma = (a,b) => a + b;

        //int resultado = suma(4, 6);

        //Console.WriteLine(resultado);   

        // Func<int, int, int> mayor = (a, b) => 
        // {
        //     if(a>b)
        //     {
        //         return a;
        //     }
        //     else
        //     {
        //         return b;
        //     }
        // };

        //int resultado = mayor (45, 20);

        //Console.WriteLine(resultado);


        var numeros = new List<int> {8,5,9,34,2,26,8 };

        Func<int, bool> ObternerPares = (num) => num%2 == 0;

        var pares = numeros.Where(ObternerPares);

        Console.WriteLine("Hola");






















        //   fixed (byte* pointerTofirst = bytes) ;
        //Persona persona = new Persona();
        // int edad = 18;
        // edad++;
        // edad++;
        //// fixed (byte* pointerTofirst = bytes) 
        // Console.WriteLine("El valor de la variable edad es: "+edad );
        // Console.WriteLine("La direccion de memoria es: {*pointerToFirst} ");
        Console.ReadKey();

    }
}