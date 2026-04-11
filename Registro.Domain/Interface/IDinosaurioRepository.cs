using Registro.Domain.Entities;

namespace Registro.Domain.Interface;

public interface IDinosaurioRepository
{
    Task<IEnumerable<Dinosaurio>> GetAll();

    Task<Dinosaurio> GetById(int id);

    Task Add(Dinosaurio dinosaurio);

    Task Update(Dinosaurio dinosaurio);

    Task Delete(int id);
}
