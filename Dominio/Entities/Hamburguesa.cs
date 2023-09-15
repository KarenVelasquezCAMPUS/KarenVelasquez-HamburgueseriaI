namespace Dominio.Entities;
public class Hamburguesa : BaseEntity
{
    public string Nombre { get; set; }
    public string CategoriaFk { get; set; }
    public Categoria Categoria { get; set; } 
    public string Precio { get; set; }
    public string ChefFk { get; set; }
    public ICollection<Categoria> Categorias { get; set; }
    public ICollection<Chef> Chefs { get; set; }
}