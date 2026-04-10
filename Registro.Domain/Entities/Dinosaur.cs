namespace DefaultNamespace;

namespace Registro.Domain.Entities;

public class Dinosaur
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Especie { get; set; }

    public int Edad { get; set; }

    public string Zona { get; set; }

    public string Sector { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }

    public bool TieneRastreador { get; set; }

    public string UbicacionActual { get; set; }

    public DateTime FechaRegistro { get; set; }
}