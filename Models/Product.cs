using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ECommerce.Models
{
    // Product Model
    public class Product
    {
        // <---------- Model Properties ---------->

        // Key for Product table
        [Key]
        public int ProductId { get; set; }

        // For Name Column
        [Display(Name="Product Name")]
        [Required(ErrorMessage="Product name is Required!")]
        [MinLength(2,ErrorMessage="Product name must be at least two characters in length!")]
        public string Name { get; set; }

        // For Image Column
        [Display(Name="Image Link")]
        [MinLength(10,ErrorMessage="Image URL must be at least 10 characters!")]
        public string Image { get; set; }

        // For Description Column
        [Display(Name="Description")]
        [Required(ErrorMessage="Product description is required!")]
        [MinLength(20,ErrorMessage="Description must be atleast 20 characters in length!")]
        public string Description { get; set; }

        // For Quantity Column
        [Display(Name="Quantity")]
        [Required(ErrorMessage="Product quantity is required")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        [Range(1,int.MaxValue,ErrorMessage="Product quantity must be greater than one!")]
        public int? Quantity { get; set; }

        // Timestamps for data entry
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // <---------- Entity Model References ---------->

        // Many-to-one PK for Product Creator Account
        public int AccountId { get; set; }
        public Account Creator { get; set; }

         // Many-to-many list for Orders
         public List<Order> Customers { get; set; }
    }

    // Order Model
    public class Order
    {
        // <---------- Model Properties ---------->

        // Table Keys

        // Key for Order table
        [Key]
        public int OrderId { get; set; }

        [Required]
        [RegularExpression("([0-9]+)")]
        [Range(1,int.MaxValue)]
        public int? Amount { get; set; }

        // Timestamps for data entry
        public DateTime CreatedAt { get; set ;}
        public DateTime UpdatedAt { get; set; }

        // <---------- Entity Model References ---------->

        // Key for the Account table
        public int AccountId { get; set; }

        // Key for the Product table
        public int ProductId { get; set; }

        // Object for the Account
        public Account Account { get; set; }
        
        // Object for the Product
        public Product Product { get; set; }
    }

    // Product Model class for Update
    public class UpdateProduct
    {
        // For Name Column
        [Display(Name="Name")]
        [MinLength(2,ErrorMessage="Product name must be at least two characters in length!")]
        public string Name { get; set; }

        // For Image Column
        [Display(Name="Image")]
        public string Image { get; set; }

        // For Quantity Column
        [Display(Name="Quantity")]
        [RegularExpression("(^-?[0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int? Quantity { get; set; }

        // For Description Column
        [Display(Name="Description")]
        [MinLength(20,ErrorMessage="Description must be atleast 20 characters in length!")]
        public string Description { get; set; }
    }
}
