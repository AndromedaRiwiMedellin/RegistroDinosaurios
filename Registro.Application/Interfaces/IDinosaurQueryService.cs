namespace DefaultNamespace;

using Registro.Application.DTOs;

namespace Registro.Application.Interfaces;

public interface IDinosaurQueryService
{
    Task<IEnumerable<DinosaurDto>> GetByZona(string zona);
    
    Task<IEnumerable<DinosaurDto>> GetBySector(string sector);
    
    Task<IEnumerable<DinosaurDto>> GetByEdad(int edad);
    
    Task<IEnumerable<DinosaurDto>> GetOrdenadoPorEspecie();
}