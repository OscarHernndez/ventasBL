using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Atlantida");
            var ciudad2 = new Ciudad(2, "Islas de la Bahia");

            var cliente1 = new Cliente(1, "Francisco Villeda", 50494685127, ciudad1);
            var cliente2 = new Cliente(2, "Mauricio Lopez", 50436784512, ciudad1);
            var cliente3 = new Cliente(3, "Carlos Reyes", 50492586471, ciudad2);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }
    }
}
