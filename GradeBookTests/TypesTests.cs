using GradeBookProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookTests
{
    [TestClass]
    public class TypesTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[5];
            AddGrades(ref grades);
            Assert.AreEqual(89.89f, grades[1]);
        }

        private void AddGrades(ref float[] array)
        {
            array = new float[100];
            array[1] = 89.89f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "Mukuch" + "j";

            name = name.ToUpper();

            Assert.AreEqual("MUKUCHJ", name);
        }

        [TestMethod]
        public void AddDaystoDateTime()
        {
            DateTime date = new DateTime(2017, 3, 31);
            date = date.AddDays(1);

            Assert.AreEqual(date.Day, 1);
        }

        [TestMethod]
        public void ReferenceTypeTest()
        {
            GradeBook gb1 = new GradeBook();
            GradeBook gb2 = gb1;
            ChangeName(ref gb2);
            if (gb2.Name != "Ankap anun")
            {
                Assert.Fail();
            }
        }

        private void ChangeName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "Ankap anun";
        }


        [TestMethod]
        public void ValueTypeTest()
        {
            int x = 100;
            IncremntValue(ref x);
    
            Assert.AreEqual(x, 101);
            
        }

        private void IncremntValue(ref int value)
        {
            value++;
        }

        [TestMethod]
        public void StringTest()
        {
            string name = "MUKUCH";

            if (string.Compare(name, "mukuch", StringComparison.InvariantCultureIgnoreCase) != 0)
            {
                Assert.Fail();
            }
        }
    }
}
