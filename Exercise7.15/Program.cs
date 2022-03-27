// See https://aka.ms/new-console-template for more information

char[] letter = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n',
                 'o','p','q','r','s','t','u','v','w','x','y','z',
                 'A','B','C','D','E','F','G','H','I','J','K','L','M','N',
                 'O','P','Q','R','S','T','U','V','W','X','Y','Z'
                };

Console.Write("Enter a word: ");
char[] word = Console.ReadLine().ToCharArray();

//In case user enters a non latin letter
if (word != letter)
{
    Console.WriteLine("Not among the latin letters!!!");
}
else
{
    for (int i = 0; i < word.Length; i++)
    {
        for (int j = 0; j < letter.Length; j++)
        {
            if (word[i] == letter[j])
            {
                Console.Write($"{j} ");
            }
        }
    }
}
