namespace DefaultNamespace;

using Registro.Application.DTOs;

namespace Registro.Application.Interfaces;

public interface IDinosaurQueryService
{
    //Filtros
    Task<IEnumerable<DinosaurDto>> GetByZona(string zona);
    
    Task<IEnumerable<DinosaurDto>> GetBySector(string sector);
    
    Task<IEnumerable<DinosaurDto>> GetByAge(int age);
    Task<IEnumerable<DinosaurDto>> GetByEspecie(string especie);
    
    //ordenamientos
    
    Task<IEnumerable<DinosaurDto>> GetOrdenadoPorEspecie();
    
    Task<IEnumerable<DinosaurDto>> OrderByZona();
    Task<IEnumerable<DinosaurDto>> OrderBySector();
    Task<IEnumerable<DinosaurDto>> OrderByAge();
    Task<IEnumerable<DinosaurDto>> OrderByEspecie();
    
    // Agrupaciones
    Task<IEnumerable<object>> GroupByZona();
    Task<IEnumerable<object>> GroupBySector();
    
}