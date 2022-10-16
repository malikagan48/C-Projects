a1:
try
{
    Console.WriteLine("Please enter a word");
    string word=Console.ReadLine();
    Console.WriteLine("Please enter the digits of the letters you want to destroy:");
    ShowTime(word); goto a1;

static void ShowTime(string word)
{
        int start = 1;
        int mik = word.Length;
        while (start<=mik)
        {
            int x = Int32.Parse(Console.ReadLine());
            word = word.Remove(x,1);
            Console.WriteLine("result:{0}",word);
            start++;
        }

}

}
catch { Console.WriteLine("You have an error... You are going to the main menu.");goto a1; }