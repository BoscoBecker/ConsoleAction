using ConsoleAction.Entites;

namespace ConsoleAction {
    internal static class Program {
        private static void Main() {
            var list = new List<Product>
            {
                new Product("TV", 1000.00),
                new Product("TV 4K", 2000.00),
                new Product("Mouse", 900.00)
            };
            list.ForEach(UpdatePrice);  
            // 🤣 Others way 🤣
            // Action<Product> p = p => { p.Price += p.Price * 0.1; };  = Amazing 😍😍😍
            // list.ForEach( p.Price += p.Price * 0.1; );               = Amazing 😍😍😍
            foreach (var product in list) {
                Console.WriteLine(product);
            }
        }

        private static void UpdatePrice(Product p) => p.Price += (p.Price * 0.1);
    }
}