using Microsoft.EntityFrameworkCore;
using Registro.Domain.Entities; 
using Registro.Domain.Enum;
using Registro.Domain.Interfaces;

public class Program
{
    public static async Task Main(string[] args)
    {
    using var context = new DinosaurioDbContext();
    
    bool continuar = true; 
    int opcion;

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
            {
                bool salirSubmenu = false;

                while (!salirSubmenu)
                {
                    Console.WriteLine("1.registro de dinosaurio");
                    Console.WriteLine("2.salir");
                
                    Console.Write("que opcion deseas realizar(1-2): ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Nombre del dinosaurio:");
                            string nombre = Console.ReadLine();
                            Console.Write(@"Seleccione una especie 
1.  Velociraptor,
2.  Triceratops,
3.  TyrannosaurusRex,
4.  Stegosaurus,
5.  Diplodocus");
                            string option = Console.ReadLine();
                            DinosaurioEnum especie = option switch
                            {
                                "1" => DinosaurioEnum.Velociraptor,
                                "2" => DinosaurioEnum.Triceratops,
                                "3" => DinosaurioEnum.TyrannosaurusRex,
                                "4" => DinosaurioEnum.Stegosaurus,
                                "5" => DinosaurioEnum.Diplodocus
                            };
                            Console.Write("Nombre de usuario:");
                            string username = Console.ReadLine();

                            Console.Write("Email:");
                            string email = Console.ReadLine();

                            Console.Write("Pasword: ");
                            string password = Console.ReadLine();

                            Console.Write("Age: ");
                            if (!int.TryParse(Console.ReadLine(), out int age))
                            {
                                Console.WriteLine("Edad no valida");
                                break;
                            }

                            Console.Write("Direccion:");
                            string direccion = Console.ReadLine();
                        
                            Console.Write("Ciudad:");
                            string ciudad = Console.ReadLine();

                            Console.Write("Pais: ");
                            string pais = Console.ReadLine();

                            var dinosaurio = new Dinosaurio
                            {
                                Nombre = nombre,
                                Especie = especie,
                                Username = username,
                                Email = email,
                                Password = password,
                                Age = age,
                                Direccion = direccion,
                                Ciudad = ciudad,
                                Pais = pais
                            };
                            Console.WriteLine("Guardando Dinosaurio...");
                            await context.Dinosaurios.AddAsync(dinosaurio);
                            await context.SaveChangesAsync();
                            Console.WriteLine("Dinosaurio guardado.");
                            break;
                        case 2:
                            salirSubmenu = true;
                            break;
                    }
                }
                break;
            }

            case 2:
            {
                bool salirSubmenu = false;

                while (!salirSubmenu)
                {
                    Console.WriteLine("1. Listar todos los dinosaurios (reporte general)");
                    Console.WriteLine("2. Ver dinosaurio por Id");
                    Console.WriteLine("3. Ver dinosaurio por código (email)");
                    Console.WriteLine("4. Listar por zona");
                    Console.WriteLine("5. Listar por sector");
                    Console.WriteLine("6. Listar mayores de cierta edad"); Console.WriteLine("7. Listar por tipo (carnívoro/herbívoro)");
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
                            var listaDinosaurios = await context.Dinosaurios.ToListAsync();
                            foreach (var d in listaDinosaurios)
                            {
                                Console.WriteLine($"ID: {d.Id} | Nombre: {d.Nombre} | Especie: {d.Especie} | Username {d.Username} | Pais: {d.Pais}" +
                                                  $"Email: {d.Email} | Password: {d.Password} | Age: {d.Age} | Direcccion {d.Direccion} | Ciudad: {d.Ciudad}");
                            }
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
                            salirSubmenu = true;
                            break;
                    }
                }
                break;
        }

            case 3:
            {
                bool salirSubmenu = false;

                while (!salirSubmenu)
                {
                    Console.WriteLine("1.Actualizar datos de un dinosaurio (nombre, edad, tipo, etc.)");
                    Console.WriteLine("2.Asignar dispositivo de rastreo");
                    Console.WriteLine("3.Actualizar ubicación"); Console.WriteLine("4.salir ");
                
                    Console.WriteLine("que opcion quieres continuar(1-4): ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            var listaDinosaurios = await context.Dinosaurios.ToListAsync();
                            foreach (var d in listaDinosaurios)
                            {
                                Console.WriteLine($"ID: {d.Id} | Nombre: {d.Nombre} | Especie: {d.Especie} | Username {d.Username} | Pais: {d.Pais}" +
                                                  $"Email: {d.Email} | Password: {d.Password} | Age: {d.Age} | Direcccion {d.Direccion} | Ciudad: {d.Ciudad}");
                            }

                            Console.Write("Elije un id para actualizar: ");
                            if (!int.TryParse(Console.ReadLine(), out int id))
                            {
                                Console.WriteLine("Id no valido");
                                break;
                            } 
                            
                            var actualizarDinosaurio =  await context.Dinosaurios.FindAsync(id);
                            if (actualizarDinosaurio == null)
                            {
                                Console.WriteLine("Id no existe");
                                break;
                            }
                            Console.Write("Nombre del dinosaurio:");
                            string nombre = Console.ReadLine();
                            Console.Write(@"Seleccione una especie 
1.  Velociraptor,
2.  Triceratops,
3.  TyrannosaurusRex,
4.  Stegosaurus,
5.  Diplodocus");
                            string option = Console.ReadLine();
                            DinosaurioEnum especie = option switch
                            {
                                "1" => DinosaurioEnum.Velociraptor,
                                "2" => DinosaurioEnum.Triceratops,
                                "3" => DinosaurioEnum.TyrannosaurusRex,
                                "4" => DinosaurioEnum.Stegosaurus,
                                "5" => DinosaurioEnum.Diplodocus
                            };
                            Console.Write("Nombre de usuario:");
                            string username = Console.ReadLine();

                            Console.Write("Email:");
                            string email = Console.ReadLine();

                            Console.Write("Pasword: ");
                            string password = Console.ReadLine();

                            Console.Write("Age: ");
                            if (!int.TryParse(Console.ReadLine(), out int age))
                            {
                                Console.WriteLine("Edad no valida");
                                break;
                            }

                            Console.Write("Direccion:");
                            string direccion = Console.ReadLine();
                        
                            Console.Write("Ciudad:");
                            string ciudad = Console.ReadLine();

                            Console.Write("Pais: ");
                            string pais = Console.ReadLine();
                            
                            actualizarDinosaurio.Nombre = nombre;
                            actualizarDinosaurio.Especie = especie;
                            actualizarDinosaurio.Username = username;
                            actualizarDinosaurio.Email = email;
                            actualizarDinosaurio.Password = password;
                            actualizarDinosaurio.Age = age;
                            actualizarDinosaurio.Direccion = direccion;
                            actualizarDinosaurio.Ciudad = ciudad;
                            actualizarDinosaurio.Pais = pais;
                            
                            await context.SaveChangesAsync();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            salirSubmenu = true;
                            break;
                    }
                } 
                break;
            }

            case 4:
            {
                bool salirSubmenu = false;

                while (!salirSubmenu)
                {
                    Console.WriteLine("1. Eliminar dinosaurio");
                    Console.WriteLine("2. eliminar por username");
                    Console.WriteLine("3. salir");
                
                    Console.WriteLine("que opcion  quieres continuar(1-3): ");  
                    opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        var lista = await context.Dinosaurios.ToListAsync();
                        foreach (var d in lista)
                        {
                            Console.WriteLine($"ID: {d.Id} | Nombre: {d.Nombre} | Especie: {d.Especie}");
                        }
                        
                        Console.Write("Ingresa el ID del dinosaurio a eliminar: ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine("ID no válido.");
                            break;
                        }
                        
                        var dinosaurioEliminar = await context.Dinosaurios.FindAsync(id);
                        if (dinosaurioEliminar == null)
                        {
                            Console.WriteLine("No existe un dinosaurio con ese ID.");
                            break;
                        }
                        
                        Console.Write($"¿Está seguro de eliminar a {dinosaurioEliminar.Nombre}? (S/N): ");
                        string confirmacion = Console.ReadLine() ?? "";

                        if (confirmacion.ToUpper() == "S")
                        {
                            context.Dinosaurios.Remove(dinosaurioEliminar);
                            await context.SaveChangesAsync();
                            Console.WriteLine("Dinosaurio eliminado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Eliminación cancelada.");
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        salirSubmenu = true;
                        break;
                } 
                }
                break;
            }

            case 5:
                continuar = false;
                break;
        }
    } 
    }
}
