BankAccount YuriiAccount = new BankAccount("  Васильев Юрий  ", 5000);
BankAccount AptypAccount = new BankAccount("Куриев Артур", 15000, "USD");

Console.WriteLine(YuriiAccount.GetInfo());
Console.WriteLine();
Console.WriteLine(AptypAccount.GetInfo());
Console.WriteLine();

Console.WriteLine("--- Операции со счётом Юрия ---");
YuriiAccount.Deposit(2500);
Console.WriteLine($"После пополнения (+2500): {YuriiAccount.Balance} {YuriiAccount.Currency}");

YuriiAccount.Withdraw(4000);
Console.WriteLine($"После снятия (-4000): {YuriiAccount.Balance} {YuriiAccount.Currency}");

YuriiAccount.Deposit(-1000);
Console.WriteLine($"После попытки пополнить на -1000: {YuriiAccount.Balance}");

YuriiAccount.Withdraw(-500);
Console.WriteLine($"После попытки снять -500: {YuriiAccount.Balance}");

YuriiAccount.Withdraw(50000);
Console.WriteLine($"После попытки снять больше остатка: {YuriiAccount.Balance}");

YuriiAccount.Deposit(2000000);
Console.WriteLine($"После пополнения выше максимума: {YuriiAccount.Balance}");
Console.WriteLine();

Console.WriteLine("--- Проверка неправильного создания счёта ---");
BankAccount brokeAccount = new BankAccount("   ", -500, "");
Console.WriteLine(brokeAccount.GetInfo());