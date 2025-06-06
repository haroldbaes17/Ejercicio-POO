﻿using BusinessLogic;
using Entities;

public class Program
{
    static ProductManager manager = new ProductManager();
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al gestor de productos Dummy");

        while (true)
        {
            Console.WriteLine("Qué desea hacer?");
            Console.WriteLine("1. Agregar un producto");
            Console.WriteLine("2. Consultar listado de productos");
            Console.WriteLine("9. Salir");

            Console.Write("Digite la opción que desea hacer: ");
            var option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    GetProducts();
                    break;
                case 9:
                    Console.WriteLine("Saliendo......");
                    return; // Termina el programa
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    public static void AddProduct()
    {
       try
        {
            Console.WriteLine("Digite la informacion del producto a agregar");
            Console.Write("Ingrese el ID del producto: ");
            int id = Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese el Nombre del producto: ");
            string name = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            double price = Double.Parse(Console.ReadLine());

            Console.Write("Ingrese el stock del producto: ");
            int stock = Int32.Parse(Console.ReadLine());

            manager.AddProduct(id, name, price, stock);
            Console.WriteLine("Producto agregado exitosamente: ");

        } catch (Exception ex) 
        {
            Console.WriteLine($"Hubo un error. Intente de nuevo{ex.Message}");
        }
    }

    public static void GetProducts()
    {
        try
        {
            List<Product> productos = manager.GetProducts();

            Console.WriteLine($"Total de productos: {productos.Count}");

            if (productos != null)
            {
                Console.WriteLine("Listado de Productos: ");
                foreach (Product product in productos)
                {
                    Console.WriteLine($"ID: {product.Id}");
                    Console.WriteLine($"Nombre: {product.Name}");
                    Console.WriteLine($"Precio: {product.Price}");
                    Console.WriteLine($"Stock: {product.Stock}");
                    Console.WriteLine("============================");
                }
            } else
            {
                Console.WriteLine("No hay productos en el sistema");
            }
            
        } catch (Exception ex)
        {
            Console.WriteLine($"Hubo un error: {ex.Message}");
        }
        
    }
}