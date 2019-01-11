using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ECommerce.Controllers
{
    // Route for the Orders controller
    [Route("Orders")]
    public class OrdersController : Controller
    {
        // <---------- Dependency Injection ---------->

        // create DBContext Object
        private ECommerceContext dbContext;

        // Inject Context service into the class constructor

        public OrdersController(ECommerceContext context)
        {
            dbContext = context;
        }

        // <---------- Orders GET routes ---------->
       
         // RESTful route showing an individual Account
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
                        
                        // Query the DB for the complete Order object
                        Order order = dbContext.Orders
                            .Include(o => o.Account)
                            .Include(o => o.Product)
                            .ThenInclude(p => p.Creator)
                            .FirstOrDefault(o => o.OrderId == id);

                        // Creates a reference for the Update route for Orders
                        ViewBag.OrderId = order.OrderId;

                        return View(order);
                    }
                }
            }
        }
       
        // <---------- Orders POST routes ---------->
        
        // RESTful route for creating a new Order
        [HttpPost("Create")]
        public IActionResult Create(Order order)
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
                            order.CreatedAt = DateTime.Now;
                            order.UpdatedAt = DateTime.Now;

                            // Updates the UserId for the "Creator"
                            order.AccountId = (int)accountId;

                            dbContext.Orders.Add(order);

                            // Subtracts the Order Amount from the Product Quantity
                            var productOrder = dbContext.Products
                                .Where(p => p.ProductId == order.ProductId)
                                .FirstOrDefault();

                            // Subtracts the Order Amount from the Product Quantity
                            productOrder.Quantity = productOrder.Quantity - order.Amount;
                            dbContext.SaveChanges();

                           return RedirectToAction("Show", "Products", new{id = order.ProductId});
                        }

                        // If not valid, return errors
                        else
                        {
                            // Creates a ViewBag variable for NavBar display
                            ViewBag.LoggedIn = true;

                            // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                            ViewBag.AccountId = (int)accountId;

                            // ViewBag for general error (as in attempting to change the Order.Amount via Inspect Element)
                            // Cannot return a View from another controller with a model object
                            ViewBag.InvalidAction = "Your selection is Invalid, please select an amount from the list";

                            // Creates a new ProductBundle for the Show View
                            var productBundle = new ECommerceBundle();

                            productBundle.Product = dbContext.Products
                                .Include(p => p.Creator)
                                .Include(p => p.Customers)
                                .ThenInclude(o => o.Account)
                                .FirstOrDefault(p => p.ProductId == order.ProductId);

                            return View("~/Views/Products/Show.cshtml", productBundle);
                        }
                    }
                }
            }
        }

        // RESTful route for updating an Order
        [HttpPost("Update/{id}")]
        public IActionResult Update(Order submission, int id)
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
                            Order order = dbContext.Orders.FirstOrDefault(o => o.OrderId == id);

                            // Updates the DateTime values for the DB Entry
                            order.UpdatedAt = DateTime.Now;

                            // If the ID's don't match, log the user out and clear session
                            if(order.AccountId != accountId)
                            {
                                TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                                return RedirectToAction("Index", "Accounts");
                            }

                            // Else, if Order submission Amount == to Order DB Amount, return the View
                            else
                            {
                                if(submission.Amount == order.Amount)
                                {
                                    // Creates a ViewBag variable for NavBar display
                                    ViewBag.LoggedIn = true;

                                    // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                                    ViewBag.AccountId = (int)accountId;

                                    // Query the DB for the complete Order object
                                    order = dbContext.Orders
                                        .Include(o => o.Account)
                                        .Include(o => o.Product)
                                        .ThenInclude(p => p.Creator)
                                        .FirstOrDefault(o => o.OrderId == id);

                                    return View("Show", order);
                                }

                                // Else, if Order submission amount > the Order DB Amount, subtract from the Product's Quantity
                                else
                                {
                                    if(submission.Amount > order.Amount)
                                    {
                                        // Create Product object to adjust quantity by Order Amount
                                        Product product = dbContext.Products.FirstOrDefault(p => p.ProductId == order.ProductId);                                    

                                        product.Quantity = product.Quantity - (submission.Amount - order.Amount);

                                        // Update Order Amount in DB

                                        order.Amount = submission.Amount;

                                        // Updates the DB and returns the Show View for the product
                                        dbContext.SaveChanges();
                                        return RedirectToAction("Show", new{id = order.OrderId});
                                    }

                                    // Else, if Order submission amount < the Order DB Amount, add to the Product's Quantity
                                    else
                                    {
                                        // Create Product object to adjust quantity by Order Amount
                                        Product product = dbContext.Products.FirstOrDefault(p => p.ProductId == order.ProductId);                                    

                                        product.Quantity = product.Quantity + (order.Amount - submission.Amount);

                                        // Update Order Amount in DB

                                        order.Amount = submission.Amount;

                                        // Updates the DB and returns the Show View for the product
                                        dbContext.SaveChanges();
                                        return RedirectToAction("Show", new{id = order.OrderId});
                                    }
                                }
                            }
                        }

                        // If not valid, return errors
                        else
                        {
                            // Creates a ViewBag variable for NavBar display
                            ViewBag.LoggedIn = true;

                            // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                            ViewBag.AccountId = (int)accountId;

                            // Query the DB for the complete Order object
                            Order order = dbContext.Orders
                                .Include(o => o.Account)
                                .Include(o => o.Product)
                                .ThenInclude(p => p.Creator)
                                .FirstOrDefault(o => o.OrderId == id);

                            return View("Show", order);
                        }
                    }
                }
            }
        }

        // RESTful route for deleting an Order
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
                        // Create queries to the DB for ORder and Order objects
                        Order deleteOrder = dbContext.Orders.FirstOrDefault(o => o.OrderId == id);

                        // If Order query is null, redirect to the show page
                        if(deleteOrder == null)
                        {
                            return RedirectToAction("Show", "Accounts", new{id = accountId});
                        }

                        // Else Checks queried Order AccountId against the AccountId in Session
                        else
                        {
                            // If the ID's don't match, log the user out and clear session
                            if(deleteOrder.AccountId != accountId)
                            {
                                TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                                return RedirectToAction("Index", "Accounts");
                            }

                            // Else run the queries to Delete both the Product and its Orders
                            else
                            {
                                // Creates a Product object to return the Order Amount back into the Product Quantity
                                Product product = dbContext.Products.FirstOrDefault(p => p.ProductId == deleteOrder.ProductId);

                                // Adds the deleted Order's Amount back into the Product's quantity prior to deletion.
                                product.Quantity = product.Quantity + deleteOrder.Amount;

                                // Delete the product from the DB
                                dbContext.Remove(deleteOrder);
                                dbContext.SaveChanges();

                                return RedirectToAction("Show", "Accounts", new{id = accountId});
                            }
                        }
                    }
                }
            }
        }
    }
}