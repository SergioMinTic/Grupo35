using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanado : IRepositorioGanado
    {
        private AppContext _appContext;

        public RepositorioGanado(AppContext appContext)
        {
            _appContext = appContext;
        }

        Ganado IRepositorioGanado.AddGanado(Ganado ganado) 
        {
            var GanadoAgregado = _appContext.Ganados.Add(ganado);
            _appContext.SaveChanges();
            return GanadoAgregado.Entity;
        }
    }

    
}