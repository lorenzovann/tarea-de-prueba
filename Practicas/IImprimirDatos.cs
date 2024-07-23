

namespace Practicas
{
    public interface IImprimirDatos
    {
       void ImprimirDatos(Persona persona);
    }

    public class ImpresorDeDatos : IImprimirDatos
    {
        

        void IImprimirDatos.ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre {persona.Nombre}");
            Console.WriteLine($"Edad {persona.Edad}");
            Console.WriteLine($"Direccion {persona.Direccion}");
            Console.WriteLine($"CorreoElectronico {persona.CorreoElectronico}");
        }

        
    }
}
