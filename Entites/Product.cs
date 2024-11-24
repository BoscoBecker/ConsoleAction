namespace ConsoleAction.Entites;

public class Product(string name, double price) {
    public string Name { get; set; } = name;
    public double Price { get; set; } = price;

    public override string ToString()
    {
        return $"Name: {name} Price: {Price}";
    }
}