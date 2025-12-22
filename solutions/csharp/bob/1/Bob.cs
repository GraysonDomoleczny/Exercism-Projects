public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        if (string.IsNullOrEmpty(statement)) return "Fine. Be that way!";
        
        if (statement.Last() == '?' 
            && statement.Any(char.IsLetter) 
            && statement == statement.ToUpper()) 
            return "Calm down, I know what I'm doing!";
        
        if (statement.Last() == '?') return "Sure.";
        
        if (statement.Any(char.IsLetter) 
            && statement == statement.ToUpper())
            return "Whoa, chill out!";
        
        return "Whatever.";
    }
}