using FlowerShopAuth.Data;
using FlowerShopAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FlowerShopAuth.Controllers
{
    [Authorize(Roles = "User")] // Only Users can access
    public class UserGiftController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserGiftController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserGift
        public async Task<IActionResult> Index()
        {
            var gifts = await _context.Gifts.ToListAsync();
            return View(gifts); // Only view products, no CRUD buttons
        }
    }
}
