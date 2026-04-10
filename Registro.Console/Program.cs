

bool continuar = true; 
int opcion ;

while (continuar)
{
    Console.WriteLine("1.registro de dinosaurio");
    Console.WriteLine("2.ver lidts de dinosaurios");
    Console.WriteLine("3.actualizar dinosaurio");
    Console.WriteLine("4.eliminar dinosaurio");
    Console.WriteLine("5.Salir");
    
    Console.WriteLine("que opcion quieres continuar(1-5): ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            while (continuar)
            {
                Console.WriteLine("1.registro de dinosaurio");
                Console.WriteLine("2.salir");
                
                Console.Write("que opcion deseas realizar(1-2): ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        continuar = false;
                        break;
                }
            }
            break;
        case 2:
            while (continuar)
            {
                Console.WriteLine("1. Listar todos los dinosaurios (reporte general)");
                Console.WriteLine("2. Ver dinosaurio por Id");
                Console.WriteLine("3. Ver dinosaurio por código (email)");
                Console.WriteLine("4. Listar por zona");
                Console.WriteLine("5. Listar por sector");
                Console.WriteLine("6. Listar mayores de cierta edad");
                Console.WriteLine("7. Listar por tipo (carnívoro/herbívoro)");
                Console.WriteLine("8. Listado con nombres + códigos");
                Console.WriteLine("9. Contar total de dinosaurios");
                Console.WriteLine("10. contar por zona");
                Console.WriteLine("11. Contar por sector");
                Console.WriteLine("12. Ver dinosaurios sin dispositivo");
                Console.WriteLine("13. Ver dinosaurios sin ubicación");
                Console.WriteLine("14. Últimos registrados");
                Console.WriteLine("15. Ordenados por especie");
                Console.WriteLine("16. Salir");

                Console.Write("Que opcion quieres continuar(1-16): ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break; 
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        continuar = false;
                        break;
                }
    }
            break;
        case 3:
            while (continuar)
            {
                Console.WriteLine("1.Actualizar datos de un dinosaurio (nombre, edad, tipo, etc.)");
                Console.WriteLine("2.Asignar dispositivo de rastreo");
                Console.WriteLine("3.Actualizar ubicación");
                Console.WriteLine("4.salir ");
                
                Console.WriteLine("que opcion quieres continuar(1-4): ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        continuar = false;
                        break;
                }
            }
            break;
        case 4:
            while (continuar)
            {
                Console.WriteLine("1. Eliminar dinosaurio");
                Console.WriteLine("2. eliminar por codigo");
                Console.WriteLine("3. salir");
                
                Console.WriteLine("que opcion  quieres continuar(1-4): ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        continuar = false;
                        break;
                }
            }
            break;
    }
}