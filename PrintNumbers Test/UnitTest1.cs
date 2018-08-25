using System;
using Xunit;
using AXAAssessment;

namespace PrintNumbers_Test
{
    public class AXAAssesmentUnitTest
    {
        [Fact]
        public void Test1()
        {
            AXAAssesment objTest = new AXAAssesment();
            Assert.True(objTest.printDigits(100));            
        }
    }
}
