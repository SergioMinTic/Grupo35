using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{ 
    public class Ganado
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string alias { get; set; }
        public string raza { get; set; }
        public List<Vacuna> Vacunas { get; set; }
        public Veterinario Veterinario { get; set; }
    }
}