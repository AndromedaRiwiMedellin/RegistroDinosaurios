namespace DefaultNamespace;

using Registro.Application.DTOs;
using Registro.Application.Interfaces;
using Registro.Domain.Repositories;
using Registro.Domain.Entities;
using System.Linq;

namespace Registro.Application.Services;


public class DinosaurQueryService : IDinosaurQueryService
{
    private readonly IDinosaurQueryRepository _repository;
    
    public DinosaurQueryService(IDinosaurRepository repository)
    {
        _repository = repository;
    }
    
    
    // Filtros
    public async Task<IEnumerable<DinosaurDto>> GetAll()
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }
      public async Task<IEnumerable<DinosaurDto>> GetByZone(string zona)
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .Where(d => d.Zona == zona)
            .Select(d => new DinosaurDto
            {   
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }

    public async Task<IEnumerable<DinosaurDto>> GetByEmail( string Email)
    {
        var Dinosaurs = Await _repository.GetAll();
        return Dinosaurs.Where(d => d.email)
            .Where(d => d.Email == Email)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            })
    }
    
      // filtro por el ID
    public async Task<DinosaurDto> GetById(int Id)
    {
        var dinosaurs = await _repository.GetAll();
        return dinosaurs
            .Where(d => d.Id == Id)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            })
            .FirstOrDefault(d => d.Id == id);
    }

    public async Task<IEnumerable<DinosaurDto>> GetBySector(string sector)
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .Where(d => d.Sector == sector)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }

    public async Task<IEnumerable<DinosaurDto>> GetByAge(int age)
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .Where(d => d.Edad == age)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }


    public async Task<IEnumerable<DinosaurDto>> GetNameById(string name)
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .Where(d => d.Nombre == name)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
        
            });
    }
    }

    public async Task<IEnumerable<DinosaurDto>> GetMayoresByAge(int age)
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .Where(d => d.Edad > age)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }

    
    public async Task<IEnumerable<DinosaurDto>> GetByEspecie(string especie)
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .Where(d => d.Especie == especie)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }

    // Ordenamientos
    public async Task<IEnumerable<DinosaurDto>> OrderByEspecie()
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .OrderBy(d => d.Especie)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }

    public async Task<IEnumerable<DinosaurDto>> OrderByZona()
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .OrderBy(d => d.Zona)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }

    public async Task<IEnumerable<DinosaurDto>> OrderBySector()
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .OrderBy(d => d.Sector)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }

    public async Task<IEnumerable<DinosaurDto>> OrderByAge()
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .OrderBy(d => d.Edad)
            .Select(d => new DinosaurDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Especie = d.Especie,
                Email = d.Email,
                Edad = d.Edad,
                Zona = d.Zona,
                Sector = d.Sector
            });
    }
    
    // Agrupaciones
    
    public async Task<IEnumerable<object>> GroupByZona()
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .GroupBy(d => d.Zona)
            .Select(g => new
            {
                Zona = g.Key,
                Cantidad = g.Count()
            });
    }
    
    public async Task<IEnumerable<object>> GroupBySector()
    {
        var dinosaurs = await _repository.GetAll();

        return dinosaurs
            .GroupBy(d => d.Sector)
            .Select(g => new
            {
                Sector = g.Key,
                Cantidad = g.Count()
            });
    }

   
    
    
}