using Registro.Domain.Enum;

namespace Registro.Application.DTOs;

public class DinosaurioDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public DinosaurioEnum Especie { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int? Age { get; set; }
    public string? Direccion { get; set; }
    public string? Ciudad { get; set; }
    public string? Pais { get; set; }
}