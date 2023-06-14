using Lab02_bank_account;

namespace ATM_test
{

    public class UnitTest1
    {

        [Fact]
        // Test a normal withdraw function execution
        public void WithdrawTrue()
        {
            //ar
            Program.balance = 100;
            //ac
            decimal result = Program.Withdraw(50);
            //as
            Assert.Equal(50M, result);
        }

        [Fact]
        //Test if withdraw amount is greater than the balance in the account
        public void WithdrawFalse1()
        {

            //ar
            Program.balance = 100;
            //ac
            decimal result = Program.Withdraw(150);
            //as
            Assert.Equal(-1M, result);
        }

        [Fact]
        //Test if the withdraw amount is less than or equal zero
        public void WithdrawFalse2()
        {
            //ar
            Program.balance = 100;
            //ac
            decimal result = Program.Withdraw(-5);
            //as
            Assert.Equal(-1M, result);
        }

        [Fact]
        //Test correct Deposit attempt
        public void DepositTrue()
        {
            //ar
            Program.balance = 100;
            //ac
            decimal result = Program.Deposit(50);
            //as
            Assert.Equal(150M, result);
        }

        [Fact]
        //Test if Deposit is less than or equal zero
        public void DepositFalse()
        {
            //ar
            Program.balance = 100;
            //ac
            decimal result = Program.Deposit(-5);
            //as
            Assert.Equal(-1M, result);
        }
    }
}