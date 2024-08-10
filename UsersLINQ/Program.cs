using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserslINQ
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string CorreoElectronico { get; set; }
}

class Program
{
    static void Main()
    {
        List<UserslINQ> usuarios = new List<UserslINQ>
        {
            new UserslINQ { Id = 1, Nombre = "Ana", Edad = 25, CorreoElectronico = "ana@example.com" },
            new UserslINQ { Id = 2, Nombre = "Luis", Edad = 17, CorreoElectronico = "luis@gmail.com" },
            new UserslINQ { Id = 3, Nombre = "Carlos", Edad = 30, CorreoElectronico = "carlos@example.com" },
            new UserslINQ { Id = 4, Nombre = "Maria", Edad = 22, CorreoElectronico = "maria@other.com" }
        };

        // Obtener todos los usuarios mayores de 18 años
        var usuariosMayores = usuarios.Where(u => u.Edad > 18).ToList();

        Console.WriteLine("Usuarios mayores de 18 años:");
        foreach (var usuario in usuariosMayores)
        {
            Console.WriteLine($"{usuario.Nombre}, Edad: {usuario.Edad}");
        }

        // Ordenar los usuarios por su nombre
        var usuariosOrdenados = usuarios.OrderBy(u => u.Nombre).ToList();

        Console.WriteLine("\nUsuarios ordenados por nombre:");
        foreach (var usuario in usuariosOrdenados)
        {
            Console.WriteLine($"{usuario.Nombre}, Edad: {usuario.Edad}");
        }

        // Contar usuarios con correo "@example.com"
        int countExampleEmails = usuarios.Count(u => u.CorreoElectronico.EndsWith("@example.com"));

        Console.WriteLine($"\nNúmero de usuarios con correo '@example.com': {countExampleEmails}");
    }
}
