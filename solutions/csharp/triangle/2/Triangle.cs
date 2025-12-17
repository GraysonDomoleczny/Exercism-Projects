public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        var s = new[] {side1, side2, side3};
        Array.Sort(s);
        return s[0] + s[1] > s[2] &&
               s.All(s => s > 0) &&
               s[0] != s[1] && 
               s[1] != s[2] && 
               s[0] != s[2];  
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        var s = new[] {side1, side2, side3};
        Array.Sort(s);
        return s[0] + s[1] > s[2] &&
              (s[0] == s[1] ||
               s[1] == s[2] ||
               s[0] == s[2]);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) =>
        side1 == side2 && side2 == side3 && side1 > 0;
}