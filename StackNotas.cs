using System;
using System.Collections.Generic;

namespace Stack
{
    class StackNotas
    {
        List<string> notas = new List<string>();

        // Push -> Agregar elemento
        // Peek -> Ver elemento de arriba
        // pop -> Ver + Quitar
        // Saber cuantos elementos tiene dentro

        // Imprimir stack

        public void Push(string nota)
        {
            // La parte de arriba del Stack es el final de la list
            this.notas.Add(nota);
        }

        public string Pop() //Pop = quitar el valor que esta arriba y devolverlo
        {

            //1. Devolver valor
            //2. Borrar valor

            if (this.notas.Count == 0)
            {
                return null;
            }

            // 1 respaldar valor
            string value = this.notas[this.notas.Count - 1];

            // 2 Borrar de la lista
            this.notas.RemoveAt(this.notas.Count -1);

            //devolver valor respaldado
            return value; // <----- La funcion lega hasta aqui
        }

        public string Peek()
        {
            return this.notas[this.notas.Count - 1];
        }

        public void PrintStack()
        {
            //TODO Implementar

          // for (int i = 0; i < notas.Count; i++)
          // {
          //     Console.WriteLine(notas[i]);
          // }

           // for (int i = 0; i < this.notas.Count - 1; i >= 0; i--)
           // {
           //     Console.WriteLine(notas[i]);
           // }
        }//
    }
}