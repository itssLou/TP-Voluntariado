using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Persona> personas = new List<Persona>();

        int opcion;

        do
        {
            Console.WriteLine("Bienvenido a Sistema De Voluntariado");
            Console.WriteLine("1 - Agregar Voluntario");
            Console.WriteLine("2 - Agregar Coordinador");
            Console.WriteLine("3 - Ver Personas");
            Console.WriteLine("4 - Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.Write("Nombre: ");
                    string nombredeVolunt = Console.ReadLine();

                    Console.Write("Edad: ");
                    int edadVolunt = int.Parse(Console.ReadLine());

                    Console.Write("Horas trabajadas: ");
                    int horas = int.Parse(Console.ReadLine());

                    personas.Add(new Voluntario(nombredeVolunt, edadVolunt, horas));

                    Console.WriteLine("Voluntario registrado");
                    break;

                case 2:

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Edad: ");
                    int edadCoord = int.Parse(Console.ReadLine());

                    Console.Write("Area asignada: ");
                    string area = Console.ReadLine();

                    Console.Write("Cantidad de personas a cargo: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    personas.Add(new Coordinador(nombre, edadCoord, area, cantidad));

                    Console.WriteLine("Coordinador registrado");
                    break;

                case 3:

                    Console.WriteLine("Lista de personas");

                    if (personas.Count == 0)
                    {
                        Console.WriteLine("No registraste personas");
                    }
                    else
                    {
                        foreach (Persona persona in personas)
                        {
                            persona.MostrarInfo();
                            Console.WriteLine("------------------");
                        }
                    }

                    break;

                case 4:

                    Console.WriteLine("Saliendo...");
                    break;

                default:

                    Console.WriteLine("No existe opcion");
                    break;
            }

        } while (opcion != 4);
    }
}