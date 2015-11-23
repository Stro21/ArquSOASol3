using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ArquSOASol3;
using System.Data;

namespace ArquSOASol3
{
    public class Venta : IVenta
    {
        public bool Buscar_Producto(string producto)
        {
            bool encontrado = false;
            string find = "ProductName = " + producto;
            DataTable tb = new DataTable();
            return encontrado;
        }

        public void agregar_producto_venta(string producto)
        {
            if (Buscar_Producto(producto))
            {

            }
        }

        public void eliminar_producto_venta(string producto)
        {

        }
    }
}
