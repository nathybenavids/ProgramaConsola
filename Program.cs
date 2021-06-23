using System;

namespace ProgramaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Escriba su apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese el sector donde vive: ");
            string direccionSector = Console.ReadLine();

            Console.Write("Ingrese la calle principal de su domicilio: ");
            string callePrincipal = Console.ReadLine();

            Console.Write("Ingrese la calle secundaria de su domicilio: ");
            string calleSecundaria = Console.ReadLine();

            Console.Write("Escriba su numero de cedula: ");
            string cid = Console.ReadLine();

            Console.Write("¿Que edad tiene?: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);

            Console.Write("Ingrese su numero de telefono: ");
            string telefono = Console.ReadLine();
            float telefono1 = float.Parse(telefono);

            Console.Write("Escriba su correo electronico");
            string correo = Console.ReadLine();
            bool correo1 = correo == "@";

            Console.Write("¿Usted es estudiante? Responda si/no: ");
            string esEstudiante = Console.ReadLine().ToUpper();
            bool esEstudiante1 = esEstudiante == "si";

        }
    }
}
