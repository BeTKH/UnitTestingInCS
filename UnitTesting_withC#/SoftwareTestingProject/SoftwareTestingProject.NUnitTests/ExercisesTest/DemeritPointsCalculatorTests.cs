﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SoftwareTestingProject.Exercises;

namespace TestsNUnit.ExercisesTest
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {

        [Test]
        [TestCase(-1)]
        [TestCase(300)]
        public void CalculateDemeritPoints_SpeedIsNegative_ThrowArgOutOfRangeExeption(int speed) 
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(speed),
                 Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }


        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_RetunDemeriPoints(int speed, int expectedResult) 
        {
            
        }
    }
}
