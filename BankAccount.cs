public class BankAccount
{
    private const int MaxBalance = 1000000;
    private string _owner = "Неизвестный клиент";

    public string Owner
    {
        get { return _owner; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _owner = "Неизвестный клиент";
                return;
            }

            _owner = value.Trim();
        }
    }

    public int Balance { get; private set; }
    public string Currency { get; private set; }

    public BankAccount(string owner, int initialBalance, string currency = "RUB")
    {
        Owner = owner;
        Currency = string.IsNullOrWhiteSpace(currency) ? "RUB" : currency.Trim().ToUpper();

        if (initialBalance < 0)
        {
            Balance = 0;
        }
        else if (initialBalance > MaxBalance)
        {
            Balance = MaxBalance;
        }
        else
        {
            Balance = initialBalance;
        }
    }

    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        if (Balance + amount > MaxBalance)
        {
            Balance = MaxBalance;
            return;
        }

        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            return;
        }

        Balance -= amount;
    }

    public bool HasFunds()
    {
        return Balance > 0;
    }

    public string GetInfo()
    {
        return $">>> Счёт: {Owner} <<<\n" +
               $"Баланс: {Balance} {Currency}\n" +
               $"Средства доступны: {HasFunds()}";
    }
}