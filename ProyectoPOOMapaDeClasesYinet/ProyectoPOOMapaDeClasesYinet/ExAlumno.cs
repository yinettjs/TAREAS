using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOOMapaDeClasesYinet
{
    public class ExAlumno : MiembroDeLaComunidad 
    { 
        public int AñoGraduacion { get; set; } 
        public override void MostrarRol() 
        {
            Console.WriteLine("Soy un exalumno.");
        }
    }
}
