using PolymorphismEx.Entities;

Console.Write("Quantos produtos serão registrados? ");
int n = int.Parse(Console.ReadLine());

List<Product> products = new();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Dados do {i + 1}o produto:");
    Console.Write("Produdo comum, importado ou usado (c/i/u)? ");
    char ans = char.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    string name = Console.ReadLine();

    Console.Write("Preço: ");
    double price = double.Parse(Console.ReadLine());

    if (ans == 'i')
    {
        Console.Write("Taxa de importação: ");
        double customFee = double.Parse(Console.ReadLine());

        products.Add(new ImportedProduct(name, price, customFee));
    }
    else if (ans == 'u')
    {
        Console.Write("Data de fabricação (MM/DD/AAAA): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

        products.Add(new UsedProduct(name, price, manufactureDate));
    }
    else
    {
        products.Add(new Product(name, price));
    }
}

Console.WriteLine("Produtos:");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}
