using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;


namespace Ganaderia.App.Presentacion.Pages
{     
    public class RegisterModel : PageModel
    {
        private static IRepositorioGanadero _repoGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        public IEnumerable<Ganadero> Ganaderos { get; set; }

        public void OnGet()
        {
            Ganaderos = _repoGanadero.GetAllGanaderos();
        }

        public void OnPostAdd(Ganadero ganadero)
        {
            _repoGanadero.AddGanadero(ganadero);
            Ganaderos = _repoGanadero.GetAllGanaderos();

            var ganaderoEncontrado = _repoGanadero.GetGanadero(1005);
            Console.WriteLine("Nombre de ganadero: " + ganaderoEncontrado.Nombre);

        }


    }
}
