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
            while (opcion != "9")
            {   
                opcion = "";
                // pedir opcion al usuario
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
                    else if (opcion == "9")
                    {
                        Console.WriteLine("adios");
                    }
                   //else
                   //{
                   //    
                   //}
                   //
                   // switch (opcion)
                   // {
                   //     
                   //    case "1":
                   //        // hacer algo para la opcion "1"
                   //        Console.WriteLine("1) Decir \"Hola Mundo!\"");
                   //        break;
                   //    case "2":
                   //        // hacer algo para la opcion "2"
                   //        Console.WriteLine("2) Decir \"Hola [nombre]!\"");
                   //        break;
                   //    case "9":
                   //        // hacer algo para la opcion "9"
                   //        Console.WriteLine("9) Salir ");
                   //        break;
                   //     
                   //    default:
                   //        // hacer algo en caso contrario
                   //        Console.WriteLine("La opcion sleccionada no es correcta");
                   //        break;
                   // }   
                   //

                }
                
            }
            

        }
    }
}
