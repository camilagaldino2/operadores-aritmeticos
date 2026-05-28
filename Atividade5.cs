
public static class Atividade5
{
    public static void Executar()
    {
        Console.WriteLine("Digite o valor da venda:");
        double valorVenda = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite a quantidade:");
        double quantidade = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Insira o percentual:");
        double percentualComissao = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Insira o salário fixo:");
        double salarioFixo = double.Parse(Console.ReadLine()!);

        double totalVendido = valorVenda * quantidade;
        double valorComissao = (totalVendido * percentualComissao) / 100;
        double totalReceber = salarioFixo + valorComissao;

        Console.WriteLine($" O total vendido foi de: {totalVendido:F2}");
        Console.WriteLine($"O valor da comissão foi de: {valorComissao:F2}");
        Console.WriteLine($"O total a receber é: {totalReceber:F2}");

    }
}
