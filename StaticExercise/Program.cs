namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit to Celcius:");
            Console.WriteLine("Fahrenheit: 32");
            Console.WriteLine("Celcius: " + TempConverter.FahrenheitToCelsius(32));

            Console.WriteLine("Celcius to Fahrenheit:");
            Console.WriteLine("Celcius: 0");
            Console.WriteLine("Fahrenheit: " + TempConverter.CelsiusToFahrenheit(0));
        }
    }
}
