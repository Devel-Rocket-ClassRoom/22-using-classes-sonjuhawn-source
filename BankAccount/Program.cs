using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

BankAccount account = new BankAccount("123-456-789", "홍길동");
account.ShowInfo();

account.Deposit(50000);
account.Deposit(30000);
account.Withdraw(20000);
account.Withdraw(100000);
account.Deposit(-1000);

account.ShowInfo();

