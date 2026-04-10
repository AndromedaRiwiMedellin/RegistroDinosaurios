using Registro.Domain.Interfaces;
using Registro.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Registro.Domain.Entities;

public class Dinosaurio
{
    [Key]
    public int Id { get; set; }
    public required string Nombre { get; set; } 
    public DinosaurioEnum Especie { get; set; }
    public required string Username { get; set; } 
    public required string Email { get; set; } 
    public required string Password { get; set; }  
    public int Age { get; set; }
    public required string Direccion { get; set; } 
    public string Ciudad { get; set; }
    public string Pais { get; set; }
}