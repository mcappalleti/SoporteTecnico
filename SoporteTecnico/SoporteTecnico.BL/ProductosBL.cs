using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTecnico.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Mantenimiento Preventivo";
            producto1.Precio = 300.00;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Taller de Reparaciones";
            producto2.Precio = 150.00;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Instalaciones de Software";
            producto3.Precio = 250.00;

            var listadeProductos = new List<Producto>();

            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);


            return listadeProductos;
        }
    }
}
