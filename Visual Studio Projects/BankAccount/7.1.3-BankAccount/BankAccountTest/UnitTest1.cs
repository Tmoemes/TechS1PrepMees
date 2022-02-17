using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;

namespace BankAccountTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDepositAmount()
        {
            Account account = new Account(0, -25);
            Assert.IsTrue(account.Deposit(10));
            Assert.AreEqual(10, account.Balance);
        }
        [TestMethod]
        public void TestWithdrawAmount()
        {
            Account account = new Account(10, -25);
            Assert.IsTrue(account.Withdraw(10));
            Assert.AreEqual(0, account.Balance);
        }
        [TestMethod]
        public void TestCreateWithLessThanMinBalance()
        {
            Account account = new Account(-10,5);
            Assert.AreEqual(5,account.Balance);
        }

        [TestMethod]
        public void TestWithdrawLessThanMinBalance()
        {
            Account account = new Account( 5);
            Assert.IsFalse(account.Withdraw(10));
            Assert.AreEqual(5, account.Balance);
        }

        [TestMethod]
        public void TestTransferLessThanMinBalance()
        {
            Account account1 = new Account(25, -10);
            Account account2 = new Account(0,-25);
            Assert.IsFalse(account1.TransferTo(account2, 50));
            Assert.AreEqual(25, account1.Balance);
            Assert.AreEqual(0, account2.Balance);
        }

        [TestMethod]
        public void TestDepositNegativeAmount()
        {
            Account account = new Account(10, -25);
            Assert.IsFalse(account.Deposit(-10));
            Assert.AreEqual(10, account.Balance);
        }

        [TestMethod]
        public void TestWithdrawNegativeAmount()
        {
            Account account = new Account(10, -25);
            Assert.IsFalse(account.Withdraw(-10));
            Assert.AreEqual(10, account.Balance);
        }
    }
}
