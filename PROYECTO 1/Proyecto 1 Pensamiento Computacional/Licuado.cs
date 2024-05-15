using System.Runtime.InteropServices.Marshalling;

namespace Proyecto_1_Pensamiento_Computacional;

public class Licuado // Se creó una clase para el licuado 
{
    int cucharaditaAzucar; // Se declaran las variables a utilizar 
    double precioAzucar; 
    string nombreAzucar;
    double precioLeche;
    int tamañoLicuado;
    public double precioInicial=20.00;
    public double precioTotal;
    string nombreLeche = "Leche deslactosada";
    public void tipoAzucar () // Se creó una clase para mofificar según las opciones del azúcar
    {
        Console.WriteLine("");
        Console.WriteLine ("Ingrese el tipo de azúcar que desea");
        Console.WriteLine("");
        Console.WriteLine ("1. Azúcar Blanca - Q0.60");    
        Console.WriteLine ("2. Azúcar Morena - Q0.40");   
        Console.WriteLine ("3. Suplemento - Q0.90");  
        int opcionAzucar = int.Parse (Console.ReadLine ());
        Console.WriteLine("");

        Console.WriteLine ("¿Cuántas cucharaditas de azúcar desea agregar? (Máximo 3 cucharaditas)"); // se solicita la cantidad de cucharadas de azúcar
        cucharaditaAzucar = int.Parse (Console.ReadLine ());
        Console.WriteLine("");

        switch (opcionAzucar) // Se utiliza un switch para realizar las restricciones del menú
        {
            case 1:
            if (cucharaditaAzucar <=3)  // Se utiliza la condición if, para realizar las restricciones de la cantidad de cucharaditas a utilizar
            {
                nombreAzucar = "Azúcar Blanca";
                precioAzucar = cucharaditaAzucar * 0.60; // Se multiplica la cantidad de cucharaditas de azúcar deseadas por el precio que aumenta
            }
            else if (cucharaditaAzucar >3) 
            {
                Console.WriteLine("No puede agregar más de tres cucharaditas"); // Se explica el error
            }
            break;
       
            case 2:
            if (cucharaditaAzucar <=3) 
            {
                nombreAzucar = "Azúcar Morena";
                precioAzucar = cucharaditaAzucar*0.40;  // Se multiplica la cantidad de cucharaditas de azúcar deseadas por el precio que aumenta
            }
             else if (cucharaditaAzucar > 3)   
            {
                Console.WriteLine("No puede agregar más de tres cucharaditas"); // Se explica el error
            }
            break;

             case 3:
            if (cucharaditaAzucar <=3)
            {
                nombreAzucar= "Suplemento";
                precioAzucar=cucharaditaAzucar*0.90;  // Se multiplica la cantidad de cucharaditas de azúcar deseadas por el precio que aumenta
            }
             else if (cucharaditaAzucar > 3)
            {
                Console.WriteLine("No puede agregar más de tres cucharaditas"); // Se explica el error que sucede al ingresar más de tres cucharadistas
            }
            break;

            case 4:
            break;

            default: // El ciclo switch acaba y se genera esta condición de error, por si es ingresado un dato no permitido
            Console.WriteLine("Opción Inválida");
            break;
        }
        Console.WriteLine($"Fueron agregadas {cucharaditaAzucar} cucharaditas de {nombreAzucar}, por lo que, el precio aumentó por Q.{precioAzucar}");
        Console.WriteLine("");
        
        precioTotal = precioInicial + precioAzucar; //Se suma el precio inicial + el precio del azúcar y se guarda en el precio total

    }   


    public void tipoLeche() //Se creó una clase para realizar los cambios según las opciones de la leche
    {
        Console.WriteLine("");
        Console.WriteLine ("¿Qué tipo de leche desea?");
        Console.WriteLine("");
        Console.WriteLine ("1. Sin leche (únicamente con agua) - Descuento de Q. 3.00");    
        Console.WriteLine ("2. Leche deslactosada");   
        Console.WriteLine ("3. Leche entera");   
        Console.WriteLine ("4. Leche de soya - Aumento de Q. 2.00");  
        int tipoLeche = Convert.ToInt32(Console.ReadLine());

        switch (tipoLeche) //Se utilizó un switch para realizar el menú con las condiciones requeridas
        {
            case 1:
                precioLeche = -3.00;
                precioTotal = precioTotal + precioLeche; //Se realiza el descuento de la leche al precio total y se guarda en el precio total
                Console.WriteLine("");  
                Console.WriteLine("Por esta opción recibe un descuento de Q. 3.00");
                Console.WriteLine("");
                nombreLeche = "Con agua";
                break;

            case 2:
                precioLeche = 0;
                precioTotal = precioTotal;
                Console.WriteLine("");
                Console.WriteLine("El precio no sufre ningún aumento ni descuento"); //Se explica que el precio no varia
                Console.WriteLine("");
                nombreLeche = "Leche deslactosada";
                break;

            case 3:
                precioLeche = 0;
                precioTotal = precioTotal;
                Console.WriteLine("El precio no sufre ningún aumento ni descuento"); //Se explica que el precio no varia
                Console.WriteLine("");
                nombreLeche = "Leche entera";
                break;

            case 4:
                precioLeche = 2;
                precioTotal = precioTotal + precioLeche; //Se suma el aumento que tiene la leche de soya y se guarda en el precio total
                Console.WriteLine("El precio aumenta Q. 2.00");
                Console.WriteLine("");
                nombreLeche= "Leche de soya";
                break;

            case 5:
                break;
            
            default: 
                Console.WriteLine("Opción Inválida"); // El ciclo switch acaba y se genera esta condición de error, por si es ingresado un dato no permitido
                Console.WriteLine("");
                break;

        }
    }
    
    public void Agrandar() //Se creó una clase para poder agrandar el licuado
    {
        Console.WriteLine("");
        Console.WriteLine ("¿Desea agrandar el licuado?");
        Console.WriteLine("");
        Console.WriteLine ("1. Sí");    
        Console.WriteLine ("2. No");   
        tamañoLicuado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        switch (tamañoLicuado) //Se utilizó un switch para realizar el menú con las condiciones requeridas
        {
            case 1:
                precioTotal = precioTotal + (precioInicial * 0.07); // Se calcula el 7% que se aumentará utilizando el percio inicial
                Console.WriteLine("El precio aumentó el 7%");
                Console.WriteLine("");
                break;
            case 2: 
                precioTotal = precioTotal;
                Console.WriteLine("El precio no cambia"); // Se explica que el precio no varía
                Console.WriteLine("");
                break;
            case 3:
                break;
            default:
                Console.WriteLine("Opción Inválida"); // El ciclo switch acaba y se genera esta condición de error, por si es ingresado un dato no permitido
                Console.WriteLine("");
                break;
        }


    }

    public void MostrarDatosLicuado () // Se creó una clase para generar la factura, es decir, mostrar los datos del licuado
    {
        Console.WriteLine("El precio inicial es de " + precioInicial); // Se muestra en pantalla el precio inicial 
        Console.WriteLine("");
        Console.WriteLine($"Cucharaditas de azúcar: {cucharaditaAzucar}"); // Se muestra en pantalla la cantidad de cucharaditas de azúcar
        Console.WriteLine($"Tipo de azúcar: {nombreAzucar}"); // Se muestra en pantalla el tipo de azúcar
        Console.WriteLine("Precio del azúcar:  Q." + String.Format("{0:#,##0.00}",precioAzucar)); // Se muestra en pantalla el precio por la cantidad de cucharaditas de azúcar
        Console.WriteLine("");
        Console.WriteLine($"Tipo de leche: {nombreLeche}"); // Se muestra en pantalla el tipo de leche
        Console.WriteLine($"Precio leche: {precioLeche}");// Se muestra en pantalla el precio según el tipo de leche
        Console.WriteLine("");
        if (tamañoLicuado == 1)// Se muestra en pantalla si es agrandado o no según la condición 
        {
            Console.WriteLine("Agrandado"); 
            Console.WriteLine("El precio aumentó aumentó el 7%"); 
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Normal"); 
            Console.WriteLine("El precio no cambia"); 
            Console.WriteLine("");

        }
        Console.WriteLine("El precio Total es de " +String.Format( "{0:#,##0.00}", precioTotal)); // Se muestra en pantalla el precio total

        
    }

}
