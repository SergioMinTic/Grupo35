using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        /// <summary>
        private static IRepositorioGanadero _repoGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"> </param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddGanadero();
            //GetAllGanaderos();
            //GetGanadero(3);
            //UpdateGanadero();
            //DeleteGanadero(3);
            AddVeterinario();
            
        }

        
        private static void AddGanadero()
        {
            Ganadero ganadero = new Ganadero 
            {
                Nombre = "Andres",
                Apellido = "Herrera",
                NumeroTelefono = "3148569865",
                Correo = "sergio.mintic@mintic.edu.co",
                Contrasena = "12345678",
                Latitud = 121212,
                Longitud = 7887878
            };

            _repoGanadero.AddGanadero(ganadero);
        }

        private static void GetAllGanaderos() {
            var ganaderos = _repoGanadero.GetAllGanaderos();
            foreach(Ganadero item in ganaderos)
            {
                Console.WriteLine(item.Nombre);
            }           
        }

        private static void GetGanadero(int idGanadero) 
        {
            var ganadero = _repoGanadero.GetGanadero(idGanadero);
            Console.WriteLine(ganadero.Nombre);

        }

        private static void UpdateGanadero() 
        {
            Ganadero ganadero = new Ganadero 
            {
                Id = 3,
                Nombre = "Pedro",
                Apellido = "Herrera",
                NumeroTelefono = "3148569865",
                Correo = "sergio.mintic@mintic.edu.co",
                Contrasena = "12345678",
                Latitud = 121212,
                Longitud = 7887878
            };

            _repoGanadero.UpdateGanadero(ganadero);

        }

        private static void DeleteGanadero(int IdGanadero)
        {
            _repoGanadero.DeleteGanadero(IdGanadero);
        }

        private static void AddVeterinario()
        {
            Veterinario veterinario = new Veterinario 
            {
                Nombre = "Juan",
                Apellido = "Cuadrado",
                NumeroTelefono = "3148569865",
                Correo = "juan@mintic.edu.co",
                Contrasena = "12345678",
                Especialidad = "Médico genral",
                NumeroTarjeta = "123"
            };

            _repoVeterinario.AddVeterinario(veterinario);
        }


    }
}
