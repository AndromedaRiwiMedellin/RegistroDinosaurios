using Microsoft.EntityFrameworkCore;
using Registro.Application.DTOs;
using Registro.Infrastructure;
using Registro.Application.Interfaces;
using Registro.Domain.Entities;

namespace Registro.Application.Services;

public class DinosaurQueryService : IDinosaurioQueryService
{
    private readonly DinosaurioDbContext _context;
    public DinosaurQueryService(DinosaurioDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<DinosaurioDto>> GetAll()
    {
        return await _context.Dinosaurios
            .Select(d => new DinosaurioDto
            {
                Id = d.Id, Nombre = d.Nombre, Especie = d.Especie,
                Username = d.Username, Email = d.Email, Age = d.Age,
                Direccion = d.Direccion, Ciudad = d.Ciudad, Pais = d.Pais
            })
            .ToListAsync();
    }

    public async Task<DinosaurioDto?> GetById(int id)
    {
        return await _context.Dinosaurios
            .Where(d => d.Id == id)
            .Select(d => new DinosaurioDto
            {
                Id = d.Id, Nombre = d.Nombre, Especie = d.Especie,
                Username = d.Username, Email = d.Email, Age = d.Age,
                Direccion = d.Direccion, Ciudad = d.Ciudad, Pais = d.Pais
            })
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<DinosaurioDto>> GetByEmail(string email)
    {
        return await _context.Dinosaurios
            .Where(d => d.Email == email)
            .Select(d => new DinosaurioDto
            {
                Id = d.Id, Nombre = d.Nombre, Especie = d.Especie,
                Username = d.Username, Email = d.Email, Age = d.Age,
                Direccion = d.Direccion, Ciudad = d.Ciudad, Pais = d.Pais
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<DinosaurioDto>> GetByEspecie(string especie)
    {
        return await _context.Dinosaurios
            .Where(d => d.Especie.ToString() == especie)
            .Select(d => new DinosaurioDto
            {
                Id = d.Id, Nombre = d.Nombre, Especie = d.Especie,
                Username = d.Username, Email = d.Email, Age = d.Age,
                Direccion = d.Direccion, Ciudad = d.Ciudad, Pais = d.Pais
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<DinosaurioDto>> GetByAge(int age)
    {
        return await _context.Dinosaurios
            .Where(d => d.Age == age)
            .Select(d => new DinosaurioDto
            {
                Id = d.Id, Nombre = d.Nombre, Especie = d.Especie,
                Username = d.Username, Email = d.Email, Age = d.Age,
                Direccion = d.Direccion, Ciudad = d.Ciudad, Pais = d.Pais
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<DinosaurioDto>> GetMayoresByAge(int age)
    {
        return await _context.Dinosaurios
            .Where(d => d.Age > age)
            .Select(d => new DinosaurioDto
            {
                Id = d.Id, Nombre = d.Nombre, Especie = d.Especie,
                Username = d.Username, Email = d.Email, Age = d.Age,
                Direccion = d.Direccion, Ciudad = d.Ciudad, Pais = d.Pais
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<DinosaurioDto>> GetByNombre(string nombre)
    {
        return await _context.Dinosaurios
            .Where(d => d.Nombre == nombre)
            .Select(d => new DinosaurioDto
            {
                Id = d.Id, Nombre = d.Nombre, Especie = d.Especie,
                Username = d.Username, Email = d.Email, Age = d.Age,
                Direccion = d.Direccion, Ciudad = d.Ciudad, Pais = d.Pais
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<DinosaurioDto>> OrderByEspecie()
    {
        return await _context.Dinosaurios
            .OrderBy(d => d.Especie)
            .Select(d => new DinosaurioDto
            {
                Id = d.Id, Nombre = d.Nombre, Especie = d.Especie,
                Username = d.Username, Email = d.Email, Age = d.Age,
                Direccion = d.Direccion, Ciudad = d.Ciudad, Pais = d.Pais
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<DinosaurioDto>> OrderByAge()
    {
        return await _context.Dinosaurios
            .OrderBy(d => d.Age)
            .Select(d => new DinosaurioDto
            {
                Id = d.Id, Nombre = d.Nombre, Especie = d.Especie,
                Username = d.Username, Email = d.Email, Age = d.Age,
                Direccion = d.Direccion, Ciudad = d.Ciudad, Pais = d.Pais
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<object>> GroupByEspecie()
    {
        return await _context.Dinosaurios
            .GroupBy(d => d.Especie)
            .Select(g => new { Especie = g.Key, Cantidad = g.Count() })
            .ToListAsync<object>();
    }
}