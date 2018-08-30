// InvoiceTest.cs
// Creates object from class Invoice and demonstrates its capabilities
using System;
using System.Collections.Generic;
using System.Text;

namespace CIS214_Midterm_Odden
{
    class InvoiceTest
    {
        public static void Main(string[] args)
        {
            // create Invoice object
            Invoice myInvoice = new Invoice("23413", "Hammer", 4, 11.99M);
            Console.WriteLine("Part Number: {0}\nPart Description: {1}\nQuantity: {2}\nPrice: {3}",
                myInvoice.PartNumber, myInvoice.PartDescription, myInvoice.Quantity, myInvoice.Price);
            myInvoice.GetInvoiceAmount(); // get invoice amount for this instance
        }
    }
}
