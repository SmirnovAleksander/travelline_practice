
internal static class Program
{
    private static int balance = 10000;
    private static Random random = new Random();

    public static void Main()
    {
        while (balance > 0)
        {
            int bet = GetValueFromUser();
            if (bet <= balance)
            {
                int randomNum = random.Next(1, 20);
                UpdateBalance(bet, randomNum);
            }
            else
            {
                Console.WriteLine("Недостаточно денег для ставки");
            }
        }
        Console.WriteLine("Вы проиграли");
    }

    private static int GetValueFromUser()
    {
        int bet;
        while (true)
        {
            Console.Write("Введите ставку: ");
            string betStr = Console.ReadLine();
            if(int.TryParse(betStr, out bet))
            {
                break;
            }
            else
            {
                Console.WriteLine("Вы не ввели число. Введите число");
            }
        }
        return bet;
    }

    private static void UpdateBalance(int bet, int randomNum)
    {
        Console.WriteLine("Баланс: " + balance);
        if (randomNum == 18 || randomNum == 19 || randomNum == 20)
        {
            balance += bet * (1 + (1 * randomNum % 17));
        }
        else
        {
            balance -= bet;
        }
    }
}
