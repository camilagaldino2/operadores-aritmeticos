
public static class Atividade4

{
    public static void Executar()
    {
        Console.Write("Digite o valor de x: ");
        double x = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o valor de y: ");
        double y = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"O valor antigo de x é: {x}");
        Console.WriteLine($"O valor antigo de y é: {y}");

        (x, y) = (y, x);

        Console.WriteLine($"O valor de x agora é: {x}");
        Console.WriteLine($"O valor de y agora é: {y}");

    }
}