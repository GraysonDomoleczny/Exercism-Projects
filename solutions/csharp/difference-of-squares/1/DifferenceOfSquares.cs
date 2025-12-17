using System;
public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int total = 0;
        int numberToAdd = 1;
        while (numberToAdd < max+1)
        {
            total += numberToAdd;
            numberToAdd++;
        }
        return (int)Math.Pow(total, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        int total = 0;
        int numberToAdd = 1;
        while (numberToAdd < max+1)
        {
            total += (int)Math.Pow(numberToAdd, 2);
            numberToAdd++;
        }
        return total;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}