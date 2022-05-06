// Написать программу, которая на вход получает строку,
// а на выходе выдает строку, в которой удалены все символы

// ваыикка89мамвкм9 >==> ваыиккамамвкм

string ClearString(string s)
{
    string result = String.Empty;
    for (int i = 0; i < s.Length; i++)
    {
        if (
            s[i] == '1'
            || s[i] == '2'
            || s[i] == '8'
            || s[i] == '9'
            || s[i] == '0'            
        ) { }
        else result = result + $"{s[i]}";
    }
    return result;
}

void ClearStringTest01() // описываем тест
{
    bool res = "ваыиккамамвкм"
    == ClearString("ваыикка89мамвкм9");
    System.Console.WriteLine(res);
}

void ClearStringTest02() // описываем еще тест
{
    bool res = "ваыиккамамвкм"
    == ClearString("ваыи2кка89мамвк32м9");
    System.Console.WriteLine(res);
}

Console.WriteLine(ClearString("ваыикка89мамвкм9"));

ClearStringTest01();
ClearStringTest02();