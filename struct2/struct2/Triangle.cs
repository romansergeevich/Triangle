using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct2
{
    public class Triangle
    {
      //  private TriangleData triang=Meth(a,b,c);
        
        public TriangleData Triang
        {
            get {

                return triang;
            }
        
        }
        double a;
        double b;
        double c;
        double radius;
        public Triangle()
        {
          
        }
       // TriangleData r = new TriangleData();
        
        
        public Triangle(double a, double b, double c, double radius)
            
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.radius = radius;

          // Meth(a, b, c,triang);
        
        }
        private TriangleData triang; 
        public void K()
        {
           triang= Meth(a, b, c,radius);

        }
        
       
        public static TriangleData Meth(double a, double b, double c,double radius)
            {
            double ploshakr = 3.14 * radius * radius;
            double perimetr = a + b + c;
            double p = (a + b + c) / 2;
            double ploshad = Math.Sqrt(p *(p - a)*(p-b)*(p-c));
            string triangleType=null ;
            if (a == b && b == c && c == a)
            {
                triangleType = "ravnostoronii";
            }
            else if (a == b && b != c || b == c && c != a && c == a && a != b)
            {
                triangleType = "ravnobedrenniy";
            }
            else if (a != b && b != c && c != a)
            {
                double[] arr = { a, b, c };
                Array.Sort(arr);
                double qwer = Math.Sqrt(Math.Pow(arr[0], 2)+ Math.Pow(arr[1], 2));

                if (arr[2] == qwer)

                {
                    triangleType = "pryamoygolniy";
                }
                else
                { triangleType = "raznostoronnii"; }
               
            }

              return new TriangleData(a,b,c,perimetr,ploshad,triangleType,radius,ploshakr);
            // triang = new Triangle.TriangleData(a, b, c, perimetr, ploshad, triangleType);
            //return triang;
        }
        public struct TriangleData
        {
            public double aa;
            private double bb;
            private double cc;
            private double pperimetr;
            private double pploshad;
          
            private string ttriangleType;
            private double pploshadkr;
            private double rradius;
            public double A
            {
                get {
                    return aa;
                    }
            
            }
            public double B
            {
                get { return bb; }

            }
            public double C
            {
                get { return cc; }

            }
            public double Perimetr
            {
                get { return pperimetr; }

            }
            public double Ploshad
            {
                get { return pploshad; }

            }
            public double PloshadKruga
            {
                get { return pploshadkr; }

            }
            public double Radius
            {
                get { return rradius; }

            }
            public string TriangleType
            {
                get { return ttriangleType; }

            }

           
            public TriangleData(double a,double b,double c,double perimetr,double ploshad,string triangleType,double radius, double ploshadkr)
            {
                this.aa = a;
                this.bb = b;
                this.cc = c;
                this.pperimetr = perimetr;
                this.pploshad = ploshad;
                this.ttriangleType = triangleType;
                this.pploshadkr = ploshadkr;
                this.rradius = radius;
            
            
            
            }
        }


    }
}
