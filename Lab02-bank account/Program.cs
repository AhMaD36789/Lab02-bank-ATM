namespace Lab02_bank_account
{
    public class Program
    {
        public static decimal balance = 0;
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
            finally {Console.WriteLine("program complete");}
        }
        public static decimal ViewBalance()
        {
            return balance;
        }
        public static decimal Withdraw(decimal amount)
        {
            balance -= amount;
            return balance;
        }
        public static decimal Deposit(decimal amount)
        {
            balance += amount;
            return balance;
        }
        public static void UserInterface ()
        {
            
            int userSelect = 0;
            while (userSelect !=4) 
            {
                Console.WriteLine("Hello please enter the corresponding number to run any of the following operations \n 1.View Balance \t 2. Withdraw \n 3. Deposit \t \t 4. Exit");
                userSelect = Convert.ToInt32(Console.ReadLine());
                switch (userSelect)
                {
                    case 1: { 
                            Console.WriteLine("Current balance");
                            Console.WriteLine( ViewBalance());
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Select Withdraw Amount");
                            Console.WriteLine( Withdraw(Convert.ToDecimal(Console.ReadLine())));

                            break;
                        }
                        case 3:
                        {
                            Console.WriteLine("Select Deposit Amount");
                            Console.WriteLine(Withdraw(Convert.ToDecimal(Console.ReadLine())));
                            break;
                        }
                        default: {
                            Console.WriteLine("wrong input try again");
                            break;
                                }

                }
            }
        }
    }
}