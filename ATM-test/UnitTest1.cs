using Lab02_bank_account;

namespace ATM_test
{

    public class UnitTest1
    {


        [Fact]
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
        public void WithdrawFalse()
        {
            //ar
            Program.balance = 100;
            //ac
            decimal result = Program.Withdraw(150);
            //as
            Assert.Equal(-1M, result);
        }

        [Fact]
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