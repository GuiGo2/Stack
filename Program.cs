using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Decir "hola mundo"
            // 2) Decir "hola [nombre]!"
            // 9) salir
            string opcion = "";
            while(opcion != "1" && opcion != "2" && opcion != "9")
            {

                // Mostrar menu de opciones
                // Solicitar la opcion al usuario
                Console.WriteLine("1) Decir \"Hola Mundo!\"");
                Console.WriteLine("2) Decir \"Hola [nombre]!\"");
                Console.WriteLine("9) Salir ");



                Console.WriteLine("Por favor selecciona una opciòn:");
                opcion = Console.ReadLine();

                            // Porfavor seleccione una opcion valida hasta que seinstruzca una opcion correcta
                            //mientras no se haya introducido una oopcion correcta
                            if (opcion != "1" && opcion != "2" && opcion != "9")
                            {
                                Console.WriteLine("La opcion sleccionada no es correcta");

                            }


                if (opcion == "1")
                {
                    Console.WriteLine("Hola Mundo!");
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("Introduce tu nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Hola " + nombre + "!");
                }

            }

        }
    }
}
