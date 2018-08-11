using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module;

namespace TestModule.Test
{
    [TestClass]
    public class ArrayManTests
    {
        ArrayMan arrMan = new ArrayMan();

        [TestMethod]
        public void FindMax_PositivElement_Test()
        {
            
            int[] a = { -4, 3, 22, -43, 44, 3 };
            int expected = 44;

            int actual = arrMan.FindMax(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
