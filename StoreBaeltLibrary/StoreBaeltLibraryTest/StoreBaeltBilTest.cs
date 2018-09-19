using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltLibrary;


namespace StoreBaeltLibraryTest
{
    [TestClass]
    public class StoreBaeltBilTest
    {
        [TestMethod]
        public void TestWeekendPris()
        {
            //ARRANGE
            WeekendRabat weekendRabat = new WeekendRabat();
            Bil bil = new Bil();
            
            //ACT
            bil.AnvendtBrobizz = false;
            weekendRabat.dag = DayOfWeek.Saturday;
            decimal BrobizzWeekendPris = weekendRabat.WeekendPris();

            //ASSERT
            Assert.AreEqual(182.4, BrobizzWeekendPris);
            
        }
    }
}
