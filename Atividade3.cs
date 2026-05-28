
/* O consumo do carro é informado em **km por litro (km/L)**
- A distância é informada em **km**
- O preço do combustível é informado em **R$/litro***/

public static class Atividade3
{

    public static void Executar()
    {
        {
            Console.Write("Distância total da viagem (km): ");
            double distanciaKm = double.Parse(Console.ReadLine()!);

            Console.Write("Consumo do veículo (km/L): ");
            double consumoKmPorLitro = double.Parse(Console.ReadLine()!);

            Console.Write("Preço do combustível (R$/L): ");
            double precoLitro = double.Parse(Console.ReadLine()!);

            double litrosNecessarios = distanciaKm / consumoKmPorLitro;
            double custoTotal = litrosNecessarios * precoLitro;
            double custoPorKm = custoTotal / distanciaKm;

            Console.WriteLine("\n=== Resumo da Viagem ===");
            Console.WriteLine($"Litros necessários: {litrosNecessarios} L");
            Console.WriteLine($"Custo total: R$ {custoTotal}");
            Console.WriteLine($"Custo por km: R$ {custoPorKm}");
        }
    }

}
