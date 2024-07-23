

namespace Practicas
{
    public class Imprimir
    {
        public void Imprime(string[] args)
        {
            Persona persona = new Persona()   
            {
                Nombre = "carlos",
                Edad = 27,
                Direccion = "Calle",
                CorreoElectronico = "carlos@gmail.com"


            };


            IEnviarCorreo enviarCorreo = new EnviarCorreo();
            enviarCorreo.EnviarCorreo(persona);

            IImprimirDatos imprimirDatos = new ImpresorDeDatos();
            imprimirDatos.ImprimirDatos(persona);

        }

    }
}
