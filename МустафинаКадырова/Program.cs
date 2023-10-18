using Newtonsoft.Json;
public class Product
{
    public double Weight { get; set; }
    public double Price { get; set; }
    public int Volume { get; set; }
    public string Name { get; set; }
    public bool Fragile { get; set; }

    public Product(double weight, double price, int volume, string name, bool fragile)
    {
        Weight = weight;
        Price = price;
        Volume = volume;
        Name = name;
        Fragile = fragile;
    }

    public string ToJson()
    {
        return JsonConvert.SerializeObject(this);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product(1.5, 15, 100, "Яблоко", false),
            new Product(2.0, 200, 300, "Ваза", true),
            new Product(0.5, 50, 150, "Тарелка", true),
            new Product(0.65, 35, 160, "Багет", false),
            new Product(0.7, 249, 50, "Бокал", true),
            new Product(1.2, 56, 51, "Банка варенья", true),
            new Product(2, 500, 350, "Сыр", false),
            new Product(0.5, 95, 500, "Собачий корм", false),
            new Product(0.25, 5, 50, "Доширак", false),
            new Product(3, 650, 310, "Рыба", false),
        };

        foreach (Product product in products)
        {
            Console.WriteLine($"Наименование");
            Console.WriteLine($"Наименование: {product.Name}, Цена: {product.Price}, Вес: {product.Volume}, Хрупкость: {product.Fragile}");
        }

        string json = JsonConvert.SerializeObject(products);
        File.WriteAllText("products.json", json);
    }
}