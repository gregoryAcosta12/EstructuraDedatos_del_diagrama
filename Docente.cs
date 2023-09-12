

//Clase Docente con herencia de la clase Empleado//
public class Docente : Empleado
{
    public string Departamento { get; set; }
    public double Salario { get; set; }
    public string Materia { get; set; }

    public string Presentarse()
    {
        return $"Soy un docente del departamento de {Departamento} enseñando {Materia} y mi salario es {Salario}";
    }
    public void Enseñar()
    {
        Console.WriteLine($"Soy docente y enseño {Materia}.");
    }

    
}

