//clase Maestro con herencias de la clase MiembroDeLacomunidad//
public class Maestro : Docente
{   
    public string NivelEducacion { get; set; }

    public void DarClases()
    {
        Console.WriteLine($"Soy un maestro con nivel de educación {NivelEducacion}.");
    }
}