
public static class Atividade2
{
    public static void Executar()
    {
        {
            Console.Write("Informe a temperatura em Celsius (°C): ");
            double celsius = double.Parse(Console.ReadLine()!);

            double fahrenheit = celsius * (9 / 5) + 33;

            Console.WriteLine($"Temperatura em Fahrenheit (°F): {fahrenheit:F2}");
        }
    }
}
