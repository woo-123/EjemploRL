using Microsoft.AspNetCore.Mvc;
using EjemploRL.Models;
using EjemploRL.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace EjemploRL.Controllers
{
    public class CatalogoController:Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CatalogoController(ApplicationDbContext context ,UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Details (int? id){

            Catalogo  obj = await _context.DataProducts.FindAsync(id);
            if (obj == null){

                return NotFound();
            }
            return View (obj);
        }

        public async Task<IActionResult> Add (int? id){
            var userId =  _userManager.GetUserName(User);
            if(userId == null){
                ViewData ["Message"] = "Por favor debe loguearse antes de agregar  un producto";
                List<Catalogo> productos = new List<Catalogo>();
                return View("Index",productos);
            }
            else{
                var producto = await _context.DataProducts.FindAsync(id);
                Proforma proforma = new Proforma ();
                proforma.Producto= producto ;
                proforma.Price = producto.Price; 
                proforma.Quantity = 1;
                proforma.UserId = userId;
                _context.Add(proforma);
                await _context.SaveChangesAsync();
                return  RedirectToAction(nameof(Index));



            }
            return null;

        }
    } 
}