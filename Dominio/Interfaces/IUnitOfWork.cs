using Dominio.Entities;

namespace Dominio.Interfaces;
public class IUnitOfWork
{
    ICategoria Categorias { get; }
    IChef Chefs { get; }
    IHamburguesa Hamburguesas { get; }
    HamburguesaIngrediente HamburguesaIngredientes { get; }
    IIngrediente Ingredientes { get; }
}