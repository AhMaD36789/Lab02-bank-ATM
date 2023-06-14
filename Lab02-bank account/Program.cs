namespace Lab02_bank_account
{
    public class Program
    {
        public static decimal balance = 0;
        public static string[] actions = new string[100];
        public static int actionCount = 0;
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
            finally
            {
                Console.WriteLine("Thank you for using our services");
                Console.WriteLine("Here is a receipt of your transactions:");
                for (int i = 0; i < actionCount; i++)
                {
                    Console.WriteLine(actions[i]);
                }
            }
        }
        public static decimal ViewBalance()
        {
            if (balance < 1)
            {
                balance = 0;
            }
            return balance;
        }
        public static decimal Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("\nRequired withdraw amount is greater than current balance \n");
                return -1;
            }
            if (amount < 1)
            {
                Console.WriteLine("\nRequired withdraw amount is negative or zero \n");
                return -1;
            }
            balance -= amount;
            actions[actionCount] = $"\tWithdrawal: {amount}";
            actionCount++;
            return balance;
        }
        public static decimal Deposit(decimal amount)
        {
            if (amount < 1)
            {
                Console.WriteLine("\nDeposit amount is negative or zero. Would you like to Withdraw instead ?\n");
                return -1;
            }
            balance += amount;
            actions[actionCount] = $"\tDeposit: {amount}";
            actionCount++;
            return balance;
        }
        public static void UserInterface()
        {

            int userSelect = 0;
            while (userSelect != 4)
            {
                Console.WriteLine("Please enter the corresponding number to run any of the following operations \n \n 1.View Balance \t 2. Withdraw \n 3. Deposit \t \t 4. Exit \n");
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