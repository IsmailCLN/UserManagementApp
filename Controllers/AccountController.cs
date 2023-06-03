using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using UserManagementApp.Models;

namespace UserManagementApp.Controllers
{
    public class AccountController : Controller
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        [HttpGet]
        
        void connectionString()
        {
            con.ConnectionString = "data source"
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult SignOut()
        {
            return View();
        }
    }
}
