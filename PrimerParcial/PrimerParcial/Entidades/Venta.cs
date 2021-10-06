using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades
{
    class Venta
    {

        private int identificador_producto;
        private String nombre_producto;
        private String descripcion_de_producto;
        private double precio_de_venta;
        private int cantidad;

        public Venta(int identificador_producto, string nombre_producto, string descripcion_de_producto, double precio_de_venta, int cantidad)
        {
            this.identificador_producto = identificador_producto;
            this.nombre_producto = nombre_producto;
            this.descripcion_de_producto = descripcion_de_producto;
            this.precio_de_venta = precio_de_venta;
            this.cantidad = cantidad;
        }

        public int Identificador_producto { get => identificador_producto; set => identificador_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Descripcion_de_producto { get => descripcion_de_producto; set => descripcion_de_producto = value; }
        public double Precio_de_venta { get => precio_de_venta; set => precio_de_venta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }

      
    }

