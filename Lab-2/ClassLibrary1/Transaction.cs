using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public String Notes { get; set; }
        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;

        }
    }

    
}
