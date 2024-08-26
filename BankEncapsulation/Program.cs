namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine($"Your current balance is {account.GetBalance()}");
            Console.WriteLine($"How much would you like to deposit?");
            var depositString = Console.ReadLine();
            bool result = double.TryParse(depositString, out double deposit);
            if (result == false)
            {
                Console.WriteLine($"Sorry we couldn't complete your transaction. Please provide a ammount you want to deposit and try again.");
            } else
            {
                account.Deposit(deposit);
            }
            Console.WriteLine($"Your current balance is {account.GetBalance()}");
        }
    }
}
