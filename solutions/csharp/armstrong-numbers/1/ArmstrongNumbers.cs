public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
        => number.ToString()
        .Sum(digit => Math.Pow(digit - '0', number.ToString().Length))
        == number;
}