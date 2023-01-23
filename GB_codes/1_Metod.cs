// Пример вызова метода замены символов в тексте

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) 
        {
            result += ($"{newValue}");
        }
        else 
        {
            result += ($"{text[i]}");
        }
    }
    return result;
}
string text = Console.ReadLine();
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);