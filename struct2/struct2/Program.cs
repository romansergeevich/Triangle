using System;

namespace struct2
{/*
  * Нахождение площади, периметра и типа треугольника по трем сторонам
  * Нахождение площади окпужности по радиусу
  * 
  */
    class Program
    {
        static void Main(string[] args)
         {
            Triangle tr;
           tr= new Triangle(3, 4, 5,2);
            Triangle.TriangleData e = new Triangle.TriangleData();
            
            tr.K();


            Console.WriteLine("Storoni treugolnika");
            Console.WriteLine(tr.Triang.A);
            Console.WriteLine(tr.Triang.B);
            Console.WriteLine(tr.Triang.C);
            Console.WriteLine("Radius");
            Console.WriteLine(tr.Triang.Radius);
            Console.WriteLine("Ploshad treugolnika");
            Console.WriteLine(tr.Triang.Ploshad);
            Console.WriteLine("Perimetr treugolnika");
            Console.WriteLine(tr.Triang.Perimetr);
            Console.WriteLine("Tip treugolnika");
            Console.WriteLine(tr.Triang.TriangleType);
            Console.WriteLine("PLoshad Kruga");
            Console.WriteLine(tr.Triang.PloshadKruga);
            Console.ReadKey();
        }
    }
}
