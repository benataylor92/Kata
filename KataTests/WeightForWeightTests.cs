﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests
{
    [TestFixture]
    public class WeightForWeightTests
    {
        [Test]
        public void Test1()
        {
            //Console.WriteLine("****** Basic Tests");
            Assert.AreEqual("2000 103 123 4444 99", Kata.kata__5_.WeightForWeight.orderWeight("103 123 4444 99 2000"));
            Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", Kata.kata__5_.WeightForWeight.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }
    }
}
