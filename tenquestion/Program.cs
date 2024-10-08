using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdır
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }

        // 2. 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }

        // 3. 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // 4. 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
        int sum = 0;
        for (int i = 50; i <= 150; i++)
        {
            sum += i;
        }
        Console.WriteLine("Toplam: " + sum);

        // 5. 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 1; i <= 120; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += i;
            }
            else
            {
                oddSum += i;
            }
        }

        Console.WriteLine("Tek sayıların toplamı: " + oddSum);
        Console.WriteLine("Çift sayıların toplamı: " + evenSum);
    }
}
