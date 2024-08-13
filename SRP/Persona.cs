
namespace SRP
{
    public class Persona
    {
        private string? nombre {  get; set; }
        private int edad {  get; set; }
        private string? direccion { get; set; }
        private string? correoElectronico { get; set; }

        public class EnviarCorreoElectronico
        {
            public decimal Enviar(string correo, string asunto, string mensaje)
            
            { 
            // Logica para Enviar Correo
            }
        }

    public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"Correo Electronico: {correoElectronico}");

        }
    }
}
