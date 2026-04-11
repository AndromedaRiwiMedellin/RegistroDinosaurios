using Registro.Domain.Entities; 
using Registro.Application.DTOs;

namespace Registro.Application.Interfaces;

public interface IDinosaurioQueryService
{
    // Filtros
    Task<DinosaurioDto?> GetById(int id);
    Task<IEnumerable<DinosaurioDto>> GetAll();
    Task<IEnumerable<DinosaurioDto>> GetByEmail(string email);
    Task<IEnumerable<DinosaurioDto>> GetByEspecie(string especie);
    Task<IEnumerable<DinosaurioDto>> GetByAge(int age);
    Task<IEnumerable<DinosaurioDto>> GetMayoresByAge(int age);
    Task<IEnumerable<DinosaurioDto>> GetByNombre(string nombre);

    // Ordenamientos
    Task<IEnumerable<DinosaurioDto>> OrderByEspecie();
    Task<IEnumerable<DinosaurioDto>> OrderByAge();

    // Agrupaciones
    Task<IEnumerable<object>> GroupByEspecie();
}