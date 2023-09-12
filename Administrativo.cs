
//Clase administrativo con herencia de la clase Empleados//
public class Administrativo : Empleado
{
    public string FuncionAdministrativa { get; set; }

    public void RealizarTareasAdministrativas()
    {
        Console.WriteLine($"Realizo tareas administrativas de {FuncionAdministrativa}.");
    }
}
