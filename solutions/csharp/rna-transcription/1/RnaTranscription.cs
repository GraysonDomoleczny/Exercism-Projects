public static class RnaTranscription
{
    public static string ToRna(string strand) =>
        new string(strand.Select(n => 
        n == 'G' ? 'C' :  
        n == 'C' ? 'G' : 
        n == 'T' ? 'A' :
        n == 'A' ? 'U' : 
        n)
        .ToArray());
}