namespace Iterator
{
    public interface IMenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Vegeterian { get; set; }
        public double Price { get; set; }
    }
}