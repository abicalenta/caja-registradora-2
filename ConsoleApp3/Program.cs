Console.WriteLine("KIOSCO EL RECREO");
string respuesta = Console.ReadLine();
Console.Write("Nombre del cajero: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Bienvenida, {nombre}. Caja abierta");
Console.ReadLine();



const string NOMBRE_COMERCIO = "KIOSCO EL RECREO";

Console.WriteLine($"=== {NOMBRE_COMERCIO} ===");
Console.Write("Nombre del cajero: ");
string cajero = Console.ReadLine();
Console.WriteLine($"Bienvenida/o, {cajero}. Caja abierta.\n");

Console.Write("Nombre del producto: ");
string producto = Console.ReadLine();

Console.Write("Precio del producto: ");
decimal precio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Producto cargado: {producto} - ${precio}");

Console.ReadLine();