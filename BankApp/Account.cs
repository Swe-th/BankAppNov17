using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{

    public enum TypeOfAccount
    {
        Checking,
        Savings,
        CD,
        Loan
    }
    public class Account
    {
       /*
        #region statics
        private static int lastAccountNumber = 0;
        #endregion
        */

        #region Properties
        [Key]
        public int AccountNumber { get; private set; }
        [StringLength(100,ErrorMessage ="Email Address should be of 50  characters in length")]
        public string EmailAddress { get; set; }
        public string AccountName { get; set; }
        public TypeOfAccount AccountType { get; set; }
        public decimal Balance { get; private set; }
        #endregion

        #region Constructor
        public Account()
        {
            
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into the account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        /// <summary>
        /// Withdraw money from the account
        /// </summary>
        /// <param name="amount">Amount to be withdrawed</param>
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
