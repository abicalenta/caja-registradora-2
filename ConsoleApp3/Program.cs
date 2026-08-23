using System.Numerics;

Console.WriteLine("KIOSCO EL RECREO");
string respuesta = Console.ReadLine();
Console.Write("Nombre del cajero: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Bienvenida, {nombre}. Caja abierta");
Console.ReadLine();


Console.Write("Nombre del producto: ");
string producto = Console.ReadLine();

Console.Write("Precio del producto: ");
decimal precio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Producto cargado: {producto} - ${precio}");

Console.ReadLine();

do
{
    Console.WriteLine("Qué desea hacer?");
    Console.WriteLine("1 - Cargar un nuevo producto");
    Console.WriteLine("2- Cerrar la ventana");
    Console.Write("Opción: ");
    int opcion = Convert.ToInt32(Console.ReadLine());
    
    switch (opcion)
    {
        case 1:
            Console.Write("Nombre del producto: ");
            string producto = Console.ReadLine();
            Console.Write("Precio del producto: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());

            total += precio;
            cantidadProductos++;
            Console.WriteLine($"-> {producto} agregado.\n");
            break;

        case 2:
            Console.WriteLine("\nVenta cerrada.");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.\n");
            break;

    }
} while (opcion != 2);

Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
Console.WriteLine($"Total: {total}");

Console.ReadLine();




