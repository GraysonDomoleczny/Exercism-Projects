public static class ScrabbleScore
{
    private static readonly Dictionary<string, int> points = new()
    {
        ["AEIOULNRST"] = 1,
        ["DG"] = 2,
        ["BCMP"] = 3,
        ["FHVWY"] = 4,
        ["K"] = 5,
        ["JX"] = 8,
        ["QZ"] = 10
    };
    
    public static int Score(string input)
    {
        input = input.ToUpper();
        int score = 0;
        
        foreach (char letter in input)
        {
            foreach (KeyValuePair<string, int> key in points)
            {
                if (key.Key.Contains(letter))
                { 
                    score += key.Value; 
                    break; 
                }
            }
        }
        return score;
    }
}