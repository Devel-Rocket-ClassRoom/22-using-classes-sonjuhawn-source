using System;
using System.Collections.Generic;
using System.Text;

class BankAccount
{
    public string AccountNumber { get; }
    public string OwnerName { get; }
    public int Balance => balance;

    public int balance;

    public BankAccount(string accountnum, string ownnum)
    {
        AccountNumber = accountnum;
        OwnerName = ownnum;
        balance = 0;
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount}원 입금 완료. 잔액: {Balance}");
        }
        else
        {
            Console.WriteLine($"입금 금액은 0보다 커야합니다");
        }
    }
    public void Withdraw(int amount)
    {
        if (balance - amount > 0)
        {
            balance -= amount;
            Console.WriteLine($"{amount}원 출금 완료. 잔액: {Balance}");
        }
        else
        {
            Console.WriteLine($"잔액이 부족합니다");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"[계좌 정보] {AccountNumber} ({OwnerName}) - 잔액: {Balance}원");
    }
}