using System.Diagnostics.Contracts;
using Proyecto_1_Pensamiento_Computacional;
string nombre = "";
int nit = 0;
int opcionCambios;
string fechaInicio = DateTime.Now.ToString("");
string consumidorFinal="Consumidor final";
Licuado objLicuado = new Licuado(); // Se creó el objeto licuado.
Cliente objcliente = new Cliente(); // Se creó el objeto cliente.
Console.WriteLine("🍓¡Bienvenido!🍓");
Console.WriteLine("Por favor, ingrese los datos que se lo solicitarán a continuación:");
Console.WriteLine("Ingrese su nombre 💁:");
nombre = objcliente.nombreCliente(Console.ReadLine()); //Se declara la variable en base al objeto.
objLicuado.precioTotal = objLicuado.precioInicial; 
Console.WriteLine("");
Console.WriteLine("¿Desea agregar nit?");
Console.WriteLine("0. No");
Console.WriteLine("1. Si");
int preguntaNit = int.Parse(Console.ReadLine());
switch (preguntaNit) //Se creó un switch para las condiciones de Nit.
{
    case 0: 
    Console.WriteLine("");
    Console.WriteLine("Consumidor final");
    break;

    case 1:
    Console.WriteLine("");
    Console.WriteLine("Ingrese su nit: ");
    nit = objcliente.nitCliente(int.Parse(Console.ReadLine()));
    break;
}

do // se utiliza el ciclo do while para que se repita el menú hasta que cumpla cierta condición 
{
Console.WriteLine("");
Console.WriteLine("El licuado estrella es el de fresa con leche deslactosada sin azúcar, el cual tiene un precio de : Q. 20.00");
Console.WriteLine("¿Qué desea modificar?");
Console.WriteLine("");
Console.WriteLine("1. Agregar Azúcar 🍬");
Console.WriteLine("2. Modificar Leche 🐮");
Console.WriteLine("3. Agrandar 💢");
Console.WriteLine("4. Confirmar ✅");
opcionCambios=Convert.ToInt32(Console.ReadLine());


switch (opcionCambios) //Se creó un switch para las condiciones del tipo azúcar dentro de este se creó un menú con los tipos de azúcar disponibles 
    {
        case 1:
            objLicuado.tipoAzucar();
            break;

        case 2:
            objLicuado.tipoLeche();
            break;
        case 3:
            objLicuado.Agrandar(); //Se establece la condición para modificar el tamaño del licuado.
            break;

    }
} while (opcionCambios < 4); // Condicion para que pare el bucle

string fechaFinalizacion = DateTime.Now.ToString("");
Console.WriteLine("");
Console.WriteLine("------------------------------------------");
Console.WriteLine("Factura:");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");
Console.WriteLine($"Nombre: {nombre}"); //Se establecen los datos para generar una factura.
if (preguntaNit == 1) //Condición if que evalua si el usuario desea nit o no.
{
    Console.WriteLine($"NIT: {nit}"); 
}
else
{
    Console.WriteLine("Consumidor final");
}
Console.WriteLine($"Fecha y hora de inicio: {fechaInicio}");
Console.WriteLine("Detalles del licuado:");
objLicuado.MostrarDatosLicuado(); //Se llama a mostrarDatosLicuado mediante el objeto licuado.
Console.WriteLine($"Fecha y hora de finalización: {fechaFinalizacion}");
Console.WriteLine("");
Console.WriteLine("Aquí tiene su licuado 🥤 ¡Qué lo disfrute! 😁");

