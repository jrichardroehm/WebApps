using Microsoft.AspNetCore.Mvc;
using Bogus;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class UserController : Controller
    {
        private List<UserViewModel> _users;

        public IActionResult Index()
        {
            var faker = new Faker();
            this._users = new Faker<UserViewModel>()
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.CacEdipi, f => f.Random.Int(0, 99_999_999))
                .Generate(10);
            return View();
        }

        [HttpPost]
        public IActionResult GenerateData()
        {
            
            _users = new Faker<UserViewModel>()
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.CacEdipi, f => f.Random.Int(0, 99_999_999))
                .Generate(10);
            return View(_users);

        }
    }
}
