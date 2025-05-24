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
        private readonly string filepath = "productos.txt";

        // Metodo que retorna una lista de productos tomada del archivo de texto /.
        public List<Product> ReadProducts()
        {
            // ------- DESARROLLAR POR EL ESTUDIANTE -------
            //Leer la lista de producto de un .txt y cargarlo en una lista

            var products = new List<Product>();

            if(!File.Exists(filepath))
            {
                return products;
            }

            var lines = File.ReadAllLines(filepath);

            foreach (var line in lines)
            {
                var cols = line.Split(',');

                // Saltar líneas que no tengan 4 columnas o que sean el encabezado
                if (cols.Length != 4 || cols[0].Equals("id", StringComparison.OrdinalIgnoreCase))
                    continue;

                products.Add(new Product
                {
                    Id = Int32.Parse(cols[0]),
                    Name = cols[1],
                    Price = double.Parse(cols[2]),
                    Stock = int.Parse(cols[3])
                });
            }


                return products;
        }

        // Metodo que guarda un producto en un archivo .txt
        public void SaveProduct(Product product)
        {
            // ------- DESARROLLAR POR EL ESTUDIANTE -------
            //Guardar el producto en un archivo .txt
            //Formato: id,nombre, precio, stock

            Console.WriteLine(Path.GetFullPath(filepath)); // Verificar la ruta del archivo

            // Linea a guardar en el .txt
            string line = $"{product.Id},{product.Name},{product.Price},{product.Stock}";

            //Comprobar si el archivo existe
            bool exists = File.Exists(filepath); 
            
            using (var sw = new StreamWriter(filepath, append: true))
            {
                // Si el archivo no existe, escribir el encabezado
                if (!exists)
                {
                    sw.WriteLine("id,nombre,precio,stock");
                }
                sw.WriteLine(line);
            }
        }
    }
}
