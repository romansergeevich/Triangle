using Microsoft.VisualStudio.TestTools.UnitTesting;
using struct2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct2.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void MethTest()
        {
           
            Triangle st = new Triangle(3,3,5,2);
            st.K();
            Triangle.TriangleData actual = new Triangle.TriangleData(st.Triang.A,st.Triang.B,st.Triang.C,st.Triang.Perimetr,st.Triang.Ploshad,st.Triang.TriangleType,st.Triang.Radius,st.Triang.PloshadKruga);

             Triangle.TriangleData exp = new Triangle.TriangleData(3,3,5,11,4.14578098794425, "ravnobedrenniy",2,12.56);

            Assert.AreEqual(exp,actual);
        }

        [TestMethod()]
        public void MethTest1_Ravnostoronni()
        {
            
            Triangle st = new Triangle(5, 5, 5,5);
            st.K();
            Triangle.TriangleData actual = new Triangle.TriangleData(st.Triang.A, st.Triang.B, st.Triang.C, st.Triang.Perimetr, st.Triang.Ploshad, st.Triang.TriangleType, st.Triang.Radius, st.Triang.PloshadKruga);

            Triangle.TriangleData exp = new Triangle.TriangleData(5, 5, 5, 15, 10.825317547305483, "ravnostoronii",5,78.5);

            Assert.AreEqual(exp, actual);
        }
        [TestMethod()]
        public void MethTest_Pryamoygolniy()
        {
            
            Triangle st = new Triangle(6, 8, 10,10);
            st.K();
            Triangle.TriangleData actual = new Triangle.TriangleData(st.Triang.A, st.Triang.B, st.Triang.C, st.Triang.Perimetr, st.Triang.Ploshad, st.Triang.TriangleType, st.Triang.Radius, st.Triang.PloshadKruga);

            Triangle.TriangleData exp = new Triangle.TriangleData(6, 8, 10, 24, 24, "pryamoygolniy",10,314);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod()]
        public void MethTest_Raznostoronniy()
        {
           
            Triangle st = new Triangle(4, 5, 6,6);
            st.K();
            Triangle.TriangleData actual = new Triangle.TriangleData(st.Triang.A, st.Triang.B, st.Triang.C, st.Triang.Perimetr, st.Triang.Ploshad, st.Triang.TriangleType, st.Triang.Radius, st.Triang.PloshadKruga);

            Triangle.TriangleData exp = new Triangle.TriangleData(4, 5, 6, 15, 9.921567416492215, "raznostoronnii",6,113.04);

            Assert.AreEqual(exp, actual);
        }


    }
}