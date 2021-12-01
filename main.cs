using System;
using ArbolBusquedaBinaria;

class Program {
  public static void Main (string[] args){
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
            abo.Insertar(15);
            abo.Insertar(12);
            abo.Insertar(20);
            abo.Insertar(30);
            abo.Insertar(35);
            abo.Insertar(40);
            abo.Insertar(45);
            abo.Insertar(55);
            abo.Insertar(62);
            abo.Insertar(68);
            abo.Insertar(74);
            abo.Insertar(80);
            abo.Insertar(81);
            abo.Insertar(88);
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);


            Console.WriteLine("Impresion entreorden:");
            abo.ImprimirEntre();
            Console.WriteLine("\n");
            Console.WriteLine("Impresion preorden:");
            abo.ImprimirPre();
            Console.WriteLine("\n");
            Console.WriteLine("Impresion postorden:");
            abo.ImprimirPost();
            Console.WriteLine("\n");
            Console.WriteLine("Cantidad de nodos del árbol:" + abo.Cantidad());
            Console.WriteLine("\n");
            Console.WriteLine("Cantidad de nodos hoja:" + abo.CantidadNodosHoja());
            Console.WriteLine("\n");
            Console.WriteLine("Impresion en entre orden junto al nivel del nodo.");
            abo.ImprimirEntreConNivel();
            Console.WriteLine("\n");

            Console.Write("Altura del arbol:");
            Console.WriteLine(abo.RetornarAltura());
            Console.WriteLine("\n");
            abo.MayorValorl();    
            abo.BorrarMenor();
            Console.WriteLine("\n");
            Console.WriteLine("Luego de borrar el menor:");
            abo.ImprimirEntre();
            Console.ReadKey();

        }
}