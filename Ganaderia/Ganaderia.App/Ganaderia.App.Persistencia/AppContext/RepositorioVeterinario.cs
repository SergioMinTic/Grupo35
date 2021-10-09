using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario) 
        {
            var VeterinarioAgregado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return VeterinarioAgregado.Entity;
        }
    }

    
}