using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class CiudadesBL
    {
        public List<Ciudad> ListadeCiudades { get; set; }

        public CiudadesBL()
        {
            ListadeCiudades = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Atlantida");
            var ciudad2 = new Ciudad(2, "Islas de la Bahia");

            ListadeCiudades.Add(ciudad1);
            ListadeCiudades.Add(ciudad2);
        }
    }
}
