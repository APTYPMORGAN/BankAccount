Console.WriteLine("=== ПРОВЕРКА БАНКОВСКИХ СЧЕТОВ ===\n");

BankAccount ivanAccount = new BankAccount("  Иван Петров  ", 5000);
BankAccount annaAccount = new BankAccount("Анна Смирнова", 15000, "USD");

Console.WriteLine(ivanAccount.GetInfo());
Console.WriteLine();
Console.WriteLine(annaAccount.GetInfo());
Console.WriteLine();

Console.WriteLine("--- Операции со счётом Ивана ---");
ivanAccount.Deposit(2500);
Console.WriteLine($"После пополнения (+2500): {ivanAccount.Balance} {ivanAccount.Currency}");

ivanAccount.Withdraw(4000);
Console.WriteLine($"После снятия (-4000): {ivanAccount.Balance} {ivanAccount.Currency}");

ivanAccount.Deposit(-1000);
Console.WriteLine($"После попытки пополнить на -1000 (не изменился): {ivanAccount.Balance}");

ivanAccount.Withdraw(-500);
Console.WriteLine($"После попытки снять -500 (не изменился): {ivanAccount.Balance}");

ivanAccount.Withdraw(50000);
Console.WriteLine($"После попытки снять больше остатка (не изменился): {ivanAccount.Balance}");

ivanAccount.Deposit(2000000);
Console.WriteLine($"После пополнения выше максимума (ограничен 1000000): {ivanAccount.Balance}");
Console.WriteLine();

Console.WriteLine("--- Проверка некорректного создания счёта ---");
BankAccount brokenAccount = new BankAccount("   ", -500, "");
Console.WriteLine(brokenAccount.GetInfo());