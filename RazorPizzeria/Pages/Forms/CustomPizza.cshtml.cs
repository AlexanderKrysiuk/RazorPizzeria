using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;
namespace RazorPizzeria.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty]
    public PizzasModel Pizza { get; set; }
    public void OnGet()
    {
        
    }
}