using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOOMapaDeClasesYinet
{
    public class MiembroDeLaComunidad 
    { 
        public string Nombre { get; set; } = string.Empty;
        public int Id { get; set; } 
        public virtual void MostrarRol() 

        { 
            Console.WriteLine("Soy un miembro de la comunidad.");
        }
    }
}
