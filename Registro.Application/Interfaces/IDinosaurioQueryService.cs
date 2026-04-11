using Registro.Domain.Entities;

namespace Registro.Application.Interfaces;

public interface IDinosaurioQueryService
{
    // Filtros
    Task<Dinosaurio?> GetById(int id);
    Task<IEnumerable<Dinosaurio>> GetAll();
    Task<IEnumerable<Dinosaurio>> GetByEmail(string email);
    Task<IEnumerable<Dinosaurio>> GetByEspecie(string especie);
    Task<IEnumerable<Dinosaurio>> GetByAge(int age);
    Task<IEnumerable<Dinosaurio>> GetMayoresByAge(int age);
    Task<IEnumerable<Dinosaurio>> GetByNombre(string nombre);

    // Ordenamientos
    Task<IEnumerable<Dinosaurio>> OrderByEspecie();
    Task<IEnumerable<Dinosaurio>> OrderByAge();

    // Agrupaciones
    Task<IEnumerable<object>> GroupByEspecie();
}
