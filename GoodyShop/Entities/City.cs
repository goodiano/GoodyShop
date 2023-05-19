namespace GoodyShop.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Slug { get; set; }
        public Provience Provience { get; set; }
        public int ProvienceId { get; set; }
    }
}
