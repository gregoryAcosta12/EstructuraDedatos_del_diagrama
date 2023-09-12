

using EstructuraDedatos_del_diagrama;
// Clase Empleado con herencia de la clase MiembroDeLacomunidad//
public class Empleado : MiembroDeLacomunidad
{
    public string Departamento { get; set; }
    public double Salario { get; set; }

    public void Trabajar()
    {
        Console.WriteLine($"Soy un empleado del departamento {Departamento}.");
    }
}