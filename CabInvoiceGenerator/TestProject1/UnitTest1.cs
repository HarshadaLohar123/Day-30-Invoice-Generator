using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace TestProject1
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;

        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RydeType.NORMAL);
            double distance = 2.0;
            int time = 5;

            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }
    }
}
