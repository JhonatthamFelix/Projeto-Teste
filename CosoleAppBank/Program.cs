class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("Carlos" , 200);

        BankAccount account2 = new BankAccount("Olivia", 300);

    }

    class BankAccount
    {
       private string name;

        private decimal balance;

        public BankAccount(string name, decimal balance)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Nome inválido.");
            }
            if (balance < 0)
            {
                throw new Exception("Saldo negativo.");
            }
            this.name = name;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {   
            if(amount <= 0)
            {
                return;
            }
            balance += amount;
        }

    }
}