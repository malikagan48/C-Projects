Console.Write("Text Giriniz: ");
var text = Console.ReadLine();

Console.Write("Karakter Indexi Giriniz (0-" + (text.Length - 1) + "): ");
int index = 0;
Console.WriteLine(text.Remove(index, 1));
Console.ReadLine();