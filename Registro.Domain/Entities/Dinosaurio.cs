using Registro.Domain.Interfaces;
using Registro.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Registro.Domain.Entities;

public class Dinosaurio
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; }

    public DinosaurioEnum Especie { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }
}