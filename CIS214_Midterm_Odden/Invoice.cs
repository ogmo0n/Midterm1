// CIS214 Midterm: Let's get it!
using System;

namespace CIS214_Midterm_Odden
{
    class Invoice
    {
        // automatic properties for Invoice instance
        public string PartNumber { get; set; } // part number
        public string PartDescription { get; set; } // part description
        public int Quantity { get; set; } // quantity of said part
        public decimal Price { get; set; } // price of said part

        // constructor initializes automatic properties
        public Invoice(string num, string desc, int q, decimal p)
        {
            PartNumber = num; // set PartNumber to num
            PartDescription = desc; // set PartDescription to desc

            // if quantity is negative, set to zero
            if (q < 0)
                Quantity = 0;
            else
                Quantity = q; // set Quantity to q

            // if price is negative, set to zero
            if (p < 0)
                Price = 0;
            else
                Price = p; // set Price to p
        }

        // calculates the invoice amount
        public void GetInvoiceAmount()
        {
            decimal amount; // total price for quantity of part

            // total amount equals quantity times price
            amount = Quantity * Price;

            // display total amount
            Console.WriteLine("Total amount for this invoice is: {0:C}", amount);
        }
    }
}