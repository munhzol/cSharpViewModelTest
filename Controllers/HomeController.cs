using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcTest.Models;

namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string Message = "Some messages will appear here!";
            return View("StringModel", Message);
        }

        [HttpGet("/numbers")]
        public IActionResult Numbers()
        {
            int[] arrInt = new int[] {
                1,2,3,4,5,6,7,8,9,10
            } ;
            return View("ArrayOfIntModel", arrInt);
        }

        [HttpGet("/users")]
        public IActionResult Users()
        {
            List<User> users = new List<User> {
                new User {
                    FirstName = "Michael",
                    LastName = "Jordan"
                },
                new User {
                    FirstName = "Dennis",
                    LastName = "Rodman"
                },
                new User {
                    FirstName = "Scottie",
                    LastName = "Pippen"
                },
                new User {
                    FirstName = "Steve",
                    LastName = "Kerr"
                }
            };

            return View("UsersModel", users);
        }


        [HttpGet("/user")]
        public IActionResult RandomUser()
        {
            List<User> users = new List<User> {
                new User {
                    FirstName = "Michael",
                    LastName = "Jordan"
                },
                new User {
                    FirstName = "Dennis",
                    LastName = "Rodman"
                },
                new User {
                    FirstName = "Scottie",
                    LastName = "Pippen"
                },
                new User {
                    FirstName = "Steve",
                    LastName = "Kerr"
                }
            };

            Random rand = new Random();
            User user = users[rand.Next(users.Count)];

            return View("RandomUser", user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
