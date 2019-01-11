using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Controllers
{
    // Controller for user accounts -- Catch all, so no Controller route
    public class AccountsController : Controller
    {
        // <---------- Dependency Injection ---------->

        // create DBContext Object
        private ECommerceContext dbContext;

        // Inject Context service into the class constructor

        public AccountsController(ECommerceContext context)
        {
            dbContext = context;
        }

        // <---------- Accounts GET routes ---------->

        // Catch all for default route
        [HttpGet("")]
        public IActionResult Index()
        {
            // Retrieves data from ession to qury as an event handler.
            // Checks to see if the Session data is present to prevent penetration
            string loggedIn = HttpContext.Session.GetString("LoggedIn");
            int? accountId = HttpContext.Session.GetInt32("AccountId");
            string email = HttpContext.Session.GetString("Email");

            // Retrieves LogoutError is present in Session
            if(TempData["LogoutError"] != null)
            {
                // Sets the Logout Error and clears it from Session
                HttpContext.Session.Clear();
                ViewBag.LogoutError = TempData["LogoutError"];
            }

            // if 'loggedIn' not present, proceed to default view
            if(loggedIn == null)
            {
                return View();
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
                    return View();
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
                        return View();
                    }

                    // Else undersatnds that the user is 'logged in' and moves the user to the
                    // Index in the Products controller
                    else
                    {
                        return RedirectToAction("Index", "Products");
                    }
                }
            }
        }

        // RESTful route for displaying the new Account registration page
        [HttpGet("New")]
        public IActionResult New()
        {
            // Creates a 'loggedIn' variable using session to check to see if the
            // Account user is logged in.

            string loggedIn = HttpContext.Session.GetString("LoggedIn");

            // If loggedIn is not null, then proceed
            if(loggedIn == null)
            {
                return View();
            }

            // Else, kill Session and proceed
            else
            {
                ViewBag.LoggedIn = null;
                HttpContext.Session.Clear();
                return View();
            }
        }

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
                        
                        // Query the DB for the complete Account object
                        Account account = dbContext.Accounts
                            .Include(a => a.CreatedProducts)
                            .Include(a => a.Orders)
                            .ThenInclude(o => o.Product)
                            .FirstOrDefault(a => a.AccountId == accountId);

                        return View(account);
                    }
                }
            }
        }
        
        // RESTful route for logging out of an account
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            // Kills session, redirects to Index
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // <---------- Accounts POST routes ---------->

        // RESTful route for creating a new Account
        [HttpPost("Create")]
        public IActionResult Create(Account account)
        {
            // Checks to see if all the data fields were completed
            if(ModelState.IsValid)
            {
                // Validates that the Account user's age is over 18

                // If Account user age is over 18, create an account ( Add DB validators later )
                if(account.Age >= 18)
                {
                   // If Account user is over 18, checks for duplicate email address in the DB
                   if(dbContext.Accounts.Any(a => a.Email == account.Email))
                   {
                       // if meail exists, throws an email error and returns the Registration form
                       ModelState.AddModelError("Email", "Email is already in use!");
                       return View("New");
                   }

                   // Else, create the Account
                   else
                   {
                        // Sets the DateTime values for account creations
                        account.CreatedAt = DateTime.Now;
                        account.UpdatedAt = DateTime.Now;

                        // Creates a password hasher object using Identity
                        PasswordHasher<Account> Hasher = new PasswordHasher<Account>();

                        // Uses the PW 'Hasher' object ot has the userform password
                        account.Password = Hasher.HashPassword(account, account.Password);

                        // Sets the default Image URL
                        account.Image = "https://via.placeholder.com/100";

                        // Adds an Account to the DB
                        dbContext.Add(account);
                        dbContext.SaveChanges();

                        // Creates 'Logged In' status, with security validation.
                        // Each route can now check to see if the User is logged in using
                        // session data to validate a query to the DB. If the email does 
                        // not match the email for the user id, then session will be cleared.
                        // *NOTE* this can eventually replaced with Indentity in future projects!
                        HttpContext.Session.SetString("LoggedIn", "true");
                        HttpContext.Session.SetInt32("AccountId", account.AccountId);
                        HttpContext.Session.SetString("Email", account.Email);

                        return RedirectToAction("Index", "Products");
                   }
                }
                else
                {
                    // If account user is under 18, throws a birthday error and returns the Registration form
                    ModelState.AddModelError("Birthday", "To create an account, you must be at least 18 years of age!");
                    return View("New");
                }
            }

            // If not valid, return errors
            else
            {
                // Checks age to add birthday Validator
                if(account.Age < 18)
                {
                    // If there are other errors and the registration birthday is under 18, throws a birthday error and
                    // returns the registration form
                    ModelState.AddModelError("Birthday", "A user must be over the age of 18 to register an account!");
                    return View("New");
                }
                else
                {
                    // If the modelstate fails and the user is over 18, returns the registration form with Data Annotation errors
                    return View("New");
                }
            }
        }

        // RESTful route for logging into an Account
        [HttpPost("Login")]
        public IActionResult Login(LoginAccount submission)
        {
            // Checks to see if all the data fields were completed
            if(ModelState.IsValid)
            {
                // If there are no form errors, query the DB for the Account's
                // Email in the DB to see if it exists

                var loginAccount = dbContext.Accounts.FirstOrDefault(a => a.Email == submission.Email);

                // If Account email doesn't exist, throw a form field error and
                // return the Index view

                if(loginAccount == null)
                {
                    ModelState.AddModelError("Password", "Invalid Email/Password!");
                    return View("Index");
                }

                // Else attempt to verify the password
                else
                {
                    // Creates a password hasher object using Identity
                    var hasher = new PasswordHasher<LoginAccount>();

                    // Query the DB to verify password against the object queried from the DB
                    var result = hasher.VerifyHashedPassword(submission, loginAccount.Password, submission.Password);

                    // Result compared to 0 for failure
                    if(result == 0)
                    {
                        // Failure throws a password error and returns the Index View
                        ModelState.AddModelError("Password", "Invalid Email/Password!");
                        return View("Index");
                    }

                    // Else creates 'Logged In' status, with security validation.
                    // Each route can now check to see if the User is logged in using
                    // session data to validate a query to the DB. If the email does 
                    // not match the email for the user id, then session will be cleared.
                    // *NOTE* this can eventually replaced with Indentity in future projects!
                    else
                    {
                        HttpContext.Session.SetString("LoggedIn", "true");
                        HttpContext.Session.SetInt32("AccountId", loginAccount.AccountId);
                        HttpContext.Session.SetString("Email", loginAccount.Email);

                        // Redirects to the Messages Index, now "Logged In"
                        return RedirectToAction("Index", "Products");
                    }
                }
            }

            // Else returns the Accounts Index
            else
            {
                return View("Index");
            }
        }

        // RESTful route for updating an Account
        [HttpPost("Update/{id}")]
        public IActionResult Update(UpdateAccount submission, int id)
        {
            // Creates a variable to check if an Account is "Logged In"
            string loggedIn = HttpContext.Session.GetString("LoggedIn");
            int? accountId = HttpContext.Session.GetInt32("AccountId");
            string email = HttpContext.Session.GetString("Email");

            // If the Account is not "Logged In", kills session and kicks the 
            // Account user back to Login page
            if(loggedIn == null)
            {
                return RedirectToAction("Index");
            }

            // Else checks the route ID against the session ID
            else
            {
                if(accountId != id)
                {
                    HttpContext.Session.Clear();
                    TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                    return RedirectToAction("Index");
                }

                // Else checks to see if the account is in the DB
                else
                {
                    // Creates a new Account object using the session email
                    Account account = dbContext.Accounts.FirstOrDefault(a => a.Email == email);

                    // If email is not in the DB, kill Session and returns the View
                    if(account == null)
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
                        if(account.AccountId != id)
                        {
                            HttpContext.Session.Clear();
                            TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                            return RedirectToAction("Index");
                        }

                        // Checks to see if all the data fields were completed
                        else
                        {
                            if(ModelState.IsValid)
                            {
                                // uses the account object to update the DB

                                account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == id);

                                // Sets the DateTime values for updating the account
                                account.UpdatedAt = DateTime.Now;

                                // If Update Email field is not blank
                                if(submission.Email != null)
                                {
                                    // Queries the DB to check if any accounts have the requested email
                                    // address other than the user Account
                                    
                                    var emailInDb = dbContext.Accounts.Where(a => a.Email == submission.Email && a.AccountId != id).ToList();

                                    // If Query returns an object, return the view
                                    if(emailInDb.Count > 0)
                                    {
                                        // Creates a ViewBag variable for NavBar display
                                        ViewBag.LoggedIn = true;

                                        // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                                        ViewBag.AccountId = (int)accountId;
                                        
                                        // Query the DB for the complete Account object
                                        account = dbContext.Accounts
                                            .Include(a => a.CreatedProducts)
                                            .Include(a => a.Orders)
                                            .ThenInclude(o => o.Product)
                                            .FirstOrDefault(a => a.AccountId == id);

                                        // Add Email error
                                        ModelState.AddModelError("Email", "Email is already in use!");

                                        return View("Show", account);
                                    }
                                    else
                                    {
                                        // Updates Email in the DB
                                        account.Email = submission.Email;

                                        // Updates Session with the new Email address
                                        HttpContext.Session.SetString("Email", account.Email);
                                    }
                                }

                                // If Update Password field is not blank
                                if(submission.Password != null)
                                {
                                    // Creates a password hasher object using Identity
                                    PasswordHasher<UpdateAccount> Hasher = new PasswordHasher<UpdateAccount>();

                                    // Uses the PW 'Hasher' object to hash the userform password
                                    account.Password = Hasher.HashPassword(submission, submission.Password);
                                }

                                // if Update Image field is not blank
                                if(submission.Image != null)
                                {
                                    // Updates the Image URL in the DB
                                    account.Image = submission.Image;
                                }

                                // Saves the database, and returns the Account page

                                dbContext.SaveChanges();

                                return RedirectToAction("Show", new{id = account.AccountId});
                            }

                            // Else return Show model with Errors
                            else
                            {
                                // Creates a ViewBag variable for NavBar display
                                ViewBag.LoggedIn = true;

                                // Creates a ViewBag variable for NavBar to access the Accounts/Show route
                                ViewBag.AccountId = (int)accountId;
                                
                                // Query the DB for the complete Account object
                                account = dbContext.Accounts
                                    .Include(a => a.CreatedProducts)
                                    .Include(a => a.Orders)
                                    .ThenInclude(o => o.Product)
                                    .FirstOrDefault(a => a.AccountId == accountId);

                                return View("Show", account);
                            }
                        }
                    }
                }
            }
        }

        // RESTful route for deleting an Account
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
                        // Create queries to the DB for Account, Products and Orders objects
                        Account deleteAccount = dbContext.Accounts.FirstOrDefault(a => a.AccountId == accountId);
                        
                        var deleteProducts = dbContext.Products.Where(p => p.AccountId == id);
                        var deleteAccountOrders = dbContext.Orders.Where(o => o.AccountId == id);

                        // If product query is null, redirect to the show page
                        if(deleteAccount == null)
                        {
                            return RedirectToAction("Show", "Accounts", new{id = accountId});
                        }

                        // Else Checks queried Product AccountId against the AccountId in Session
                        else
                        {
                            // If the ID's don't match, log the user out and clear session
                            if(deleteAccount.AccountId != id)
                            {
                                TempData["LogoutError"] = "And error has occured and you have been logged out! Please login to continue!";
                                return RedirectToAction("Index", "Accounts");
                            }

                            // Else run the queries to Delete both the Product and its Orders
                            else
                            {
                                // If the Account has any orders, delete each order from the DB
                                if(deleteAccountOrders.Count() > 0)
                                {
                                    foreach(var order in deleteAccountOrders)
                                    {
                                        // Creates a Product object for the Order to add the Amount back into the Product Quantity
                                        Product product = dbContext.Products.FirstOrDefault(p => p.ProductId == order.ProductId);

                                        // Add the order back into the Products
                                        product.Quantity = product.Quantity + order.Amount;

                                        dbContext.Orders.Remove(order);
                                    }
                                }

                                // If any of the Account's Products has Orders, delete the orders and then the product
                                if(deleteProducts.Count() > 0)
                                    {
                                        foreach(var product in deleteProducts)
                                        {
                                            var deleteProductOrders = dbContext.Orders.Where(o => o.ProductId == product.ProductId);
                                            if(deleteProductOrders.Count() > 0)
                                            {
                                                foreach(var order in deleteProductOrders)
                                                {
                                                    dbContext.Orders.Remove(order);
                                                }
                                            }
                                            dbContext.Products.Remove(product);
                                        }
                                    }


                                // Delete the Account from the DB
                                dbContext.Accounts.Remove(deleteAccount);
                                dbContext.SaveChanges();

                                HttpContext.Session.Clear();

                                return RedirectToAction("Index", "Accounts");
                            }
                        }
                    }
                }
            }
        }
    }
}