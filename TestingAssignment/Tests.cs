using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using static System.Console;
using TestingAssignment; // note we must reference the project we are testing
//using Microsoft.Net.Test.SDK;
//using Program;

namespace TestingAssignment.tests

{
    [TestFixture]
    public class Tests
    {
        [Test]
        public static void Test1()
        {
            // arrange
            Program i = new Program();
            double expected = 0;
            // act
            int actual = i.CalcPremium(20, "Female");
            // assert
            Assert.That(expected, actual, Is.InRange(18, 30));
        }

        [Test]
        public static void TestDemo()
        {
            // arrange
            Program i = new Program();
             double expected = 0;
            // act
            double actual = i.CalcPremium(12,"female");
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Test2()
        {
            // arrange
            Program i = new Program();
            double expected = 0;
            // act
            double actual = i.CalcPremium(32, "female");
            // assert
            Assert.Is.GreaterThanOrEqualTo(31)(expected, actual );


        }

      
        public static void Test3()
        {
            // arrange
            Program i = new Program();
            double expected = 0;
            // act
            double actual = i.CalcPremium(60, "female");
            // assert
            Assert.That(expected, actual, Is.GreaterThanOrEqualTo(50));


        }
        public static void Test4()
        {

            // arrange
            Program i = new Program();
            double expected = 0;
            // act
            double actual = i.CalcPremium(15, "female");
            // assert
            Assert.That(expected, actual, Is.LessThan(18));

        }
        public static void Test5()
        {
            // arrange
            Program i = new Program();
            double expected = 0;
            // act
            double actual = i.CalcPremium(22, "male");
            // assert
            Assert.That(expected, actual, Is.InRange(18, 35));



        }
        public static void Test6()
        {
            // arrange
            Program i = new Program();
            double expected = 0;
            // act
            double actual = i.CalcPremium(38, "male");
            // assert
            Assert.That(expected, actual, Is.GreaterThanOrEqualTo(36));



        }
        public static void Test7()
        {
            // arrange
            Program i = new Program();
            double expected = 0;
            // act
            double actual = i.CalcPremium(61, "male");
            // assert
            Assert.That(expected, actual, Is.GreaterThanOrEqualTo(50));


        }
        public static void Test8()
        {
            // arrange
            Program i = new Program();
            double expected = 0;
            // act
            double actual = i.CalcPremium(10, "other");
            // assert
            Assert.That(expected, actual, Is.LessThan(18));



        }
    }
}

