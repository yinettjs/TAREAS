using ProyectoPOOMapaDeClasesYinet;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine("Bienvenida/o al Menú ");
        Console.WriteLine("1. Estudiante");
        Console.WriteLine("2. Maestro");
        Console.WriteLine("3. Administrador");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine() ?? "0");

        MiembroDeLaComunidad miembro;

        switch (opcion)
        {
            case 1:
                miembro = new Estudiante { Nombre = "Yinet", Carrera = "Ingeniería" };
                break;
            case 2:
                miembro = new Maestro { Nombre = "Starling", Materia = "Programacion" };
                break;
            case 3:
                miembro = new Administrador { Nombre = "Laura", Materia = "Gestión Académica" };
                break;
            default:
                miembro = new MiembroDeLaComunidad { Nombre = "Invitado" };
                break;
        }

        miembro.MostrarRol();
        Console.WriteLine($"Nombre: {miembro.Nombre}");
    }
}
