using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPersistance;
using Entities;

namespace BusinessLogic
{
    public class ProductManager
    {
        FileManager manager = new FileManager();
        public void AddProduct(int id, string name, double price, int stock)
        {

            /* Validaciones
            Precio debe ser mayor a 0
            Stock no puede ser negativo 
            Nombre no debe estar vacio */

            if (price < 1)
            {
                throw new Exception("El precio debe ser mayor a 0");
            }

            if (stock < 0)
            {
                throw new Exception("El Stock no puede ser negativo");
            }
            
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("El nombre no puede estar vacio");
            }

            // Si pasa las validaciones enviamos a guardar al .txt
            Product product = new Product() { Id = id, Name = name, Price = price, Stock = stock };
            manager.SaveProduct(product);
        }

        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            return products;
        }
    }
}
