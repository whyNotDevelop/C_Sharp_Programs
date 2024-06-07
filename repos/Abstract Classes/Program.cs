namespace Abstract_Classes
{
    internal class Program
    {
       
        internal class innerClass : BankAccount
        {
            public override void deposit(double deposit)
            {
                balance += deposit;
                balance -= 8.00;
                Console.WriteLine("Successfully deposited... R" + deposit);
                Console.WriteLine("Available balance:R" + balance);
            }
            public override void withdraw(double amount)
            {

                balance -= 8.00;
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine("Successfully withdrawnn...R"+amount);
                    Console.WriteLine("Available balance: R"+balance+"\n");
                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                    Console.WriteLine("Available balance...R" + balance+"\n");
                }

            }
        }
        static void Main(string[] args)
        {
            //Program.innerClass anonymousAccount = new Program.innerClass();
            // anonymousAccount.deposit(800);
            // anonymousAccount.withdraw(45);

            SavingsAccount save = new SavingsAccount();
            //save.withdraw(100);
            //save.deposit(1000);

            CheckAccount check = new CheckAccount();
            int count = 0;
            while (count<15) 
            {
                check.deposit(200);
                check.withdraw(100);
                Console.WriteLine();
                count++;
            }
           
           
        }
    }

}