using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSE
{
    //clase que define el nodo de la lista
    public class Nodo
    {
        public Object dato; // dato contenido en el nodo
        public Nodo siguiente; // puntero al siguiente nodo
        public Nodo comienzo; //Cabecera de la lista

        public void InsertarComienzo(Object dato)
        {
            Nodo Añadir = new Nodo();

            Añadir.dato = dato;
            Añadir.siguiente = comienzo;
            comienzo = Añadir;
        }

        public void InsertarFinal(Object dato)
        {
            if (comienzo == null)
            {
                comienzo = new Nodo();

                comienzo.dato = dato;
                comienzo.siguiente = null;
            }
            else
            {
                Nodo añadir = new Nodo();
                añadir.dato = dato;

                Nodo actual = comienzo;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }

                actual.siguiente = añadir;
            }
        }
        public void print(){
            Nodo? actual = comienzo;
            while(actual != null){
                Console.WriteLine($"{actual.dato}");
                actual = actual.siguiente;
            }
        }

    }
    // Clase que imprime todos los nodos de la lista


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Añade al inicio:");
            Nodo miNodo1 = new Nodo();


            miNodo1.InsertarComienzo("Hola");
            miNodo1.InsertarComienzo("Mundo");
            miNodo1.InsertarComienzo("Dato3");
            miNodo1.print();

            Console.WriteLine();

            Console.WriteLine("Añade al final:");
            Nodo miNodo2 = new Nodo();

            miNodo2.InsertarFinal("Hola");
            miNodo2.InsertarFinal("Mundo");
            miNodo2.InsertarFinal("Dato3");
            miNodo1.print();

            Console.ReadLine();

        }
    }
}
