using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        private static int accountNumberSeed = 1234567890;

        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }
    }
}
