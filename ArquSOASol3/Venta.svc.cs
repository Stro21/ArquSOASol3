﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ArquSOASol3;
using System.Data;

namespace ArquSOASol3
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Venta" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Venta.svc o Venta.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Venta : IVenta
    {
        public bool Buscar_Producto(string producto)
        {
            bool encontrado = false;
            string find = "ProductName = " + producto;
            DataTable tb = new DataTable();
            return encontrado;
        }
    }
}
