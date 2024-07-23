

namespace Practicas
{
    public interface IEnviarCorreo
    {
        void EnviarCorreo(Persona persona);


    }


    public class EnviarCorreo : IEnviarCorreo
    {
        void IEnviarCorreo.EnviarCorreo(Persona persona)
        {
            Console.WriteLine($"EnviarCorreo: {persona.CorreoElectronico}");
        }
    }
}
