public static class Raindrops
{
    public static string Convert(int number)
    {
       string sound = 
           (number % 3 == 0 ? "Pling" : "") +
           (number % 5 == 0 ? "Plang" : "") +
           (number % 7 == 0 ? "Plong" : "");

        return sound == "" ? number.ToString() : sound;
    }
}