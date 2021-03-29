using ClassLibrary1;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new BankAccounts("Amit",10000);

            acc1.MakeWithdrawl(2000,DateTime.Now,"First With");
            try { acc1.MakeWithdrawl(20000, DateTime.Now, "Withdraew")};

            try { acc1.MakeDeposit(6000,DateTime.Now,"First Deposit"); }
            catch (Exception e){

                Console.WriteLine(e.Message);
            
            
            }

            Console.WriteLine(acc1.GetAccountHistory());

            var acc2 = new BankAccounts("Ram",12000);

            acc2.MakeDeposit(20000,DateTime.Now,"First Depoait");
            acc2.MakeDeposit(3000,DateTime.Now,"Second Deposit");
            acc2.MakeWithdrawl(6000,DateTime.Now,"First Withdrawal");
            

            Console.WriteLine(acc2.GetAccountHistory());
        }
    }
}
