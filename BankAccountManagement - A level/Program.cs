using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagement___A_level
{
	class BankAccount
	{
		private string AccountName { get; set; }
		private int balance { get; set; }

		private float feeAmount { get; } = 0.7f;

		/// <summary>
		/// Create account
		/// </summary>
		/// <param name="accountName">- account name </param>
		public BankAccount(string accountName)
		{
			AccountName = accountName;
			balance = 0;
		}

		public int ShowBalance()
		{
			return balance;
		}

		public void WithdrawMoney(int MoneyToTake)
		{
			Console.WriteLine($"Withdrew ${MoneyToTake} with ${MoneyToTake * feeAmount} fee");
			balance -= MoneyToTake - (int)(MoneyToTake * feeAmount);
		}

		public void AddMoney(int MoneyToAdd)
		{
			Console.WriteLine($"Added ${MoneyToAdd} with ${MoneyToAdd * feeAmount} fee");
			balance += MoneyToAdd - (int)(MoneyToAdd*feeAmount);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			BankAccount MyAccount = new BankAccount("Adam Innit");
			MyAccount.AddMoney(10);
			MyAccount.WithdrawMoney(5);
			Console.WriteLine($"Your money is: ${MyAccount.ShowBalance()}");
		}
	}
}
