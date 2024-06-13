namespace CalculadoraBasica;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Bienvenido ala calculadora básica");
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Elige una operacion:");
        Console.WriteLine("1.[Sumar]:");
        Console.WriteLine("2.[Restar]:");
        Console.WriteLine("3.[Multiplicar]:");
        Console.WriteLine("4.[Dividir]:");

        int opcion= Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
            Operacion suma= new Suma();
            suma.EjecutarOperacion();
            break;

            case 2:
            Operacion resta= new Resta();
            resta.EjecutarOperacion();
            break;

            case 3:
            Operacion multiplicar = new Multiplicar();
            multiplicar.EjecutarOperacion();
            break;

            case 4:
            Operacion dividir = new Dividir();
            dividir.EjecutarOperacion();
            break;

            default:
            Console.WriteLine("Error: Opcion no valida");
            break;


        }


    }
}
