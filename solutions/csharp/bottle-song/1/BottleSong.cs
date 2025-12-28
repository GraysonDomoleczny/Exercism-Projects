using System.Collections.Generic;

public static class BottleSong
{   
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        string[] numberOfBottles = { "no", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

        for (int i = 0; i < takeDown; i++)
        {
            yield return $"{numberOfBottles[startBottles]} green bottle{(startBottles == 1 ? "" : "s")} hanging on the wall,";
            yield return $"{numberOfBottles[startBottles]} green bottle{(startBottles == 1 ? "" : "s")} hanging on the wall,";
            yield return "And if one green bottle should accidentally fall,";
            yield return $"There'll be {numberOfBottles[startBottles - 1].ToLower()} " +
                         $"green bottle{(startBottles == 2 ? "" : "s")} hanging on the wall.";
            
            startBottles --;
            if (i < takeDown - 1) yield return "";
        }
    }
        
}
