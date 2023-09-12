

//Clase Estudiante con herencia de la clase MiembroDeLacomunidad//
public class Estudiante : MiembroDeLacomunidad
{
    public string? CursoActual { get; set; }
    public double Calificaciones { get; set; }

    public string Presentarse()
    {
        return $"Soy un estudiante en el curso de {CursoActual} y mi calificación es {Calificaciones}";
    }


    public void Estudiar()
    {
        Console.WriteLine($"Estoy estudiando el curso {CursoActual}.");

    }

   
}