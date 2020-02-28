using System;
using Xunit;

namespace gradebook.Tests
{
    public class GradesTest
    {
        [Fact]
        public void ComputeAverage()
        {
            Assert.Equal(2, grades.ComputeAvg(), 2);
        }

        [Fact]
        public void ComputeTotal()
        {
            Assert.Equal(6, grades.ComputeTotal(), 2);
        }

        [Fact]
        public void ComputeMin()
        {
            Assert.Equal(1, grades.ComputeMin(), 2);
        }

        [Fact]
        public void ComputeMax()
        {
            Assert.Equal(3, grades.ComputeMax(), 2);
        }

        private Grades grades = new Grades("Grades of Patje", new double[] { 1, 2, 3 }, null);
    }
}
