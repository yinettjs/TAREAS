 using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOOMapaDeClasesYinet
{
    public class Estudiante : MiembroDeLaComunidad 
    { 
        public string Carrera { get; set; } = string.Empty;
        public override void MostrarRol()

        { 
            Console.WriteLine("Soy un estudiante.");
        }
    }
}