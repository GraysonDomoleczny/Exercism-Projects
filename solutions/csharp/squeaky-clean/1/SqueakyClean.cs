using System.Text;
    
public static class Identifier
{
    public static string Clean(string identifier)
    {
        var s = new StringBuilder(identifier.Length);
        bool makeUpper = false;
        
        foreach (char c in identifier)
        {
            if (c >= 'α' && c <= 'ω') continue;
            if (c == ' ') { s.Append('_'); continue; }
            if (c == '-') { makeUpper = true; continue; }
            if (char.IsControl(c)) { s.Append("CTRL"); continue; }
            if (makeUpper)
            {
                s.Append(char.ToUpper(c));
                makeUpper = false;
                continue;
            }
            if (char.IsLetter(c)) s.Append(c);
        }
        return s.ToString();
    }
}
