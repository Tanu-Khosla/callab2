using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace AwesomeCalculatorTest
{
    public class CalcTests
    {
        [Test]
        public void GetAddition_Input3point4and5point6_Return9point0()
        {
            double number1 = 3.4;
            double number2 = 5.6;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetAddition();
            Assert.AreEqual(expectedResult,actualResult);
        }


        [Test]
        public void GetAddition_Input5and10_Return15()
        {
            double number1 = 5;
            double number2 = 10;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetAddition();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input2and2_Return4point0()
        {
            double number1 = 2;
            double number2 = 2;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetAddition();
            Assert.AreEqual(expectedResult, actualResult);
        }


        public void GetMultiplication_Input2and2_Return4point0()
        {
            double number1 = 2;
            double number2 = 2;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetMultiplication();
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void GetMultiplication_Input3and2_Return6point0()
        {
            double number1 = 3;
            double number2 = 2;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetMultiplication();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input4and2_Return8point0()
        {
            double number1 = 4;
            double number2 = 2;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetMultiplication();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input4and2_Return2point0()
        {
            double number1 = 4;
            double number2 = 2;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetDivision();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input8and2_Return4point0()
        {
            double number1 = 8;
            double number2 = 2;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetDivision();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input9and3_Return3point0()
        {
            double number1 = 9;
            double number2 = 2;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetDivision();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input2and2_Return0point0()
        {
            double number1 = 2;
            double number2 = 2;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetSubtraction();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input3and2_Return1point0()
        {
            double number1 = 3;
            double number2 = 2;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetSubtraction();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input4and2_Return2point0()
        {
            double number1 = 4;
            double number2 = 2;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            double actualResult = testCalc.GetSubtraction();
            Assert.AreEqual(expectedResult, actualResult);
        }




    }
    
    
}
