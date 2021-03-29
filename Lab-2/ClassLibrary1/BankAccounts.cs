using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
   public  class BankAccounts
    {
        private static int initialaccountnumber=121;
        List<Transaction> allTransactions = new List<Transaction>();

        public string Number { get; set; }

        public string Owner { get; set; }

        public decimal Balance {
            get {

                decimal balance = 0;
                foreach (var item in  allTransactions) {

                    balance += item.Amount;
                }
                return balance;
            
            } 
        }

        public BankAccounts(string name,decimal initialBalance) {

            this.Number = initialaccountnumber.ToString();
            initialaccountnumber++;
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
              
        }

        public BankAccounts() { }

        public void MakeDeposit(decimal amount,DateTime date,string notes) {

            if (amount <=0) {

                throw new ArgumentOutOfRangeException("Amount should be enter greater than 0");
            }
            var deposit = new Transaction(amount,date,notes);

            allTransactions.Add(deposit);

            
            

        }

        public void MakeWithdrawl(decimal amount , DateTime date, string notes) {

            if (amount <= 0) {

                throw new ArgumentOutOfRangeException(nameof(amount),"Amount is Zero");
            }
            if (Balance - amount < 0) {

                throw new InvalidOperationException("Not Sufficient Fund");
            }
            var withdrawal = new Transaction(-amount,date,notes);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory() {

            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\t\t" +
                "Amount\tBalance\t\tNote");
            foreach (var item in allTransactions) {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            
            }

            return report.ToString();
        
        }

    }
}
