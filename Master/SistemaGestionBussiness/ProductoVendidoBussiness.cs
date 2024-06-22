﻿using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> GetProductosVendidos()
        {
            return ProductoVendidoData.GetProductosVendidos();
        }
        public static List<ProductoVendido> ObtenerProductoVendidoPorId(int id)
        {
            return ProductoVendidoData.ObtenerProductoVendidoPorId(id);
        }
        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            return ProductoVendidoData.CrearProductoVendido(productoVendido);
        }
        public static bool EliminarProductoVendido(int id)
        {
            return ProductoVendidoData.EliminarProductoVendido (id);
        }
        public static bool ModificarProductoVendido(ProductoVendido productoVendido)
        {
            return ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }
    }
}
