using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages;

public class Orders : PageModel
{
    public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
    private readonly ApplicationDbContext _context;
    public Orders(ApplicationDbContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        PizzaOrders = _context.PizzaOrders.ToList();
    }
}