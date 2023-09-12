
namespace EstructuraDedatos_del_diagrama
{
    // Gregory  acosta ,matricula :2022-1974//

    // clase con el metodo main//
    class Program
    {
        static void Main(string[] args)
        {  //Instancias creadas de los objetos de las clases creadas//
            var estudiante = new Estudiante
            {
                CursoActual = "Matemáticas",
                Calificaciones = 95.5
            };
            Console.WriteLine(estudiante.Presentarse());
            estudiante.Estudiar();

            var docente = new Docente
            {
                Departamento = "Ciencias",
                Salario = 50000,
                Materia = "Física"
            };

            Console.WriteLine(docente.Presentarse());
            docente.Enseñar();
        }


    }
}