using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ECommerce.Controllers
{
    // Route for the products controller
    [Route("Products")]
    public class ProductsController : Controller
    {
        // <---------- Dependency Injection ---------->

        // create DBContext Object
        private ECommerceContext dbContext;

        // Inject Context service into the class constructor

        public ProductsController(ECommerceContext context)
        {
            dbContext = context;
        }

        // <---------- Accounts GET routes ---------->

        // RESTful route for Product Dashboard
        public IActionResult Index()
        {
            // Retrieves data from ession to qury as an event handler.
            // Checks to see if the Session data is present to prevent penetration
            string loggedIn = HttpContext.Session.GetString("LoggedIn");
            int? accountId = HttpContext.Session.GetInt32("AccountId");
            string email = HttpContext.Session.GetString("Email");

            // if 'loggedIn' not present, proceed to default view
            if(loggedIn == null)
            {
                return RedirectToAction("Index", "Accounts");
            }

            // Else checks to see if the account is in the DB
            else
            {
                // Creates a new account object using the session email
                Account accountInDb = dbContext.Accounts.FirstOrDefault(a => a.Email == email);

                // If email is not in the DB, kill Session and returns the View
                if(accountInDb == null)
                {
                    HttpContext.Session.Clear();
                    TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                    return RedirectToAction("Index", "Accounts");
                }

                // Else checks to see if the session ID matches the queried Account ID for the
                // ID in session
                else
                {
                    // If the ID's don't match, kills the session and returns the View
                    if(accountInDb.AccountId != (int)accountId)
                    {
                        HttpContext.Session.Clear();
                        TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                        return RedirectToAction("Index", "Accounts");
                    }

                    // Else undersatnds that the user is 'logged in' and moves the user to the
                    // Index in the Products controller
                    else
                    {
                        // Creates a ViewBag variable for NavBar display
                        ViewBag.LoggedIn = true;

                        // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                        ViewBag.AccountId = (int)accountId;

                        // Creates a bundle object for displaying multiple object lists on the View
                        var dashboardBundle = new ECommerceBundle();

                        // List for Accounts (Limited to most recent 3)
                        dashboardBundle.AccountList = dbContext.Accounts
                            .Include(a => a.CreatedProducts)
                            .Include(a => a.Orders)
                            .ThenInclude(o => o.Product)
                            .OrderByDescending(a => a.CreatedAt)
                            .Take(3)
                            .ToList();

                        // List for Products (Limited to most recent 4)
                        dashboardBundle.ProductList = dbContext.Products
                            .Include(p => p.Creator)
                            .Include(p => p.Customers)
                            .ThenInclude(o => o.Account)
                            .OrderByDescending(a => a.CreatedAt)
                            .Take(4)
                            .ToList();

                        // List for Orders (Limited to most recent 3)
                        dashboardBundle.OrderList = dbContext.Orders
                            .Include(o => o.Account)
                            .Include(o => o.Product)
                            .OrderByDescending(o => o.CreatedAt)
                            .Take(3)
                            .ToList();

                        return View(dashboardBundle);
                    }
                }
            }
        }

        [HttpGet("Products")]
        // Route for New products/Products list
        public IActionResult Products()
        {
             // Retrieves data from ession to qury as an event handler.
            // Checks to see if the Session data is present to prevent penetration
            string loggedIn = HttpContext.Session.GetString("LoggedIn");
            int? accountId = HttpContext.Session.GetInt32("AccountId");
            string email = HttpContext.Session.GetString("Email");

            // if 'loggedIn' not present, proceed to default view
            if(loggedIn == null)
            {
                return RedirectToAction("Index", "Accounts");
            }

            // Else checks to see if the account is in the DB
            else
            {
                // Creates a new account object using the session email
                Account accountInDb = dbContext.Accounts.FirstOrDefault(a => a.Email == email);

                // If email is not in the DB, kill Session and returns the View
                if(accountInDb == null)
                {
                    HttpContext.Session.Clear();
                    TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                    return RedirectToAction("Index", "Accounts");
                }

                // Else checks to see if the session ID matches the queried Account ID for the
                // ID in session
                else
                {
                    // If the ID's don't match, kills the session and returns the View
                    if(accountInDb.AccountId != (int)accountId)
                    {
                        HttpContext.Session.Clear();
                        TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                        return RedirectToAction("Index", "Accounts");
                    }

                    // Else undersatnds that the user is 'logged in' and moves the user to the
                    // Products list page
                    else
                    {
                        // Creates a ViewBag variable for NavBar display
                        ViewBag.LoggedIn = true;

                        // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                        ViewBag.AccountId = (int)accountId;

                        // Creates a bundle object for displaying multiple object lists on the View
                        var productBundle = new ECommerceBundle();

                        // List for Products
                        productBundle.ProductList = dbContext.Products
                            .Include(p => p.Creator)
                            .Include(p => p.Customers)
                            .ThenInclude(o => o.Account)
                            .OrderByDescending(a => a.CreatedAt)
                            .ToList();

                        return View(productBundle);
                    }
                }
            }
        }

        // RESTful route showing an individual Product
        [HttpGet("{id}")]
        public IActionResult Show(int id)
        {

            // Retrieves data from ession to qury as an event handler.
            // Checks to see if the Session data is present to prevent penetration
            string loggedIn = HttpContext.Session.GetString("LoggedIn");
            int? accountId = HttpContext.Session.GetInt32("AccountId");
            string email = HttpContext.Session.GetString("Email");

            // if 'loggedIn' not present, proceed to default view
            if(loggedIn == null)
            {
                return RedirectToAction("Index");
            }

            // Else checks to see if the account is in the DB
            else
            {
                // Creates a new account object using the session email
                Account accountInDb = dbContext.Accounts.FirstOrDefault(a => a.Email == email);

                // If email is not in the DB, kill Session and returns the View
                if(accountInDb == null)
                {
                    HttpContext.Session.Clear();
                    TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                    return RedirectToAction("Index");
                }

                // Else checks to see if the session ID matches the queried Account ID for the
                // ID in session
                else
                {
                    // If the ID's don't match, kills the session and returns the View
                    if(accountInDb.AccountId != (int)accountId)
                    {
                        HttpContext.Session.Clear();
                        TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                        return RedirectToAction("Index");
                    }

                    // Else undersatnds that the user is 'logged in' and queries the DB for the
                    // Account and the associated Products/Orders related to that Account
                    else
                    {
                         // Creates a ViewBag variable for NavBar display
                        ViewBag.LoggedIn = true;

                        // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                        ViewBag.AccountId = (int)accountId;

                        var productBundle = new ECommerceBundle();
                        
                        // Creates a new ProductBundle for the Show View
                        productBundle.Product = dbContext.Products
                            .Include(p => p.Creator)
                            .Include(p => p.Customers)
                            .ThenInclude(o => o.Account)
                            .FirstOrDefault(p => p.ProductId == id);

                        // Creates a reference for the Update route for Products
                        ViewBag.ProductId = productBundle.Product.ProductId;

                        return View(productBundle);
                    }
                }
            }
        }

        // <---------- Accounts GET routes ---------->
        
        // RESTful route for creating a new Product
        [HttpPost("Create")]
        public IActionResult Create(Product product)
        {
            // The added security measures on the post route is to ensure no
            // one adds a Product with a different User ID than what the one 'logged in'

            string loggedIn = HttpContext.Session.GetString("LoggedIn");
            int? accountId = HttpContext.Session.GetInt32("AccountId");
            string email = HttpContext.Session.GetString("Email");

            // if 'loggedIn' not present, proceed to default view
            if(loggedIn == null)
            {
                return RedirectToAction("Index", "Accounts");
            }

            // Else checks to see if the account is in the DB
            else
            {
                // Creates a new account object using the session email
                Account accountInDb = dbContext.Accounts.FirstOrDefault(a => a.Email == email);

                // If email is not in the DB, kill Session and returns the View
                if(accountInDb == null)
                {
                    HttpContext.Session.Clear();
                    TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                    return RedirectToAction("Index", "Accounts");
                }

                // Else checks to see if the session ID matches the queried Account ID for the
                // ID in session
                else
                {
                    // If the ID's don't match, kills the session and returns the View
                    if(accountInDb.AccountId != (int)accountId)
                    {
                        HttpContext.Session.Clear();
                        TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                        return RedirectToAction("Index", "Accounts");
                    }

                    // Else understands that the user is 'logged in' and moves the user to the
                    // Index in the Products controller
                    else
                    {
                       // Checks to see if all the data fields were completed
                       if(ModelState.IsValid)
                       {
                           // Updates the DateTime values for the DB Entry
                           product.CreatedAt = DateTime.Now;
                           product.UpdatedAt = DateTime.Now;

                           // Updates the UserId for the "Creator"
                           product.AccountId = (int)accountId;

                           if(product.Image == null)
                           {
                               product.Image = "https://via.placeholder.com/100";
                           }

                           dbContext.Products.Add(product);
                           dbContext.SaveChanges();

                           return RedirectToAction("Show", new{id = product.ProductId});
                       }

                       // If not valid, return errors
                       else
                       {
                           // Creates a ViewBag variable for NavBar display
                        ViewBag.LoggedIn = true;

                        // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                        ViewBag.AccountId = (int)accountId;

                        // Creates a new ProductBundle for the Products View

                        var productBundle = new ECommerceBundle();

                        productBundle.ProductList = dbContext.Products
                            .Include(p => p.Creator)
                            .Include(p => p.Customers)
                            .ThenInclude(o => o.Account)
                            .OrderByDescending(a => a.CreatedAt)
                            .ToList();

                        return View("Products", productBundle);
                       }
                    }
                }
            }
        }

        // RESTful route for updating a Product
        [HttpPost("Update/{id}")]
        public IActionResult Update(UpdateProduct submission, int id)
        {
            // The added security measures on the post route is to ensure no
            // one adds a Product with a different User ID than what the one 'logged in'

            string loggedIn = HttpContext.Session.GetString("LoggedIn");
            int? accountId = HttpContext.Session.GetInt32("AccountId");
            string email = HttpContext.Session.GetString("Email");

            // if 'loggedIn' not present, proceed to default view
            if(loggedIn == null)
            {
                return RedirectToAction("Index", "Accounts");
            }

            // Else checks to see if the account is in the DB
            else
            {
                // Creates a new account object using the session email
                Account accountInDb = dbContext.Accounts.FirstOrDefault(a => a.Email == email);

                // If email is not in the DB, kill Session and returns the View
                if(accountInDb == null)
                {
                    HttpContext.Session.Clear();
                    TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                    return RedirectToAction("Index", "Accounts");
                }

                // Else checks to see if the session ID matches the queried Account ID for the
                // ID in session
                else
                {
                    // If the ID's don't match, kills the session and returns the View
                    if(accountInDb.AccountId != (int)accountId)
                    {
                        HttpContext.Session.Clear();
                        TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                        return RedirectToAction("Index", "Accounts");
                    }

                    // Else understands that the user is 'logged in' and moves the user to the
                    // Index in the Products controller
                    else
                    {
                        // Checks to see if all the data fields were completed
                        if(ModelState.IsValid)
                        {
                            // Create a new product object for updating
                            Product product = dbContext.Products.FirstOrDefault(p => p.ProductId == id);

                            // Updates the DateTime values for the DB Entry
                            product.UpdatedAt = DateTime.Now;

                            // If the ID's don't match, log the user out and clear session
                            if(product.AccountId != accountId)
                            {
                                TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                                return RedirectToAction("Index", "Accounts");
                            }

                            // Else, check fields to update
                            else
                            {
                                // Checks to see if Name field is populated
                                if(submission.Name != null)
                                {
                                    // if not null, sets the DB Name field as the submission field
                                    product.Name = submission.Name;
                                }
                                
                                // Checks to see if Image field is populated
                                if(submission.Image != null)
                                {
                                    // if not null, sets the DB Image field as the submission field
                                    product.Image = submission.Image;
                                }

                                // Checks to see if Quantity field is populated
                                if(submission.Quantity != null)
                                {
                                    // if not null, checks to see if Quantity reduces the Product's amount below 0
                                    if(product.Quantity + (int)submission.Quantity >= 0)
                                    {
                                        // If greater than or equal 0, set the new Product Quantity
                                        product.Quantity = product.Quantity + (int)submission.Quantity;
                                    }

                                    // Else, throw a model error and return the View
                                    else
                                    {
                                        // ModelState Quantity Error
                                        ModelState.AddModelError("Quantity", "You cannot reduce the product's quantity below 0 units!");
                                        
                                        // Creates a ViewBag variable for NavBar display
                                        ViewBag.LoggedIn = true;

                                        // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                                        ViewBag.AccountId = (int)accountId;

                                        var productBundle = new ECommerceBundle();
                                    
                                        // Creates a new ProductBundle for the Show View
                                        productBundle.Product = dbContext.Products
                                            .Include(p => p.Creator)
                                            .Include(p => p.Customers)
                                            .ThenInclude(o => o.Account)
                                            .FirstOrDefault(p => p.ProductId == id);

                                        // Creates a reference for the Update route for Products
                                        ViewBag.ProductId = productBundle.Product.ProductId;

                                        return View("Show", productBundle);
                                    }
                                }

                                // Checks to see if Quantity field is populated

                                if(submission.Description != null)
                                {
                                    // if not null, sets the DB Description field as the submission field
                                    product.Description = submission.Description;
                                }

                                // Updates the DB and returns the Show View for the product
                                dbContext.SaveChanges();
                                return RedirectToAction("Show", new{id = product.ProductId});
                            }
                        }

                        // If not valid, return errors
                        else
                        {
                            // Creates a ViewBag variable for NavBar display
                            ViewBag.LoggedIn = true;

                            // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                            ViewBag.AccountId = (int)accountId;

                            var productBundle = new ECommerceBundle();
                        
                            // Creates a new ProductBundle for the Show View
                            productBundle.Product = dbContext.Products
                                .Include(p => p.Creator)
                                .Include(p => p.Customers)
                                .ThenInclude(o => o.Account)
                                .FirstOrDefault(p => p.ProductId == id);

                            // Creates a reference for the Update route for Products
                            ViewBag.ProductId = productBundle.Product.ProductId;

                            return View("Show", productBundle);
                        }
                    }
                }
            }
        }

        // RESTful route for deleting a product
        [HttpPost("Destroy/{id}")]
        public IActionResult Destroy(int id)
        {
            // Retrieves data from ession to qury as an event handler.
            // Checks to see if the Session data is present to prevent penetration
            string loggedIn = HttpContext.Session.GetString("LoggedIn");
            int? accountId = HttpContext.Session.GetInt32("AccountId");
            string email = HttpContext.Session.GetString("Email");

            // if 'loggedIn' not present, proceed to default view
            if(loggedIn == null)
            {
                return RedirectToAction("Index", "Accounts");
            }

            // Else checks to see if the account is in the DB
            else
            {
                // Creates a new account object using the session email
                Account accountInDb = dbContext.Accounts.FirstOrDefault(a => a.Email == email);

                // If email is not in the DB, kill Session and returns the View
                if(accountInDb == null)
                {
                    HttpContext.Session.Clear();
                    TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                    return RedirectToAction("Index", "Accounts");
                }

                // Else checks to see if the session ID matches the queried Account ID for the
                // ID in session
                else
                {
                    // If the ID's don't match, kills the session and returns the View
                    if(accountInDb.AccountId != (int)accountId)
                    {
                        HttpContext.Session.Clear();
                        TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                        return RedirectToAction("Index", "Accounts");
                    }

                    // Else undersatnds that the user is 'logged in' and moves the user to the
                    // Index in the Products controller
                    else
                    {
                        // Create queries to the DB for Product and Order objects
                        Product deleteProduct = dbContext.Products.FirstOrDefault(p => p.ProductId == id);
                        var deleteOrders = dbContext.Orders.Where(o => o.ProductId == id);

                        // If product query is null, redirect to the show page
                        if(deleteProduct == null)
                        {
                            return RedirectToAction("Show", "Accounts", new{id = accountId});
                        }

                        // Else Checks queried Product AccountId against the AccountId in Session
                        else
                        {
                            // If the ID's don't match, log the user out and clear session
                            if(deleteProduct.AccountId != accountId)
                            {
                                TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                                return RedirectToAction("Index", "Accounts");
                            }

                            // Else run the queries to Delete both the Product and its Orders
                            else
                            {
                                // If the Product has any orders, delete each order from the DB
                                if(deleteOrders.Count() > 0)
                                {
                                    foreach(var order in deleteOrders)
                                    {
                                        dbContext.Orders.Remove(order);
                                    }
                                }

                                // Delete the product from the DB
                                dbContext.Products.Remove(deleteProduct);
                                dbContext.SaveChanges();

                                return RedirectToAction("Show", "Accounts", new{id = accountId});
                            }
                        }
                    }
                }
            }
        }

        // Route for filtering the Product list
        [HttpPost("Filter")]
        public IActionResult Filter(string searchString)
        {
            // The added security measures on the post route is to ensure no
            // one adds a Product with a different User ID than what the one 'logged in'

            string loggedIn = HttpContext.Session.GetString("LoggedIn");
            int? accountId = HttpContext.Session.GetInt32("AccountId");
            string email = HttpContext.Session.GetString("Email");

            // if 'loggedIn' not present, proceed to default view
            if(loggedIn == null)
            {
                return RedirectToAction("Index", "Accounts");
            }

            // Else checks to see if the account is in the DB
            else
            {
                // Creates a new account object using the session email
                Account accountInDb = dbContext.Accounts.FirstOrDefault(a => a.Email == email);

                // If email is not in the DB, kill Session and returns the View
                if(accountInDb == null)
                {
                    HttpContext.Session.Clear();
                    TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                    return RedirectToAction("Index", "Accounts");
                }

                // Else checks to see if the session ID matches the queried Account ID for the
                // ID in session
                else
                {
                    // If the ID's don't match, kills the session and returns the View
                    if(accountInDb.AccountId != (int)accountId)
                    {
                        HttpContext.Session.Clear();
                        TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                        return RedirectToAction("Index", "Accounts");
                    }

                    // Else understands that the user is 'logged in' and applies filter
                    // logic before returning the Products Index View
                    else
                    {
                        // Creates a ViewBag variable for NavBar display
                        ViewBag.LoggedIn = true;

                        // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                        ViewBag.AccountId = (int)accountId;

                        // Creates a ViewBag object to designate the page is Filtered
                        ViewBag.Filtered = true;

                        // Creates a new ProductBundle for the Products View
                        var productBundle = new ECommerceBundle();

                        productBundle.ProductList = dbContext.Products
                            .Include(p => p.Creator)
                            .Include(p => p.Customers)
                            .ThenInclude(o => o.Account)
                            .Where(p => p.Name.Contains(searchString))
                            .OrderByDescending(a => a.CreatedAt)
                            .ToList();

                        return View("Products", productBundle);
                    }
                }
            }
        }
    }
}