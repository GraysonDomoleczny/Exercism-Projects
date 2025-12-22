public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        bool isEmpty = string.IsNullOrEmpty(statement);
        bool isQuestion = statement.EndsWith('?');
        bool isYelling = statement.Any(char.IsLetter) && statement == statement.ToUpper();
        
        if (isEmpty) return "Fine. Be that way!";
        if (isQuestion && isYelling) return "Calm down, I know what I'm doing!";
        if (isQuestion) return "Sure.";
        if (isYelling) return "Whoa, chill out!";
        return "Whatever.";
    }
}