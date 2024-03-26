int balance = 10000;
Random random = new Random();
while (balance > 0)
{
    Console.Write("Введите ставку: ");
    var BetStr = Console.ReadLine();
    int bet = int.Parse(BetStr);

    if (bet <= balance)
    {
        Console.WriteLine("Баланс: " + balance);
        int randomNum = random.Next(1, 20);
        if (randomNum == 18 || randomNum == 19 || randomNum == 20)
        {
            balance += bet * (1 + (1 * randomNum % 17));
        }
        else
        {
            balance -= bet;
        }
    }
    else
    {
        Console.WriteLine("Недостаточно денег для ставки");
    }
}
Console.WriteLine("Вы проиграли");