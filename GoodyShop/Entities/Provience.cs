namespace GoodyShop.Entities
{
    public class Provience
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Slug { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
