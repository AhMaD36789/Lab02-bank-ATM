namespace Lab02_bank_account
{
    public class Program
    {
        public static decimal balance = 10;
        static void Main(string[] args)
        {
            try
            {
                UserInterface();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("Thank you for using our services"); }
        }
        public static decimal ViewBalance()
        {
            return balance;
        }
        public static decimal Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("\nRequired withdraw amount is greater than current balance \n");
                UserInterface();
            }
            if (amount < 0)
            {
                Console.WriteLine("\nRequired withdraw amount is negative or zero \n");
            }
            balance -= amount;
            return balance;
        }
        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("\nDeposit amount is negative. Would you like to Withdraw instead ?\n");
            }
            balance += amount;
            return balance;
        }
        public static void UserInterface()
        {

            int userSelect = 0;
            while (userSelect != 4)
            {
                Console.WriteLine("\nPlease enter the corresponding number to run any of the following operations \n \n 1.View Balance \t 2. Withdraw \n 3. Deposit \t \t 4. Exit \n");
                userSelect = Convert.ToInt32(Console.ReadLine());
                switch (userSelect)
                {
                    case 1:
                        {
                            Console.WriteLine("\nCurrent balance\n");
                            Console.WriteLine(ViewBalance());
                            Console.WriteLine("");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("\nSelect Withdraw Amount\n");
                            Withdraw(Convert.ToDecimal(Console.ReadLine()));
                            Console.WriteLine("");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nSelect Deposit Amount\n");
                            Deposit(Convert.ToDecimal(Console.ReadLine()));
                            Console.WriteLine("");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nwrong input try again \n");
                            break;
                        }

                }
            }
        }
    }
}