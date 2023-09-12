

// clase Administrador con herencia de la clase docente//
public class Administrador : Docente
{
    public string Rol { get; set; }

    public void GestionarRecursos()
    {
        Console.WriteLine($"Soy un administrador con rol {Rol}.");
    }
}
