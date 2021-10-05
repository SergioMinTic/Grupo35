using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        Veterinario AddVeterinario(Veterinario veterinario);
    }
}