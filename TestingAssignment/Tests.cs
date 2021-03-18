using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static System.Console;
using TestingAssignment; // note we must reference the project we are testing
namespace TestingAssignment.tests
{
    [TestFixture]
    public class Program
    {
        [Test]
        public static void Test1()
        {
            // arrange
            InsuranceService i = new InsuranceService();
            // act
            int age = 20;
            // assert
            Assert.That(age, Is.InRange(18, 30));


        }

        [Test]
        public static void Test2()
        {
            // arrange
            InsuranceService i = new InsuranceService();
            // act
            int age = 32;
            // assert
            Assert.That(age, Is.GreaterThanOrEqualTo(31));


        }

      
        public static void Test3()
        {
            // arrange
            InsuranceService i = new InsuranceService();
            // act
            int age = 60;
            // assert
            Assert.That(age, Is.GreaterThanOrEqualTo(50));


        }
        public static void Test4()
        {

            // arrange
            InsuranceService i = new InsuranceService();
            // act
            int age = 15;
            // assert
            Assert.That(age, Is.LessThan(18));

        }
        public static void Test5()
        {
            // arrange
            InsuranceService i = new InsuranceService();
            // act
            int age = 22;
            // assert
            Assert.That(age, Is.InRange(18, 35));



        }
        public static void Test6()
        {
            // arrange
            InsuranceService i = new InsuranceService();
            // act
            int age = 38;
            // assert
            Assert.That(age, Is.GreaterThanOrEqualTo(36));



        }
        public static void Test7()
        {
            // arrange
            InsuranceService i = new InsuranceService();
            // act
            int age = 61;
            // assert
            Assert.That(age, Is.GreaterThanOrEqualTo(50));


        }
        public static void Test8()
        {
            // arrange
            InsuranceService i = new InsuranceService();
            // act
            int age = 10;
            // assert
            Assert.That(age, Is.LessThan(18));



        }
    }
}

