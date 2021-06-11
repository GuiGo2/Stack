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

            StackNotas stackNotas = new StackNotas();
            stackNotas.Push("Primer nota");
            stackNotas.Push("Segunda nota");
            stackNotas.Push("Tercer nota");
            

            string opcion = "";
            while (opcion != "9")
            {   
                opcion = "";
                // pedir opcion al usuario
                while(opcion != "1" && opcion != "2" && opcion != "3" && opcion != "9")
                {
                    
                    // Mostrar menu de opciones
                    // Solicitar la opcion al usuario
                    Console.WriteLine("1) Imprimir notas(PrintStack)");
                    Console.WriteLine("2) Agregar nota(Push)");
                    Console.WriteLine("3) Quitar nota(Pop)");
                    Console.WriteLine("9) Salir ");



                    Console.WriteLine("Por favor selecciona una opciòn:");
                    opcion = Console.ReadLine();

                    // Porfavor seleccione una opcion valida hasta que seinstruzca una opcion correcta
                    //mientras no se haya introducido una oopcion correcta
                    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "9")
                    {
                        Console.WriteLine("La opcion sleccionada no es correcta");

                    }

                }


                if (opcion == "1")
                {
                    stackNotas.PrintStack();
                }
                else if (opcion == "2")
                {
                    //Push
                    Console.WriteLine("Agregar nota:");
                    string nota = Console.ReadLine();
                    stackNotas.Push(nota);
                }
                else if (opcion == "3")
                {
                  //pop  
                  string nota = stackNotas.Pop();
                  Console.WriteLine("Nota removida");
                  Console.WriteLine(nota);
                }
                else if (opcion == "9")
                {
                    Console.WriteLine("adios");
                }
                else
                {
                    
                }
                
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
