
string text = "- Я думаю, - сказал князь, улыбаясь,  - что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадидет мне чаю?";

// srting s = "qwerty"
//             012345
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    System.Console.WriteLine("start function");
    string result = String.Empty;

    int Length = text.Length;
    for (int i = 0; i < Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    }


    return result;
}

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);

System.Console.WriteLine();
newText = Replace(newText, 'к', 'K');
System.Console.WriteLine(newText);

System.Console.WriteLine();
newText = Replace(newText, 'с', 'C');
System.Console.WriteLine(newText);