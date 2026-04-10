using Microsoft.EntityFrameworkCore;
using Registro.Domain.Entities;
using Registro.Domain.Enums;

namespace Registro.Application.Services;

public class ServicioDinosaurio
{
    private List<Dinosaurio> _dinosaurios = new List<Dinosaurio>();

    public string RegistrarDinosaurio(Dinosaurio nuevoDino)
    {
        if (_dinosaurios.Any(d => d.Id == nuevoDino.Id))
        {
            return "El id de Dinosaurio que digitaste ya esta registrado en el sistema";
        }else if (_dinosaurios.Any(d => d.Username == nuevoDino.Username))
        {
            return "El UserName que digitaste ya esta registrado en el sistema";
        }else if (_dinosaurios.Any(d => d.Email == nuevoDino.Email))
        {
            return "El Email que digitaste ya esta registrado en el sistema";
        }
        else
        {
            _dinosaurios.Add(nuevoDino);
            return "Dinosaurio agregado correctamente";
        }
        
    }
    
    public string EliminarDinosaurio(Dinosaurio eliminarDino)
    {
        if (_dinosaurios.RemoveAll(d => d.Username == eliminarDino.Username) > 0)
        {
            return "Dinosaurio eliminado exitosamente";
        }
        return "No se encontró ningún dinosaurio con ese Username";
    }

    private Dinosaurio? BuscadorDinosaurios(string BuscarDinosaurios)
    {
        return _dinosaurios.FirstOrDefault(d => d.Username == BuscarDinosaurios);
        
    }
    
    public string ActualizarContraseña(string Password, string Username)
    {
            var DinosaurioEncontrado = BuscadorDinosaurios(Username);
            if (DinosaurioEncontrado != null)
            {
                
                DinosaurioEncontrado.Password = Password;
                return "Contraseña actualizada exitosamente";
                
            }
            else
            {
                return "El Dinosaurio no fue encontrado";
            }
           
            
    }

    public List<Dinosaurio> ListarDinosaurios()
    {
        return _dinosaurios.OrderBy(d => d.Username).ToList();
    }
    
    public int ContarDinosaurios()
    {
        return _dinosaurios.Count;
    }

}

