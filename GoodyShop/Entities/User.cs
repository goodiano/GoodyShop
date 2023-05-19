namespace GoodyShop.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Provience Provience { get; set; }
        public int ProvienceId { get; set; }
        public string PostCode { get; set; }
    }
}
