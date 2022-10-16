string ch = "Merhaba Hello Question";
string newch = "";
string letterHolder = "";
for (int i = 0; i <= ch.Length; i++)
{
    if (i == 0)
    {
        letterHolder = ch[i].ToString();
    }
    else if (i == ch.Length)
    {
        newch += letterHolder;
    }
    else if (ch[i - 1].ToString() == " ")
    {
        continue;
    }
    else if (ch[i].ToString() == " ")
    {
        newch += letterHolder + " ";
        letterHolder = ch[i + 1].ToString();
    }
    else
    {
        newch += ch[i].ToString();
    }
}
Console.WriteLine(newch);