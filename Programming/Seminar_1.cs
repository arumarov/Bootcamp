// Написать программу, которая на вход получает строку,
// а на выходе выдает строку, в которой удалены все символы

// ваыикка89мамвкм9 >==> ваыиккамамвкм

string ClearString(string s)
{
    string result = String.Empty;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '1'
        ) { }
        else result = result + $"{s[i]}";
    }
    return result;
}

Console.WriteLine(ClearString("ваыикка89мамвкм9"));
