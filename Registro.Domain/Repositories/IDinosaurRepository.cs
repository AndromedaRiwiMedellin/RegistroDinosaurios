namespace DefaultNamespace;

using Registro.Domain.Entities;

namespace Registro.Domain.Repositories;

public interface IDinosaurRepository
{
    Task<IEnumerable<Dinosaur>> GetAll();

    Task<Dinosaur> GetById(int id);

    Task Add(Dinosaur dinosaur);

    Task Update(Dinosaur dinosaur);

    Task Delete(int id);
}