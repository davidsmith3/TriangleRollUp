using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleRollUp.Domain;
using System.Collections.Generic;

namespace TriangleRollUp.Test {
    [TestClass]
    public class TestGenerator {
        
        [TestMethod]
        public void Test_Empty() {
            Generator g = new Generator();
            List<int> nums = new List<int>();

            string result = g.BuildTriangle(nums);
            Assert.IsTrue(String.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void Test_One() {
            Generator g = new Generator();
            List<int> nums = new List<int>() { 1 };

            string result = g.BuildTriangle(nums);
            Assert.AreEqual("1\n", result);
        }

        [TestMethod]
        public void Test_Two() {
            Generator g = new Generator();
            List<int> nums = new List<int>() { 1, 1 };

            string result = g.BuildTriangle(nums);
            Assert.AreEqual("\t2\t\t\n1\t\t1\t\t\n", result);
        }

        [TestMethod]
        public void Test_Three() {
            Generator g = new Generator();
            List<int> nums = new List<int>() { 1, 1, 1 };

            string result = g.BuildTriangle(nums);
            Assert.AreEqual("\t\t4\t\t\n\t2\t\t2\t\t\n1\t\t1\t\t1\t\t\n", result);
        }
    }
}
