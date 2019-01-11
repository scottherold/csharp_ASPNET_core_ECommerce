using System.Collections.Generic;

namespace ECommerce.Models
{
    // Model bundle for app use
    public class ECommerceBundle
    {
        // Objects
        public Product Product { get; set; }
        public Order Order { get; set; }

        // Linked Lists
        public List<Account> AccountList { get; set; }
        public List<Product> ProductList { get; set; }
        public List<Order> OrderList { get; set; }
    }
}