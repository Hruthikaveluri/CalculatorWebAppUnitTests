using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorWebAPI.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorWebAPI.Models;

namespace CalculatorWebAPI.Controller.Tests
{
    [TestClass()]
    public class CalculatorsControllerTests
    {
        CalculatorsController controller;

        [TestInitialize]
        public void Setup()
        {
            controller=new CalculatorsController(new Models.CalculatorContext());
        }

       
        [TestMethod()]
        public void AdditionTest()
        {
            var cal = controller.Addition(2, 2);
            var result = cal.Result as OkObjectResult;
            var obj = result.Value as Calculator;
            Assert.AreEqual(4, obj.result);
        }

        
        [TestMethod()]
        public void SubstractTest()
        {
            var cal = controller.Subtraction(9, 1);
            var result = cal.Result as OkObjectResult;
            var obj = result.Value as Calculator;
            Assert.AreEqual(8, obj.result);
        }

        
        [TestMethod()]
        public void MulitplyTest()
        {
            var cal = controller.Multiplication(0, 5);
            var result = cal.Result as OkObjectResult;
            var obj = result.Value as Calculator;
            Assert.AreEqual(0, obj.result);
        }


       
        [TestMethod()]
        public void DivisionTest()
        {
            var cal = controller.Division(8, 1);
            var result = cal.Result as OkObjectResult;
            var obj = result.Value as Calculator;
            Assert.AreEqual(8, obj.result);
        }


        
        [TestMethod()]
        public void AdditionFailTest()
        {
            var cal = controller.Addition(8, 3);
            var result = cal.Result as OkObjectResult;
            var obj = result.Value as Calculator;
            Assert.AreEqual(77, obj.result);
        }


        
        [TestMethod()]
        public void SubstractFailTest()
        {
            var cal = controller.Subtraction(9, 5);
            var result = cal.Result as OkObjectResult;
            var obj = result.Value as Calculator;
            Assert.AreEqual(0, obj.result);
        }

        
        [TestMethod()]
        public void MulitplyFailTest()
        {
            var cal = controller.Multiplication(1, 5);
            var result = cal.Result as OkObjectResult;
            var obj = result.Value as Calculator;
            Assert.AreEqual(20, obj.result);
        }

       
        [TestMethod()]
        public void DivisionFailTest()
        {
            var cal = controller.Division(-9, 2);
            var result = cal.Result as OkObjectResult;
            var obj = result.Value as Calculator;
            Assert.AreEqual(0, obj.result);
        }
    }
}