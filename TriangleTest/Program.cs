﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestClass_1;

namespace TriangleTest
{
    public class TriangleTest
    {
        [TestFixture]

        public class TriangleTest1
        {
            [Test]

            public void ValidTriangle_Input60and60and60_OutputVaidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle); 

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        
    }
}
