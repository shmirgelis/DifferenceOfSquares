using System;
using System.Linq;

public static class DifferenceOfSquares
{
    private const int _startNum = 1;
    public static int CalculateSquareOfSum(int max)
    {
        var numsInRange = Enumerable.Range(_startNum, max);
        var sumOfNumsInRange = numsInRange.Sum(x => x);
        return sumOfNumsInRange*sumOfNumsInRange;
    }

    public static int CalculateSumOfSquares(int max)
    {
        var numsInRange = Enumerable.Range(_startNum, max);
        return numsInRange.Sum(x => x * x);
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}