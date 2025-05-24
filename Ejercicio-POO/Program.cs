public class Program
{
    public string void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al gestor de productos Dummy");

        while (true)
        {
            Console.WriteLine("Qué desea hacer?");
            Console.WriteLine("1. Agregar un producto");
            Console.WriteLine("2. Consultar listado de productos");

            Console.Write("Digite la opción que desea hacer: ");
            var option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Digite la informacion del producto a agregar");
                    break;
                case 2:
                    Console.WriteLine("Listado de productos existentes");
                    break;
                case 9:
                    Console.WriteLine("Saliendo......");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}