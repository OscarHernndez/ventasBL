using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

        public Cliente(int id, string descripcion, double precio, Ciudad ciudad)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Ciudad = ciudad;
            CiudadId = ciudad.Id;

        }
    }
}
