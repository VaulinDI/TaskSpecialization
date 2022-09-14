void ChangeString(string[] s)
{
    string[] change = new string[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length <= 3)
        {
            change[i] = s[i];
            Console.Write(change[i] + "  ");
        }
    }
}

string[] s1 = { "Hello", "2", "world", ":-)" };
string[] s2 = { "1234", "1567", "-2", "computer science"};
string[] s3 = { "Russia", "Denmark", "Kazan"};

ChangeString(s1);
Console.WriteLine();
ChangeString(s2);
Console.WriteLine();
ChangeString(s3);