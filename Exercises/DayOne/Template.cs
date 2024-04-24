namespace DayOne;

public class Template
{
    public const string DefaultNumber = "1234567890";

    public static string NumericFormatter(string template, string number = DefaultNumber)
    {
        var numberFormatted = string.Empty;
        var position = 0;
        var maxPosition = number.Length;

        foreach (var character in template)
        {
            if (char.IsLetter(character))
            {
                numberFormatted += number[position];
                position = (position + 1) % maxPosition;
            }
            else
            {
                numberFormatted += character;
            }
        }

        return numberFormatted;
    }
}
