using ConstructionAPI.DAL;

namespace ConstructionAPI.Models
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public List<Product> Products { get; set; }

    }
}
