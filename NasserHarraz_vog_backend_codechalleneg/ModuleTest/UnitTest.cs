using System;
using Xunit;
using VogCodeChallenge.API.Classes;

namespace ModuleTest
{
    public class UnitTest
    {
        [Fact]
        public void ModuleInt1ReturnDoubler()
        {
            int expected = 2;
            object actual = TestModule.Module(1);
            Assert.Equal(expected, actual);
       
        }

        [Fact]
        public void ModuleInt2ReturnDoubler()
        {
            int expected = 4;
            object actual = TestModule.Module(2);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ModuleInt3ReturnTrippler()
        {
            int expected = 9;
            object actual = TestModule.Module(3);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ModuleIntGreaterThan3ReturnTrippler()
        {
            int expected = 15;
            object actual = TestModule.Module(5);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ModuleFloatValueReturnLeveler()
        {
            double expected = (0.0);
            object actual = TestModule.Module(1.0f);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ModuleAnyOtherValueReturnTheSameValue()
        {
            double expected = (0.5);
            object actual = TestModule.Module(0.5);
            Assert.Equal(expected, actual);

        }
    }
}
