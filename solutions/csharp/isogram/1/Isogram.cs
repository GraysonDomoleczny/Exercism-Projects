using System.Text;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        var sortedWord = new StringBuilder(word.Length);
        string lettersInWord = "";

        foreach (char letter in word)
        {
            if (letter == '-' || letter == ' ') { sortedWord.Append(letter); continue; }
            if (!lettersInWord.Contains(letter))
            {
                sortedWord.Append(letter);
                lettersInWord += letter;
            }
        }
        return word.Length == sortedWord.Length;
    }
}
