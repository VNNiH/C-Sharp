class Program {
	static void Main() {
		Console.WriteLine("Enter account data");
			
		Console.Write("Number:");
		int number = int.Parse(Console.ReadLine());
			
		Console.Write("Holder:");
		string holder = Console.ReadLine();
			
		Console.Write("Initial balance:");
		double initialBalance = double.Parse(Console.ReadLine());
			
		Console.Write("Withdraw limit:");
		double withdrawLimit = double.Parse(Console.ReadLine());
            
        Account acc = new Account(number,holder,initialBalance,withdrawLimit);
            
		Console.Write("Enter amount for withdraw: ");
		double amount = double.Parse(Console.ReadLine());
			
		try{
		    acc.Withdraw(amount);
		    Console.WriteLine("New balance: " + acc.Balance.ToString);
		}
        catch(AccountException ex)
        {
            Console.WriteLine("Withdraw error: " + ex.Message);
        }
	}
}
