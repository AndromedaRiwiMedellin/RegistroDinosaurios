using Registro.Domain.Entities;
using Registro.Domain.Enums;

namespace Registro.Application.Services;

public class ServicioDinosaurio
{
    private List<Dinosaurio> _dinosaurios = new List<Dinosaurio>();

    public void RegistrarDinosaurio(Dinosaurio nuevoDino)
    {
        if (_dinosaurios.Any(d => d.Id == nuevoDino.Id))
        {
            Console.WriteLine($"El dinosaurio que digitaste ya esta registrado en el sistema");
        }else if (_dinosaurios.Any(d => d.UserName == nuevoDino.UserName))
        {
            Console.WriteLine("El Username que digitaste ya esta registrado en el sistema");
        }else if (_dinosaurios.Any(d => d.Email == nuevoDino.Email))
        {
            Console.WriteLine("El Email que digitaste ya esta    registrado en el sistema");
        }
        else
        {
            _dinosaurios.Add(nuevoDino);
            Console.Write("Dinosaurio agregado exitosamente");
        }
    }
    
    public void EliminarDinosaurio(Dinosaurio eliminarDino)
    {
        if (_dinosaurios.RemoveAll(d => d.UserName == eliminarDino.UserName) > 0)
        {
            Console.Write("Dinosaurio eliminado exitosamente");
        }
    }

    private Dinosaurio? BuscadorDinosaurios(string BuscarDinosaurios)
    {
        return _dinosaurios.FirstOrDefault(d => d.UserName == BuscarDinosaurios);
        
    }
    
    public void ActualizarContraseña(string Contraseña, string UserName)
    {
            var DinosaurioEncontrado = BuscadorDinosaurios(UserName);
            if (DinosaurioEncontrado != null)
            {
                Console.WriteLine($"Dinosauro encontrado: {DinosaurioEncontrado}");
                DinosaurioEncontrado.Contrasena = Contraseña;
                Console.Write("Los datos han sido actualizados correctamente");
            }
            else
            {
                Console.WriteLine("Dinosauro no encontrado");
            }
            
    }

}

