using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment3.Controllers;
using Moq;
using Assignment3.Models;
using System.Linq;

namespace Assignment3.Tests.Controllers
{
    /// <summary>
    /// Summary description for phones1ControllerTest
    /// </summary>
    [TestClass]
    public class phones1ControllerTest
    {

        phones1Controller controller;
        Mock<IMockphones1Repository> mock;
        List<phones1> phones;

        [TestInitialize]

        public void TestInitialize()
        {

            // runs automatically before each unit test
            // instantiate the mock object
            mock = new Mock<IMockphones1Repository>();

            // instantiate the mock phones data
            phones = new List<phones1>
            {

                new phones1 { phoneID = 1, phones = "phones 1" },
                new phones1 { phoneID = 2, phones = "phones 2" },
                new phones1 { phoneID = 3, phones = "phones 2" },

            };
            //bind the data to the mock
            mock.Setup(m => m.Phones1).Returns(phones.AsQueryable());

            // initialize the controller and inject the dependency
            controller = new phones1Controller(mock.Object);


        }
        
        [TestMethod]

        public void IndexViewLoads()
        {


            //act
            var actual = controller.Index();

            // assert
            Assert.IsNotNull(actual);


        }


    }
}
