using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        phrase = phrase.ToUpper();
        var acronym = new StringBuilder(phrase.Length);
        bool addLetter = true;

        foreach (char letter in phrase)
        {
            if (letter == '_') { continue; }
            if (addLetter && letter != ' ' && letter != '-')
            {
                acronym.Append(letter);
                addLetter = false;
            }
            if (letter == ' ' || letter == '-')
                addLetter = true;
        }
        return acronym.ToString();
    }
}