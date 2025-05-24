using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

namespace DataPersistance
{
    public class FileManager
    {
        string ruta = "productos.txt";

        // Metodo que retorna una lista de productos tomada del archivo de texto /.
        public List<Product> ReadProducts()
        {
            // ------- DESARROLLAR POR EL ESTUDIANTE -------
            //Leer la lista de producto de un .txt y cargarlo en una lista
            var products = new List<Product>();
            return products;
        }

        // Metodo que guarda un producto en un archivo .txt
        public void SaveProduct(Product product)
        {
            // ------- DESARROLLAR POR EL ESTUDIANTE -------
            //Guardar el producto en un archivo .txt
        }
    }
}
