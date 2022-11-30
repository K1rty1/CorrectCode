using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorrectCodeLibrary;

namespace CorrectCodeLibraryTests
{
    [TestClass]
    public class CorrectCodeTests
    {
        /// <summary>
        /// Проверка строки на "пустоту"
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_EmptyString_ExpectedFalse()
        {
            //
            string test = "";
            //
            bool actual = CorrectCodeClass.IsCorrectCode(test);
            //
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка того, что символ строки является числом
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_Chislo_ExpectedFalse()
        {
            //
            string test = "qazwsxedc9";
            //
            bool actual = CorrectCodeClass.IsCorrectCode(test);
            //
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка длины  строки
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_Dlina_ExpectedFalse()
        {
            //
            string test = "3000130009";
            //
            bool actual = CorrectCodeClass.IsCorrectCode(test);
            //
            Assert.IsTrue(actual);
        }

    }
}
