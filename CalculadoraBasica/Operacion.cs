namespace CalculadoraBasica;
public abstract class Operacion
{
    public double Numero1 {get;set;}
    public double Numero2 {get;set;}

    public abstract double Calcular();

    public void EjecutarOperacion()
    {
        try
        {
            Console.WriteLine("Ingrese el primer número:");
            Numero1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            Numero2= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"El resultado es : {Calcular()}");
            
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error:",ex.Message);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Error", ex.Message);
        }
    }
}