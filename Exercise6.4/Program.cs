// See https://aka.ms/new-console-template for more information

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine();
    for (int j = 1; j <= 12; j++)
    {
        switch (j)
        {
            case 1: Console.Write("2"); break;
            case 2: Console.Write("3"); break;
            case 3: Console.Write("4"); break;
            case 4: Console.Write("5"); break;
            case 5: Console.Write("6"); break;
            case 6: Console.Write("7"); break;
            case 7: Console.Write("8"); break;
            case 8: Console.Write("9"); break;
            case 9: Console.Write("10"); break;            
            case 10: Console.Write("Q"); break;
            case 11: Console.Write("K"); break;
            case 12: Console.Write("A"); break;
        }
        switch (i)
        {
            case 1: Console.WriteLine(" Clubs"); break;
            case 2: Console.WriteLine(" Diamonds"); break;
            case 3: Console.WriteLine(" Hearts"); break;
            case 4: Console.WriteLine(" Spades"); break;
        }
    }
}
