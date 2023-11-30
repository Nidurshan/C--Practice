namespace OOP.Classes
{

    public class Vehicle
    {

        public string Name { get; set; } = "";
        public string Model { get; set; } = "";
        public int Price { get; set; } = 0;
        public string Color { get; set; } = "";

        public Vehicle(string name, string model)
        {
            Console.WriteLine($"I'm a {model} {name}");
        }

        public Vehicle(string name, string model, int price, string color)
        {
            Name = name;
            Model = model;
            Price = price;
            Color = color;
        }

        public string GetName()
        {
            Console.WriteLine($"This is a {Name}.");
            return Name;
        }

        public void GetModel()
        {
            Console.WriteLine($"This is a {Model} {Name}.");
        }

        public int GetPrice()
        {
            Console.WriteLine($"It's price is {Price}.");
            return Price;
        }

        public void GetColor()
        {
            Console.WriteLine($"This is a {Color} color {Name}.");
        }
    }
}