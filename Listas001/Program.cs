using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
namespace Listas001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Lista<int> lis = new Lista<int>();
            lis.Agregar(1);
            lis.InserAt(0,12);
            
            lis.Agregar(2);
            lis.Agregar(3);
            lis.Agregar(4);
            lis.Agregar(5);
            lis.Agregar(6);
            lis.InserAt(1,14);
            lis.InserAt(lis.Count-1,14);

            List<int> datos = new List<int>();
            foreach (int dato in lis)
            {
                Console.WriteLine(dato);
            }
            
            
        }
    }
}