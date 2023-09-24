
// clase abstrac base MiembroDeLacomunidad //
public abstract class MiembroDeLacomunidad
    {
    public string Nombre { get; set; }
    public int Edad {  get; set; }

    public void presentarse()
    {
        Console.WriteLine($"Saludos, mi nombre es {Nombre} y mi edad actual es de {Edad}");
    }

       
    }

