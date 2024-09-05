using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: Claims/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Claims/Upload
        public IActionResult Upload()
        {
            return View();
        }
    }
}
