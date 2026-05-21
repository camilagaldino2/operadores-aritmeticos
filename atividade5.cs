
public static class atividade5
{
    public static void Executar()
    {
        Console.WriteLine("Informe o valor da venda:");
        double valorVenda = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe a quantidade:");
        double quantidade = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o percentual:");
        double percentualComissao = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o salário fixo:");
        double salarioFixo = double.Parse(Console.ReadLine()!);

        double totalVendido = valorVenda * quantidade;
        double valorComissao = (totalVendido * percentualComissao) / 100;
        double totalReceber = salarioFixo + valorComissao;

        Console.WriteLine($"Total vendido {totalVendido:F2}");
        Console.WriteLine($"Valor da comissão {valorComissao:F2}");
        Console.WriteLine($"Total a receber {totalReceber:F2}");

    }
}