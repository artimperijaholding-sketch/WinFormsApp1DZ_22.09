using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1DZ_22._09;
public delegate void DepositMade(double amount, double balance);
public delegate void WithdrawMade(double amount, double balance);
public class BankAccount
{
    public string AccountNumber { get; set; } = string.Empty;
    public double Balance { get; set; }
    public event DepositMade? DepositEvent;
    public event WithdrawMade? WithdrawEvent;
    public BankAccount(string AccountNumber, double Balance)
    {
        this.AccountNumber = AccountNumber;
        this.Balance = Balance;
    }
    public void Deposit(double amount)
    {
        Balance += amount;
        DepositEvent?.Invoke(amount, Balance);
    }
    public void Withdraw(double amount)
    {
        Balance -= amount;
        WithdrawEvent?.Invoke(amount, Balance);
    }
}
