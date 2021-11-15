namespace Iterator
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Vegeterian { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Vegeterian = vegeterian;
            this.Price = price;
        }
    }
}