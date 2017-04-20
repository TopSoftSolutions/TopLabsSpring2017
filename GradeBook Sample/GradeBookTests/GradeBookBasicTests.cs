using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBookProject;

namespace GradeBookTests
{
    [TestClass]
    public class GradeBookBasicTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook gb1 = new GradeBook(5);
            gb1.AddGrade(0);
            gb1.AddGrade(90);
            gb1.AddGrade(100);
            GradeStatistics stats = gb1.CalcualteStatistics();
            Assert.AreEqual(100, stats.MaxGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook gb1 = new GradeBook(5);
            gb1.AddGrade(58);
            gb1.AddGrade(55);
            GradeStatistics stats = gb1.CalcualteStatistics();
            Assert.AreEqual(55, stats.MinGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook gb1 = new GradeBook(5);
            gb1.Type = GradeBookType.PhD;
            gb1.AddGrade(91);
            gb1.AddGrade(89.5f);
            gb1.AddGrade(75);

            GradeStatistics stats = gb1.CalcualteStatistics();
            Assert.AreEqual(85.16666666666667, stats.AverageGrade, 0.01);
        }
    }
}
