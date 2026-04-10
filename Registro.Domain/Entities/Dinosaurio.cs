using Registro.Domain.Enums;

namespace Registro.Domain.Entities;

public class Dinosaurio
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string UserName { get; set; }
    public TipoDinosaurio Tipo { get; set; }
    public string Contrasena { get; set; }
    public string Email { get; set; }

    public Dinosaurio(int id, string nombre,  string userName, TipoDinosaurio tipo, string contrasena, string email)
    {
        Id = id;
        Nombre = nombre;
        UserName = userName;
        Tipo = tipo;
        Contrasena = contrasena;
        Email = email;
    }
}