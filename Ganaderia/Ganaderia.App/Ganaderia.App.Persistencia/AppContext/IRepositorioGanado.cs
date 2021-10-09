using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanado
    {
        Ganado AddGanado(Ganado ganado);
    }
}