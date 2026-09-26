using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Label = System.Windows.Forms.Label;

namespace WinFormsApp1DZ_22._09;

internal class BankClient
{
    private Label Blabel;
    public string Name { get; set; }=string.Empty;
    public BankClient(string name, Label label)
    {
        this.Name = name;
        this.Blabel = label;
    }
   
    public void OnDeposit(double amount, double balance)
    {
        Blabel.Text = $"Client :{Name}# Deposited :{amount}# Balance :{balance}";
    }
    public void OnWithdraw(double amount, double balance)
    {
        Blabel.Text = $"Client :{Name}# Withdraw :{amount}# Balance :{balance}";
    }

}
