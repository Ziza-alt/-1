using System;

class Program
{
    static void Main()
    {
        string[] books = { "Метро 2033", "Відьмак", "100 градусів по Фаренгейту", "Війна і мир" };
        int[] prices = { 350, 420, 280, 500 };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("📚 ВІТАЄМО У КНИЖКОВОМУ МАГАЗИНІ!");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nСписок книг:");
        Console.ResetColor();

        Console.WriteLine("1. " + books[0] + " - " + prices[0] + " грн");
        Console.WriteLine("2. " + books[1] + " - " + prices[1] + " грн");
        Console.WriteLine("3. " + books[2] + " - " + prices[2] + " грн");
        Console.WriteLine("4. " + books[3] + " - " + prices[3] + " грн");

        Console.Write("\nВведіть номери книг (через кому): ");
        string input = Console.ReadLine();

        string[] s = input.Split(',');
        int total = Convert.ToInt32(s.Length > 0 ? prices[Convert.ToInt32(s[0].Trim()) - 1] : 0);
        int i = 1;
        try { again: total += prices[Convert.ToInt32(s[i].Trim()) - 1]; i++; goto again; } catch { }

        Random rnd = new Random();
        int discount = (int)Math.Floor(rnd.NextDouble() * 10);
        double finalPrice = Math.Round(total - total * discount / 100.0, 2);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nЗагальна сума: " + total + " грн");
        Console.WriteLine("Знижка: " + discount + "%");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Разом до оплати зі знижкою: " + finalPrice + " грн");
        Console.ResetColor();
    }
}