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
            Console.WriteLine("\nVenta cerrada.\n");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.\n");
            break;

    }
} while (opcion != 2);

Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
Console.WriteLine($"Total: {total}");

Console.ReadLine();

decimal porcentajeDescuento = 0m;

if (subtotal > 50000m)
{
    porcentajeDescuento = DescuentoMedio;
}

decimal descuentoMonto = subtotal * porcentajeDescuento;
decimal totalConDescuenot = subtotal - descuentoMontoMonto;

Console.WriteLine($"Subtotal: {subtotal}");
Console.WriteLine($"Descuento: {descuentoMonto}");
Console.WriteLine($"Total: {totalConDescuento}");

Console.ReadLine();

decimal porcentajeDescuento = 0m;

if (subtotal > 50000m)
{
    porcentajeDescuento = DescuentoAlto;
}
else if (subtotal > 20000m) ;
{
    porcentajeDescuento = descuentoMedio;
}

decimal descuentoMonto = subtotal * porcentajeDescuento;
decimal totalConDescuento = subtotal - descuentoMonto;

int medioPago;
bool medioPagoValido = false;
decimal descuentoEfectivoMonto = 0m;
decimal recargoCreditoMonto = 0m;

do
{
    Console.WriteLine("Medio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Débito");
    Console.WriteLine("3 - Crédito");
    Console.Write("Opción: ");
    medioPago = Convert.ToInt32(Console.ReadLine());

    switch (medioPago)
    {
        case 1:
            descuentoEfectivoMonto = totalConDescuento * DescuentoEfectivo;
            medioPagoValido = true;
            break;
        case 2:
            medioPagoValido = true;
            break;
        case 3:
            recargoCreditoMonto = totalConDescuento * RecargoCredito;
            medioPagoValido = true;
            break;
        default:
            Console.WriteLine("Opción inválida. Ingrese el medio de pago nuevamente.\n");
            break;
    }
} while (!medioPagoValido);

decimal descuentoTotal = descuentoMonto + descuentoEfectivoMonto;
decimal totalFinal = subtotal - descuentoTotal + recargoCreditoMonto;

Console.WriteLine($"\nTotal a pagar: {totalFinal}");

Console.ReadLine();

Console.WriteLine();

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();

Console.WriteLine($"       {NombreComercio}");

for (int i = 0;i < 30;i++)
{
    Console.Write("-");
}
Console.WriteLine() ;

Console.WriteLine($"Cajero: {cajero}");
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {subtotal}");
Console.WriteLine($"Descuento: {descuentoTotal}");
Console.WriteLine($"Recargo: {recargoCreditoMonto}");

for(int i = 0; i < 30; i++)
{
    Console.Write("-");
}