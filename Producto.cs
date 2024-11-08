﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeInventario
{
    public class Producto
    {
  
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

    
        public Producto(string nombre, decimal precio)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            }

            if (precio <= 0)
            {
                throw new ArgumentException("El precio debe ser un número positivo.");
            }

            Nombre = nombre;
            Precio = precio;
        }

        // Método para mostrar la información del producto
        public void MostrarInformacion()
        {
            Console.WriteLine($"Producto: {Nombre}, Precio: {Precio:C}");
        }
    }
}
