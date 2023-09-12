

using EstructuraDedatos_del_diagrama;
//clase ExAlumno con herencia de la clase MiembroDeLacomunidad//
public class ExAlumno : MiembroDeLacomunidad
{
    public int AñoGraduacion { get; set; }

    public void RecordarTiempoEnLaEscuela()
    {
        Console.WriteLine($"Me gradué en el año {AñoGraduacion}.");
    }
}

