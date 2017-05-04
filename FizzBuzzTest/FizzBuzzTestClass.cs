/// <summary>
///Namespace
/// </summary>

using MVCFIZZBUZZ.Controllers;
using MVCFIZZBUZZ.Models;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FizzBuzzTest
{
    /// <summary>
    /// Implements  Test Framework
    /// </summary>
    [TestFixture]
    public class FizzBuzzTestClass
    {           
            /// <summary>
            /// Test the Action method returning Specific Index View
            /// </summary>
            [Test]
            public void TestFizzBuzzIndex()
            {
                var obj = new FizzBuzzController();

                var actResult = obj.Index() as ViewResult;

                Assert.That(actResult.ViewName, Is.EqualTo("Index"));
            }

            /// <summary>
            /// Test the Action method returning Specific Detail View
            /// </summary>
            [Test]
            public void TestFizzBuzzDetails()
            {
                var obj = new FizzBuzzController();

                var actResult = obj.Index() as ViewResult;

                Assert.That(actResult.ViewName, Is.EqualTo("Details"));
            }        
    }
}
