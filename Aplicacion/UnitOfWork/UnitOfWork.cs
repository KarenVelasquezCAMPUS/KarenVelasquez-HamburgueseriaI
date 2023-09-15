using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiContext context;
    
    private CategoriaRepository _categorias;
    private ChefRepository _chefs;
    //private HamburguesaIngredienteRepository _hamburguesaIngredientes;
    private HamburguesaRepository _hamburguesas;
    private IngredienteRepository _ingredientes;

    public UnitOfWork (ApiContext _context)
    {
        context = _context;
    }

    public ICategoria Categorias 
    {
        get{
            if(_categorias == null)
            {
                _categorias = new CategoriaRepository(context);
            }
            return _categorias;
            }
    }

    public IChef Chefs
    {
        get{
            if(_chefs == null)
            {
                _chefs = new ChefRepository(context);
            }
            return _chefs;
            }
    }

    /* public IHamburguesaIngrediente HamburguesaIngredientes
    {
        get{
            if(_hamburguesaIngredientes == null)
            {
                _hamburguesaIngredientes = new HamburguesaIngredienteRepository(context);
            }
            return _hamburguesaIngredientes;
            }
    } */

    public IHamburguesa Hamburguesas
    {
        get{
            if(_hamburguesas == null)
            {
                _hamburguesas = new HamburguesaRepository(context);
            }
            return _hamburguesas;
            }
    }

    public IIngrediente Ingredientes
    {
        get{
            if(_ingredientes == null)
            {
                _ingredientes = new IngredienteRepository(context);
            }
            return _ingredientes;
            }
    }

    public void Dispose()
    {
        context.Dispose();
    }
}