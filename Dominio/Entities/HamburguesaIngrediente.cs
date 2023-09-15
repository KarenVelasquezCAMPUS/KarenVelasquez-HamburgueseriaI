namespace Dominio.Entities;
public class HamburguesaIngrediente
{
    public string HamburguesaFk { get; set; }
    public Hamburguesa Hamburguesa { get; set; }
    public string IngredienteFk { get; set; }
    public Ingrediente Ingrediente { get; set; }
}