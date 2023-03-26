namespace RazorPizzeria.Models;

public class PizzasModel
{
    public string ImageTitle { get; set; } = null!;
    public string PizzaName { get; set; } = null!;
    public float BasePrice { get; set; } = 2;
    public bool TomatoSauce { get; set; }
    public bool Cheese { get; set; }
    public bool Peperoni { get; set; }
    public bool Mushroom { get; set; }
    public bool Tuna { get; set; }
    public bool Pineapple { get; set; }
    public bool Ham { get; set; }
    public bool Beef { get; set; }
    public float FinalPrice { get; set; }
}