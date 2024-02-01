using DateTimeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DateTimeLibraryTest
{
    [TestClass]
    public class DateTimeFunctionsTests
    {
        [TestMethod]
        public void TestCalculateDateDifference()
        {
            DateTime date1 = new DateTime(2024, 1, 1);
            DateTime date2 = new DateTime(2024, 1, 14);

            TimeSpan difference = DateTimeFunctions.CalculateDateDiffrence(date1, date2);

            Assert.AreEqual(13, difference.Days);
        }

        [TestMethod]
        public void TestIsLeapYear()
        {
            Assert.IsTrue(DateTimeFunctions.IsLeapYear(2020));
            Assert.IsFalse(DateTimeFunctions.IsLeapYear(2025));
        }

        [TestMethod]
        public void TestGetTimeOfDay()
        {
            DateTime morningTime = new DateTime(2024, 1, 1, 7, 15, 0);
            DateTime afternoonTime = new DateTime(2024, 1, 1, 12, 1, 0);
            DateTime eveningTime = new DateTime(2024, 1, 1, 21, 0, 0);
            DateTime nightTime = new DateTime(2024, 1, 1, 3, 0, 0);

            Assert.AreEqual("Утро", DateTimeFunctions.GetTimeOfDay(morningTime));
            Assert.AreEqual("День", DateTimeFunctions.GetTimeOfDay(afternoonTime));
            Assert.AreEqual("Вечер", DateTimeFunctions.GetTimeOfDay(eveningTime));
            Assert.AreEqual("Ночь", DateTimeFunctions.GetTimeOfDay(nightTime));
        }

        [TestMethod]
        public void TestFormatDateTime()
        {
            DateTime dateTime = new DateTime(2024, 1, 1, 12, 30, 10);

            Assert.AreEqual("01.01.2024 12:30:10", DateTimeFunctions.FormatDateTime(dateTime, "MM.dd.yyyy hh:mm:ss"));
            Assert.AreEqual("2024-1-1 понедельник", DateTimeFunctions.FormatDateTime(dateTime, "yyyy-M-d dddd"));
        }
    }
}
