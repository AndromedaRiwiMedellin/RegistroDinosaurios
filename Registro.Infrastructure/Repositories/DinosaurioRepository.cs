using Microsoft.EntityFrameworkCore;
using Registro.Domain.Entities;
using Registro.Domain.Interface;
using Registro.Infrastructure.Persistence;

namespace Registro.Infrastructure.Repositories;

public class DinosaurioRepository : IDinosaurioRepository
{
    private readonly DinosaurioDbContext _context;

    public DinosaurioRepository(DinosaurioDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Dinosaurio>> GetAll()
    {
        return await _context.Dinosaurios.ToListAsync();
    }

    public async Task<Dinosaurio> GetById(int id)
    {
        return await _context.Dinosaurios.FindAsync(id);
    }

    public async Task Add(Dinosaurio dinosaurio)
    {
        await _context.Dinosaurios.AddAsync(dinosaurio);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Dinosaurio dinosaurio)
    {
        _context.Dinosaurios.Update(dinosaurio);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var dinosaurio = await _context.Dinosaurios.FindAsync(id);
        if (dinosaurio != null)
        {
            _context.Dinosaurios.Remove(dinosaurio);
            await _context.SaveChangesAsync();
        }
    }
}
