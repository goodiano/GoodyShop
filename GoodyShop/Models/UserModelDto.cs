using GoodyShop.Entities;

namespace GoodyShop.Models
{
    public class UserModelDto
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Provience Provience { get; set; }
        public string PostCode { get; set; }

    }
}
